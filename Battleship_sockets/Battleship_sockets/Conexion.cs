using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace Battleship_sockets
{
    public class Conexion
    {
        #region ATTRIBUTES
        // Para saber si se ha iniciado como Servidor o como Cliente        
        public Game _form;
        public List<Ship> shipList;
        private TcpListener tcpListener;
        private TcpClient tcpClient;
        public bool serverReady;
        public bool clientReady;
        public bool isMyTurn;
        public bool isReady;
        public bool isWater;
        public bool isHit;
        public bool isWin;
        public bool isSunk;
        public int SunkShips = 0;
        public bool isConnected;
        public bool serverStarts;
        public bool _opponentResponseReceived;
        private readonly UserViewModel _userViewModel;
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        #endregion
        public Conexion(Game gameForm, UserViewModel userViewModel)
        {
            //this.isServer = isServer;
            _userViewModel = userViewModel;
            _form = gameForm;
            shipList = new List<Ship>();
        }
        public void WhoStart()
        {
            if (_form.IsServer)
            {
                Random rnd = new();
                int randomNumber = rnd.Next(1, 101);
                if (randomNumber <= 50)
                {
                    // Empieza server
                    string msg = "Empieza el servidor";
                    Send(msg);
                    _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add(msg)));
                    serverStarts = true;
                }
                else
                {
                    // Empieza client
                    string msg = "Empieza el cliente";
                    Send(msg);
                    _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add(msg)));
                    serverStarts = false;
                }
            }

        }
        public void Connect()
        {
            if (_form.IsServer)
            {
                try
                {
                    tcpListener = new TcpListener(IPAddress.Any, 8080);
                    Console.WriteLine("Server started and listening on port 8080...");
                    //_form.lblInfo.Text = "Esperando a un cliente...";
                    tcpListener.Start();
                    tcpClient = tcpListener.AcceptTcpClient();
                    _form.Invoke((MethodInvoker)(() => _form.panel_Ocultar.Visible = false));
                    _form.Invoke((MethodInvoker)(() => _form.panel_chat.Visible = true));
                    _form.Invoke((MethodInvoker)(() => _form.Enviar.Enabled = true));
                    _form.Invoke((MethodInvoker)(() => _form.txtMensaje.Enabled = true));
                    _form.Invoke((MethodInvoker)(() => _form.lstMensajes.BackColor = Color.LightCyan));
                    _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add($"Bienvenido al chat.")));
                    _form.Invoke((MethodInvoker)(() => _form.lblInfo.Text = string.Empty));
                    _form.Invoke((MethodInvoker)(() => _form.Width = 1273));



                    Task.Run(() => ReceiveAsync());
                }
                catch (Exception ex)
                {
                    _form.Invoke((MethodInvoker)(() => _form.lblInfo.Text = $"Error al conectar un cliente: {ex}"));
                }
            }
            else
            {
                while (!isConnected)
                {
                    try
                    {
                        tcpClient = new TcpClient();
                        tcpClient.Connect("127.0.0.1", 8080);
                        Console.WriteLine("Connected to Server.");
                        _form.Invoke((MethodInvoker)(() => _form.panel_Ocultar.Visible = false));
                        _form.Invoke((MethodInvoker)(() => _form.panel_chat.Visible = true));
                        _form.Invoke((MethodInvoker)(() => _form.Enviar.Enabled = true));
                        _form.Invoke((MethodInvoker)(() => _form.txtMensaje.Enabled = true));
                        _form.Invoke((MethodInvoker)(() => _form.lstMensajes.BackColor = Color.LightCyan));
                        _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add($"Bienvenido al chat.")));
                        _form.Invoke((MethodInvoker)(() => _form.lblInfo.Text = string.Empty));
                        _form.Invoke((MethodInvoker)(() => _form.Width = 1273));



                        Task.Run(() => ReceiveAsync());
                        isConnected = true;
                    }
                    catch (Exception e)
                    {
                        _form.Invoke((MethodInvoker)(() => _form.lbl_Welcome.Text = "No se puede encontrar un servidor. Reintentando..."));
                        Task.Delay(5000); // Esperar 5 segundos antes de intentar conectarse de nuevo
                    }

                }
            }
        }
        public void Send(string message)
        {
            if (tcpClient == null)
            {
                // El cliente no está conectado, no se puede enviar el mensaje
                Console.WriteLine("El cliente no está conectado.");
                return;
            }

            try
            {
                // Implementar envío de datos                
                byte[] dataS = Encoding.ASCII.GetBytes(message);
                NetworkStream streamS = tcpClient.GetStream();
                streamS.Write(dataS, 0, dataS.Length);
                Console.WriteLine($"Sent: {message}");
            }
            catch (Exception ex)
            {
                _form.Invoke((MethodInvoker)(() => _form.lblInfo.Text = $"Error al enviar un mensaje: {ex}"));
            }
        }
        public void Disconnect()
        {
            if (_form.IsServer)
            {
                Send("Disconnect");
                tcpListener.Stop();
            }
            else
            {
                Send("Disconnect");
                tcpClient.Close();
            }
        }
        public bool IsReadyToPlay()
        {
            return serverReady && clientReady;
        }
        private bool CheckShipInPosition(Position position)
        {
            if (IsReadyToPlay())
            {
                bool isHit = false;
                foreach (Ship ship in this.shipList)
                {
                    foreach (Position p in ship.Coords)
                    {
                        if (p.Row == position.Row && p.Col == position.Col)
                        {
                            // Marcar la posición como golpeada
                            p.IsHit = true;
                            isHit = true;
                            _form.Invoke((MethodInvoker)(() => _form.lblInfo.Text = "¡Te han dado! ¡Es tu turno!"));
                            Send("Tocado");
                            // Si todas las posiciones del barco han sido golpeadas, marcar el barco como hundido
                            if (ship.Coords.All(c => c.IsHit))
                            {
                                _form.Invoke((MethodInvoker)(() => _form.lblInfo.Text = "¡Han hundido tu barco! ¡Es tu turno!"));
                                isSunk = true;
                                Send("Hundido");
                                SunkShips++; // Incrementa el contador de barcos hundidos
                                             //ChangeLabel("¡HAN HUNDIDO TU BARCO!");

                                // Si todos los barcos han sido hundidos, enviar un mensaje y cerrar la conexión
                                if (SunkShips == _form.totalShips)
                                {
                                    _form.Invoke((MethodInvoker)(() => _form.lbl_Welcome.Text = "FIN DE LA PARTIDA: HAS PERDIDO"));
                                    _form.Invoke((MethodInvoker)(() => _form.panel_Ocultar.Visible = true));
                                    _form.Invoke((MethodInvoker)(() => _form.lblInfo.Visible = false));
                                    _form.Invoke((MethodInvoker)(() => _form.panel_chat.Visible = false)); ;
                                    _form.Invoke((MethodInvoker)(() => _form.Width=1000)); 
                                    isWin = true;

                                    if (isWin)
                                    {
                                        Send("You win");
                                    }
                                    if (_form.IsServer)
                                        tcpListener.Stop();
                                    else
                                        tcpClient.Close();

                                    return true;
                                }
                                // Add this line to reset the isSunk variable to false
                                isSunk = false;
                            }
                            // Cambiar el color del botón correspondiente
                            
                            Button button = _form.gameBoard1[position.Row, position.Col];
                            button.BackColor = Color.Red;
                            return true;
                        }
                    }
                }
                if (!isHit)
                {
                    _form.Invoke((MethodInvoker)(() => _form.lblInfo.Text = "¡Agua, no te han dado! ¡Es tu turno!"));
                    Send("Agua");
                    // Cambiar el color del botón correspondiente
                    Button button2 = _form.gameBoard1[position.Row, position.Col];
                    button2.BackColor = Color.Cyan;
                    return true;
                }
            }
            return false;
        }
        public async Task ReceiveAsync()
        {
            byte[] data = new byte[1024];
            NetworkStream stream = tcpClient.GetStream();
            while (true)
            {
                int bytesReceived = await stream.ReadAsync(data, 0, data.Length);
                string message = Encoding.ASCII.GetString(data, 0, bytesReceived);
                _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add(message)));

                if (message.EndsWith("servidor"))
                {
                    serverStarts = true;
                    //_form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add(message)));
                }
                if (message.EndsWith("cliente"))
                {
                    serverStarts = false;
                    //_form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add(message)));
                }
                if (message.StartsWith("Check:"))
                {
                    string[] parts = message.Split(':');
                    if (parts.Length == 2)
                    {
                        string[] coords = parts[1].Split(',');
                        if (coords.Length == 2 && char.TryParse(coords[0], out char letter) && int.TryParse(coords[1], out int column))
                        {
                            // Convertir la letra a número de fila
                            int row = letter - 'A';

                            Position position = new Position { Row = row, Col = column };
                            //bool thereIsAShip = CheckShipInPosition(position);
                            CheckShipInPosition(position);
                            //Send($"{(thereIsAShip ? "Tocado" : "Agua")}");                           
                            isMyTurn = true;
                            _form.CheckTurn();
                        }
                    }
                }
                if (message.EndsWith("play!"))
                {
                    if (_form.IsServer)
                    {
                        clientReady = true;
                        //_form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add($"{_userViewModel.userName}: {message}")));
                    }
                    else
                    {
                        serverReady = true;
                        // _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add($"{_userViewModel.userName}: {message}")));

                    }
                }
                if (message.StartsWith("Disconnect"))
                {
                    if (_form.IsServer)
                    {
                        _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add("El cliente se ha desconectado.")));
                        _form.Invoke((MethodInvoker)(() => _form.panel_Ocultar.Visible = true));
                        _form.Invoke((MethodInvoker)(() => _form.btnBacktoMenu.Visible = true));

                    }
                    else
                    {
                        _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add("El servidor se ha desconectado.")));
                        _form.Invoke((MethodInvoker)(() => _form.panel_Ocultar.Visible = true));
                        _form.Invoke((MethodInvoker)(() => _form.btnBacktoMenu.Visible = true));
                    }
                }
                if (message.StartsWith("Agua"))
                {
                    //ChangeLabel("¡Agua!");
                    string msgWater = $"{_userViewModel.userName}: ¡Uy...¡Agua! ¡Ahora es su turno!";
                    //_form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add(msgWater)));
                    isWater = true;
                    isSunk = false;
                    isHit = false;
                    _opponentResponseReceived = true;
                }
                if (message.StartsWith("Tocado"))
                {
                    //ChangeLabel("¡Tocado!");
                    string msgHit = $"{_userViewModel.userName}: ¡Le has dado! ¡Ahora es su turno!";
                   // _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add(msgHit)));
                    isWater = false;
                    isHit = true;
                    isSunk = false;
                    _opponentResponseReceived = true;
                }
                if (message.StartsWith("Hundido"))
                {
                    // ChangeLabel("¡Barco hundido!");
                    string msgSunk = $"{_userViewModel.userName}: ¡Has hundido un barco! ¡Ahora es su turno!!";
                    _form.Invoke((MethodInvoker)(() => _form.lblInfo.Text = msgSunk));
                    // _form.Invoke((MethodInvoker)(() => _form.lstMensajes.Items.Add(msgSunk)));
                    isWater = false;
                    isHit = false;
                    isSunk = true;
                    _opponentResponseReceived = true;
                }
                if (message.StartsWith("You win"))
                {
                    _form.Invoke((MethodInvoker)(() => _form.lbl_Welcome.Text = "¡ENHORABUENA, HAS GANADO LA PARTIDA!"));
                    _form.Invoke((MethodInvoker)(() => _form.panel_Ocultar.Visible = true));
                    _form.Invoke((MethodInvoker)(() => _form.lblInfo.Visible = false));
                    _form.Invoke((MethodInvoker)(() => _form.panel_chat.Visible=false));
                    _form.Invoke((MethodInvoker)(() => _form.Width = 1000));
                }
            }
        }
        public void ChangeLabel(string text)
        {
            // _form.Invoke((MethodInvoker)(() => _form.lblWaterOrHit.Text = text));
            _form.Invoke((MethodInvoker)(() => _form.lblInfo.Text = text));
        }
    }
}