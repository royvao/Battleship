#region SUPRESS WARNINGS
#pragma warning disable IDE0079
#pragma warning disable IDE0044
#pragma warning disable IDE0090
#pragma warning disable CS18622
#pragma warning disable CS8622
#pragma warning disable CS8604
#endregion

using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Media;
using System.Security.Policy;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Battleship_sockets
{
    public partial class Game : Form
    {
        #region ATTRIBUTES
        public Conexion _c;
        public int totalShips = 4;
        private int addedShips;
        public Button[,] gameBoard1;
        private Button[,] gameBoard2;
        private Ship currentShip; // Variable que almacenará el barco creado en BtnAddShip1_Click
        private string orientation;
        private readonly UserViewModel _userViewModel;
        Welcome w = new();
        List<Position> coords = new List<Position>();
        private bool _isServer = false;
        public bool IsServer { get => _isServer; set => _isServer = value; }
        private Timer timer;
        private int numDots = 0;
        #endregion
        public Game(bool isServer, UserViewModel userViewModel)
        {
            InitializeComponent();
            InitializeGameBoard();
            _userViewModel = userViewModel;
            this.Width = 1000;
            lblInfo.Text = $"bienvenido a hundir la flota {_userViewModel.userName}".ToUpper();
            IsServer = isServer;
            _c = new Conexion(this, userViewModel);
            btnReady.Enabled = false;
            panel_chat.Visible = false;
            BtnDestructor.Enabled = false;
            BtnExplorer.Enabled = false;
            BtnLightning.Enabled = false;
            Enviar.Enabled = false;
            txtMensaje.Enabled = false;
            btnClear.Enabled = false;
            timer = new Timer();
            timer.Interval = 500; // Intervalo de tiempo en milisegundos
            timer.Tick += Timer_Tick;

            #region RADIOBUTTON
            RBtnH.Visible = false;
            RBtnV.Visible = false;
            #endregion

        }
        private static string GetRowLabel(int rowIndex)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return alphabet[rowIndex].ToString();
        }
        private void InitializeGameBoard()
        {
            int buttonWidth = 25;
            int buttonHeight = 25;
            int labelWidth = 25; // width of row and column labels
            int labelHeight = 25; // height of row and column labels
            gameBoard1 = new Button[10, 10];
            gameBoard2 = new Button[10, 10];
            for (int row = 0; row < 10; row++)
            {
                // MI PANEL 
                Label lblRow = new Label();
                lblRow.Text = GetRowLabel(row);
                lblRow.Location = new Point(0, row * buttonHeight + labelHeight);
                lblRow.Size = new Size(labelWidth, labelHeight);
                panel1.Controls.Add(lblRow);

                // PANEL OPONENTE
                lblRow = new Label();
                lblRow.Text = GetRowLabel(row);
                lblRow.Location = new Point(0, row * buttonHeight + labelHeight);
                lblRow.Size = new Size(labelWidth, labelHeight);
                panel2.Controls.Add(lblRow);

                for (int col = 0; col < 10; col++)
                {
                    // MI PANEL 
                    Label lblCol = new Label();
                    lblCol.Text = col.ToString();
                    lblCol.TextAlign = ContentAlignment.MiddleCenter;
                    lblCol.Location = new Point(col * buttonWidth + labelWidth, 0);
                    lblCol.Size = new Size(labelWidth, labelHeight);
                    panel1.Controls.Add(lblCol);

                    gameBoard1[row, col] = new Button
                    {
                        Name = GetRowLabel(row).ToString() + "," + col.ToString(),
                        Text = string.Empty,
                        Location = new Point((col + 1) * buttonWidth, (row + 1) * buttonHeight),
                        Size = new Size(buttonWidth, buttonHeight),
                        Enabled = false,
                        BackColor = Color.White
                    };
                    gameBoard1[row, col].Click += new EventHandler(Panel1_ButtonClick); // Add the Click event to the button
                    panel1.Controls.Add(gameBoard1[row, col]);

                    // PANEL OPONENTE
                    lblCol = new Label();
                    lblCol.Text = col.ToString();
                    lblCol.TextAlign = ContentAlignment.MiddleCenter;
                    lblCol.Location = new Point(col * buttonWidth + labelWidth, 0);
                    lblCol.Size = new Size(labelWidth, labelHeight);
                    panel2.Controls.Add(lblCol);

                    gameBoard2[row, col] = new Button
                    {
                        Name = GetRowLabel(row).ToString() + "," + col.ToString(),
                        Text = string.Empty,
                        Location = new Point((col + 1) * buttonWidth, (row + 1) * buttonHeight),
                        Size = new Size(buttonWidth, buttonHeight),
                        Enabled = false,
                        BackColor = SystemColors.ControlDark

                    };
                    gameBoard2[row, col].Click += new EventHandler(Panel2_ButtonClick); // Add the Click event to the button
                    panel2.Controls.Add(gameBoard2[row, col]);
                }
            }
        }
        private async void BtnReady_Click(object sender, EventArgs e)
        {

            if (IsServer)
            {
                Task.Run(_c.WhoStart);
                _c.serverReady = true;
            }
            else
            {
                _c.clientReady = true;
            }

            string mensaje = $"{_userViewModel.userName}: Ready to play!";
            _c.Send(mensaje);

            btnReady.Enabled = false;
            btnClear.Enabled = false;
            await CheckReadyAsync();
        }
        private async Task CheckReadyAsync()
        {
            while (!_c.IsReadyToPlay())
            {
                lblInfo.Text = "Esperando a que el enemigo esté listo para jugar...";
                await Task.Delay(500);
            }

            btnReady.Visible = false;
            if (IsServer)
            {
                if (_c.serverStarts)
                {
                    lblInfo.Text = "¡Empiezas tú, dispara!";
                    _c.isMyTurn = true;
                    foreach (Control control in panel2.Controls)
                    {
                        if (control is Button button)
                        {
                            button.Enabled = true;
                            button.BackColor = Color.White;
                        }
                    }
                }
                else
                {
                    lblInfo.Text = "¡Empieza el enemigo!";
                    _c.isMyTurn = false;
                    foreach (Control control in panel2.Controls)
                    {
                        if (control is Button button)
                        {
                            button.Enabled = false;
                            button.BackColor = Color.White;
                        }
                    }
                }
            }
            else
            {
                if (_c.serverStarts)
                {
                    lblInfo.Text = "¡Empieza el enemigo!";
                    _c.isMyTurn = false;
                    foreach (Control control in panel2.Controls)
                    {
                        if (control is Button button)
                        {
                            button.Enabled = false;
                            button.BackColor = Color.White;
                        }
                    }
                }
                else
                {
                    lblInfo.Text = "¡Empiezas tú, dispara!";
                    _c.isMyTurn = true;
                    foreach (Control control in panel2.Controls)
                    {
                        if (control is Button button)
                        {
                            button.Enabled = true;
                            button.BackColor = Color.White;
                        }
                    }
                }
            }
        }
        private void Destructor_Click(object sender, EventArgs e)
        {
            currentShip = new Ship("Destructor", 6, Color.Coral, coords, orientation);
            RBtnH.Visible = true;
            RBtnV.Visible = true;
            addedShips++;
        }
        private void Explorer_Click(object sender, EventArgs e)
        {
            currentShip = new Ship("Explorer", 5, Color.Yellow, coords, orientation);
            RBtnH.Visible = true;
            RBtnV.Visible = true;
            addedShips++;
        }
        private void Lightning_Click(object sender, EventArgs e)
        {
            currentShip = new Ship("Lightning", 4, Color.RebeccaPurple, coords, orientation);
            RBtnH.Visible = true;
            RBtnV.Visible = true;
            addedShips++;
        }
        private void Aurora_Click(object sender, EventArgs e)
        {
            currentShip = new Ship("Aurora", 3, Color.LightGreen, coords, orientation);
            RBtnH.Visible = true;
            RBtnV.Visible = true;
            addedShips++;
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            QuitShips();
            addedShips = 0;
            BtnDestructor.Enabled = true;
            BtnExplorer.Enabled = true;
            BtnLightning.Enabled = true;
            btnReady.Enabled = false;
            lblInfo.Text = string.Empty;
        }
        private void QuitShips()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                    button.BackColor = Color.White;
                }
            }
            foreach (Control control in panel2.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = false;
                    button.BackColor = SystemColors.ControlDark;
                }
            }
        }
        public void CheckTurn()
        {
            if (_c.isMyTurn)
            {
                // Usar la clase "Invoke" para actualizar el estado de los controles en la interfaz de usuario desde otro hilo.
                // La clase Invoke permite ejecutar una acción en el hilo de la interfaz de usuario.

                Invoke(new Action(() =>
                {
                    foreach (Control control in panel2.Controls)
                    {
                        if (control is Button button)
                        {
                            button.Enabled = _c.isMyTurn; //true
                            if (button.BackColor != Color.White)
                            {
                                button.Enabled = false;
                            }
                        }
                    }
                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    foreach (Control control in panel2.Controls)
                    {
                        if (control is Button button)
                        {
                            button.Enabled = _c.isMyTurn; //false
                        }
                    }
                }));
            }
        }
        private async void Panel2_ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _c.Send($"Check:{button.Name}");
            _c.isMyTurn = false;  // Cambia el turno

            button.Enabled = false;
            while (!_c._opponentResponseReceived) // Espera a que se reciba la respuesta del oponente
            {
                await Task.Delay(100);
            }
            Invoke(new MethodInvoker(delegate ()
            {
                if (_c.isWater)
                {
                    Program.PlaySoundEffect_Water();
                    lblInfo.Text = "AGUA... ¡Es su turno!";
                    button.BackColor = Color.Cyan;
                    button.Enabled = false;
                }
                else
                {
                    Program.PlaySoundEffect_Hit();
                    lblInfo.Text = "TOCADO... ¡Es su turno!";
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                }
            }));
            _c._opponentResponseReceived = false; // Reinicia la variable para el siguiente turno
            CheckTurn();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (IsServer)
            {
                if (numDots == 0)
                {
                    lbl_Welcome.Text = "Esperando a un cliente";
                    numDots++;
                    Task.Delay(1000);
                }
                else if (numDots == 1)
                {
                    lbl_Welcome.Text = "Esperando a un cliente.";
                    numDots++;
                    Task.Delay(1000);
                }
                else if (numDots == 2)
                {
                    lbl_Welcome.Text = "Esperando a un cliente..";
                    numDots++;
                    Task.Delay(1000);

                }
                else if (numDots == 3)
                {
                    lbl_Welcome.Text = "Esperando a un cliente...";
                    numDots = 0;
                    Task.Delay(1000);

                }
            }
            else
            {
                if (numDots == 0)
                {
                    lbl_Welcome.Text = "Buscando un servidor";
                    numDots++;
                    Task.Delay(1000);
                }
                else if (numDots == 1)
                {
                    lbl_Welcome.Text = "Buscando un servidor.";
                    numDots++;
                    Task.Delay(1000);
                }
                else if (numDots == 2)
                {
                    lbl_Welcome.Text = "Buscando un servidor..";
                    numDots++;
                    Task.Delay(1000);

                }
                else if (numDots == 3)
                {
                    lbl_Welcome.Text = "Buscando un servidor...";
                    numDots = 0;
                    Task.Delay(1000);

                }
            }
        }
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text != string.Empty)
            {
                string mensaje = txtMensaje.Text;
                string sendmsg = $"Yo: {mensaje}";
                string recivemsg = $"{_userViewModel.userName}: {mensaje}";

                // Agregar el mensaje al ListBox
                lstMensajes.Items.Add(sendmsg);
                _c.Send(recivemsg);
                // Limpiar el cuadro de texto
                txtMensaje.Clear();

                // Desplazarse al final del ListBox para mostrar el último mensaje agregado
                lstMensajes.SelectedIndex = lstMensajes.Items.Count - 1;
                lstMensajes.SelectedIndex = -1;
            }
        }
        private bool CanPlaceShip(int row, int col, Ship ship, string orientation)
        {
            try
            {
                if (currentShip.Orientation == "h" && col + currentShip.Size > 10) // Verifica si el barco cabe en la matriz de botones
                {
                    return false;
                }
                if (currentShip.Orientation == "v" && row + currentShip.Size > 10)
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Debe seleccionar un barco antes de colocar.";
            }

            foreach (Position pos in currentShip.Coords)
            {
                if (gameBoard1[pos.Row, pos.Col].Enabled == false)
                {
                    return false;
                }
            }
            return true;
        }
        private void Panel1_ButtonClick(object sender, EventArgs e)
        {

            Ship ship = new Ship(string.Empty, 0, Color.Wheat, coords, string.Empty); // Crea un nuevo barco con nombre "ship", sin tamaño y color estándar

            Button clickedButton = sender as Button; // Obtiene el botón que fue clickeado

            if (clickedButton != null)
            {
                int row = clickedButton.Name[0] - 'A'; // Obtiene la fila de la ubicación seleccionada
                int col = int.Parse(clickedButton.Name.Substring(2)); // Obtiene la columna de la ubicación seleccionada

                if (CanPlaceShip(row, col, currentShip, orientation)) // Verifica si la ubicación es válida para colocar el barco
                {
                    
                    currentShip.Coords = new List<Position>();
                    for (int i = 0; i < currentShip.Size; i++)
                    {
                        if (currentShip.Orientation == "h")
                        {
                            gameBoard1[row, col + i].BackColor = currentShip.Color; // Pinta la celda en el tablero del jugador en gris para indicar que un barco está en esa ubicación.
                            Thread.Sleep(100); // Forzar animación de pintado del barco
                            gameBoard1[row, col + i].Enabled = false; // Deshabilita el botón para que el jugador no pueda colocar otro barco en la misma ubicación.
                            currentShip.Coords.Add(new Position() { Row = row, Col = col + i });

                            foreach (Control control in panel1.Controls)
                            {
                                if (control is Button)
                                {
                                    ((Button)control).Enabled = false;
                                }
                            }
                        }
                        if (currentShip.Orientation == "v")
                        {
                            gameBoard1[row + i, col].BackColor = currentShip.Color;
                            Thread.Sleep(100);
                            gameBoard1[row + i, col].Enabled = false;
                            currentShip.Coords.Add(new Position() { Row = row + i, Col = col });
                            foreach (Control control in panel1.Controls)
                            {
                                if (control is Button)
                                {
                                    ((Button)control).Enabled = false;
                                }
                            }
                        }
                    }

                    if (currentShip == null)
                    {
                        lblInfo.Text = "No se ha elegido ningún barco para colocar.";
                    }
                    else
                    {
                        if (currentShip.Size == 5)
                        {
                            lblInfo.Text =
                                $"\n¡Has añadido un Destructor Estelar Valiente!" +
                                $"\nNaves añadidas: {addedShips}";


                        }
                        else if (currentShip.Size == 4)
                        {
                            lblInfo.Text =
                                $"\n¡Has añadido una Nave Exploradora Galáctica!" +
                                $"\nNaves añadidas: {addedShips}";

                        }
                        else if (currentShip.Size == 3)
                        {
                            lblInfo.Text =
                                $"\n¡Has añadido un Caza Estelar Relámpago!" +
                                $"\nNaves añadidas: {addedShips}";
                        }

                    }
                    if (addedShips == totalShips)
                    {
                        btnReady.Enabled = true;
                    }
                    currentShip.Name = string.Empty;
                    currentShip.Size = 0;
                    currentShip.Color = Color.White;
                    Program.PlaySoundEffect_Stack();
                }
                else
                {
                    MessageBox.Show("Ubicación no válida para colocar el barco."); // Muestra un mensaje de error si la ubicación no es válida
                }
            }

        }
        private void BtnBackToMenu_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainMenu menu = new MainMenu(_userViewModel);
            menu.ShowDialog();
            this.Close();

        }
        private void TxtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnEnviar_Click(sender, e);
            }
        }
        private void LstMensajes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                // Obtener el mensaje a dibujar
                string mensaje = lstMensajes.Items[e.Index].ToString();

                // Establecer la fuente y el color de fondo para el dibujo del mensaje
                Font fuente = new Font("Space Age", 8);

                // Establecer el color de fuente para el dibujo del mensaje según quién lo envió
                Brush colorFuente = Brushes.Black;

                // Si el mensaje fue enviado por ti, establecer el color de fondo a un gris claro y alinear a la derecha
                if (mensaje.StartsWith("Yo"))
                {
                    mensaje = mensaje.Substring(3); // Eliminar "Yo:" del mensaje
                    colorFuente = Brushes.Blue;
                    e.Graphics.DrawString(mensaje, fuente, colorFuente, e.Bounds.Right - e.Graphics.MeasureString(mensaje, fuente).Width, e.Bounds.Bottom);
                }
                else if (mensaje.StartsWith("Bienvenido"))
                {
                    // Establecer el color de fondo a blanco y alinear al centro del eje X
                    colorFuente = Brushes.Green;
                    StringFormat formato = new StringFormat();
                    formato.Alignment = StringAlignment.Center;
                    formato.LineAlignment = StringAlignment.Center;
                    RectangleF rect = new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                    e.Graphics.DrawString(mensaje, fuente, colorFuente, rect, formato);
                }
                else if (mensaje.Contains(':'))
                {
                    // Si el mensaje fue enviado por otro, establecer el color de fondo a blanco y alinear a la izquierda
                    e.Graphics.DrawString(mensaje, fuente, colorFuente, e.Bounds.Left, e.Bounds.Bottom);
                }
                else
                {
                    // Establecer el color de fondo a blanco y alinear al centro del eje X
                    colorFuente = Brushes.Red;
                    StringFormat formato = new StringFormat();
                    formato.Alignment = StringAlignment.Center;
                    formato.LineAlignment = StringAlignment.Center;
                    RectangleF rect = new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                    e.Graphics.DrawString(mensaje, fuente, colorFuente, rect, formato);
                }

                // Liberar los recursos de la fuente
                fuente.Dispose();
            }
        }
        private async void BtnConectar_Click(object sender, EventArgs e)
        {
            w.ShowDialog();
            if (IsServer)
            {
                timer.Start();
                _c.Send(_userViewModel.userName);
            }
            else
            {
                timer.Start();
                _c.Send(_userViewModel.userName);
            }
            lblMyShips.Text = $"{_userViewModel.userName}";
            lblInfo.Text = string.Empty;
            BtnDestructor.Enabled = true;
            BtnExplorer.Enabled = true;
            BtnLightning.Enabled = true;
            btnClear.Enabled = true;
            btnConectar.Visible = false;
            await Task.Run(_c.Connect);
            timer.Stop();

        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                e.SuppressKeyPress = true;
                lstMensajes.Items.Clear();
                addedShips = 0;
                this.Width = 1273;
                panel_Ocultar.Visible = false;
                panel_chat.Visible = true;
                btnReady.Enabled = true;
                BtnDestructor.Enabled = true;
                BtnExplorer.Enabled = true;
                BtnLightning.Enabled = true;
                Enviar.Enabled = true;
                txtMensaje.Enabled = true;
                btnClear.Enabled = true;
                btnBacktoMenu.Visible = true;
                lstMensajes.BackColor = Color.LightCyan;
                btnConectar.Visible = false;
                lblInfo.Text = "Has entrado en modo desarrollador";
                foreach (Control control in panel1.Controls)
                {
                    if (control is Button button)
                    {
                        //button.Enabled = true;
                        button.BackColor = Color.White;
                    }
                }
                foreach (Control control in panel2.Controls)
                {
                    if (control is Button button)
                    {
                        button.Enabled = true;
                        button.BackColor = Color.White;
                    }
                }
                lstMensajes.Items.Add("Bienvenido al modo desarrollador");
            }
        }
        private void RBtnH_CheckedChanged(object sender, EventArgs e)
        {
            currentShip.Orientation = "h";
            _c.shipList.Add(currentShip);

            switch (currentShip.Name)
            {
                case "Destructor":
                    BtnDestructor.Enabled = false;
                    break;
                case "Explorer":
                    BtnExplorer.Enabled = false;
                    break;
                case "Lightning":
                    BtnLightning.Enabled = false;
                    break;
                case "Aurora":
                    BtnAurora.Enabled = false;
                    break;
            }

            RBtnH.Visible = false;
            RBtnV.Visible = false;
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled = true;
                }
            }
        }
        private void RBtnV_CheckedChanged(object sender, EventArgs e)
        {
            currentShip.Orientation = "v";
            _c.shipList.Add(currentShip);

            switch (currentShip.Name)
            {
                case "Destructor":
                    BtnDestructor.Enabled = false;
                    break;
                case "Explorer":
                    BtnExplorer.Enabled = false;
                    break;
                case "Lightning":
                    BtnLightning.Enabled = false;
                    break;
                case "Aurora":
                    BtnAurora.Enabled = false;
                    break;
            }

            RBtnH.Visible = false;
            RBtnV.Visible = false;
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled = true;
                }
            }
        }
        private void Btn_Enter(object sender, EventArgs e)
        {
            Program.PlaySoundEffect_ButtonOver();
        }
    }
}