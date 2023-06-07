using NAudio.Wave;

namespace Battleship_sockets
{
    internal static class Program
    {
        private static Thread backgroundMusicThread;
        private static Thread soundEffectThread;
        private static bool isRunning = true;
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Iniciar hilo de música de fondo
            backgroundMusicThread = new Thread(new ThreadStart(BackgroundMusicThread));
            backgroundMusicThread.Start();

            // Mostrar el formulario
            ApplicationConfiguration.Initialize();
            Application.Run(new Splash());

            // Detener los hilos de audio cuando se cierra la aplicación
            isRunning = false;
            backgroundMusicThread.Join();
            soundEffectThread.Join();
        }
        public static void BackgroundMusicThread()
        {
            // Cargar archivo de audio de fondo
            string audioPath = "audio/BattleshipSockets_Main-Theme_.wav";
            var audioFile = new AudioFileReader(audioPath);
            var loopedAudioFile = new LoopStream(audioFile);
            var audioOutput = new WaveOutEvent();

            // Reproducir audio de fondo en bucle hasta que se detenga el hilo
            audioOutput.Init(loopedAudioFile);
            audioOutput.Play();
            while (isRunning)
            {
                Thread.Sleep(1000);
            }
            audioOutput.Stop();
            audioOutput.Dispose();
            audioFile.Dispose();
        }

        public static void PlaySoundEffect_Stack()
        {
            // Cargar archivo de efecto de sonido
            string audioPath = "audio/ShipLand.mp3";
            var audioFile = new AudioFileReader(audioPath);
            var audioOutput = new WaveOutEvent();

            // Reproducir efecto de sonido una vez
            audioOutput.Init(audioFile);
            audioOutput.Play();
            Thread.Sleep((int)audioFile.TotalTime.TotalMilliseconds);
            audioOutput.Stop();
            audioOutput.Dispose();
            audioFile.Dispose();
        }
        public static void PlaySoundEffect_Water()
        {
            // Cargar archivo de efecto de sonido
            string audioPath = "audio/Agua.wav";
            var audioFile = new AudioFileReader(audioPath);
            var audioOutput = new WaveOutEvent();

            // Reproducir efecto de sonido una vez
            audioOutput.Init(audioFile);
            audioOutput.Play();
            Thread.Sleep((int)audioFile.TotalTime.TotalMilliseconds);
            audioOutput.Stop();
            audioOutput.Dispose();
            audioFile.Dispose();
        }
        public static void PlaySoundEffect_Hit()
        {
            // Cargar archivo de efecto de sonido
            string audioPath = "audio/Tocado.wav";
            var audioFile = new AudioFileReader(audioPath);
            var audioOutput = new WaveOutEvent();

            // Reproducir efecto de sonido una vez
            audioOutput.Init(audioFile);
            audioOutput.Play();
            Thread.Sleep((int)audioFile.TotalTime.TotalMilliseconds);
            audioOutput.Stop();
            audioOutput.Dispose();
            audioFile.Dispose();
        }
        public static void PlaySoundEffect_Ambient()
        {
            // Cargar archivo de efecto de sonido
            string audioPath = "audio/SpaceAmbient.mp3";
            var audioFile = new AudioFileReader(audioPath);
            var audioOutput = new WaveOutEvent();

            // Reproducir efecto de sonido una vez
            audioOutput.Init(audioFile);
            audioOutput.Play();
            Thread.Sleep((int)audioFile.TotalTime.TotalMilliseconds);
            audioOutput.Stop();
            audioOutput.Dispose();
            audioFile.Dispose();
        }
        public static void PlaySoundEffect_ButtonOver()
        {
            // Cargar archivo de efecto de sonido
            string audioPath = "audio/button_over.wav";
            var audioFile = new AudioFileReader(audioPath);
            var audioOutput = new WaveOutEvent();

            // Reproducir efecto de sonido una vez
            audioOutput.Init(audioFile);
            audioOutput.Play();
            Thread.Sleep((int)audioFile.TotalTime.TotalMilliseconds);
            audioOutput.Stop();
            audioOutput.Dispose();
            audioFile.Dispose();
        }
    }
}