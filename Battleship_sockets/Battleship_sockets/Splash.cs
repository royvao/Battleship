using Timer = System.Windows.Forms.Timer;

namespace Battleship_sockets
{
    public partial class Splash : Form
    {
        #region ATTRIBUTES
        private readonly Timer timer;
        private readonly List<string> phrases = new List<string>()
        {
            "Espere un momento mientras configuramos el escudo deflector. No queremos que un pequeño meteorito arruine su viaje interestelar.",
            "Recuerda siempre abrochar tu cinturón de seguridad. Nunca se sabe cuando vas a necesitar hacer una maniobra evasiva en el espacio.",
            "Preparando los motores de Warp... ¡Ups! Parece que alguien se olvidó de cargar combustible.",
            "Nos aseguramos de que todas las naves estén libres de tribbles antes de enviarlas. ¡No queremos un infestación en el espacio!",
            "En un momento comenzará la carga. No se preocupe, no necesitamos ninguna vacuna para el espacio exterior. Todavía.",
            "Los motores están encendidos. ¿Listo para despegar? ¡Advertencia! Los efectos especiales son reales y pueden causar vértigo en algunos jugadores.",
            "Recuerda no alimentar a los Gremlins después de medianoche. Ah, espera, eso es para otra cosa...",
            "Se dice que los extraterrestres nos observan desde el espacio. ¿Será verdad? Lo averiguaremos pronto.",
            "¡Cargando todo el espacio exterior en tu pantalla! Advertencia: puede ser adictivo."
        };
        private int currentPhraseIndex = 0;
        private int phraseTime = 0; // Contador de tiempo para cada frase
        #endregion

        public Splash()
        {
            InitializeComponent();
            
            // Inicializar temporizador
            timer = new Timer
            {
                Interval = 1000 // Tiempo de espera en milisegundos
            };
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            // Iniciar temporizador
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                // Actualizar barra de progreso
                progressBar1.Value++;
                lblCount.Text = "Cargando... " + ((progressBar1.Value * 100) / progressBar1.Maximum).ToString() + "%";
                if(progressBar1.Value == 1)
                {
                    lblPhrase.Text = "¿Sabías que el universo tiene más estrellas que granos de arena en la Tierra? ¡Y todavía tardamos un poco en cargar todo este contenido!";
                }
                // Actualizar texto cada 15 segundos
                phraseTime++;
                if (phraseTime == 10)
                {
                    currentPhraseIndex++;
                    if (currentPhraseIndex >= phrases.Count)
                    {
                        currentPhraseIndex = 0;
                    }
                    lblPhrase.Text = phrases[currentPhraseIndex];
                    phraseTime = 0;
                }
            }
            else
            {
                // Detener temporizador y cerrar formulario
                timer.Stop();
                this.Hide(); //oculta el formulario Splash
                UserControl userControl = new();
                userControl.ShowDialog();
                this.Close();
            }
        }

        private void Splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true;
                progressBar1.Value = progressBar1.Maximum;
                lblCount.Text = "Cargando 100%";
            }
        }
    }
}


