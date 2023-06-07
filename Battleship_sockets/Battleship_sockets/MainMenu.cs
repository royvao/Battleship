using Battleship_sockets.Properties;
using NAudio.Wave;
using System;

#region SUPRESS WARNINGS
#pragma warning disable 
#endregion

namespace Battleship_sockets
{
    public partial class MainMenu : Form
    {
        #region ATTRIBUTES
        private Form? form1;
        private WaveOut w;
        private readonly UserViewModel _userViewModel;       
        #endregion
        public MainMenu(UserViewModel userViewModel)
        {
            InitializeComponent();
            _userViewModel = userViewModel;
            w = new WaveOut();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool isServer = ((Button)sender).Tag.Equals("SERVER") ? true : false;
            this.Hide();
            form1 = new Game(isServer, _userViewModel);
            form1.ShowDialog();
            this.Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings s = new Settings(_userViewModel);
            s.ShowDialog();
            this.Close();
        }

        private void Btn_Enter(object sender, EventArgs e)
        {
            Program.PlaySoundEffect_ButtonOver();
        }
        private void BtnPlay_Enter(object sender, EventArgs e)
        {
            Program.PlaySoundEffect_ButtonOver();

            btnServer.Visible = true;
            btnCliente.Visible = true;
        }

        private void Unmute_Click(object sender, EventArgs e)
        {
            Mute.Visible = true;
            Unmute.Visible = false;
            w.Volume = 1;
        }

        private void Mute_Click(object sender, EventArgs e)
        {
            Unmute.Visible = true;
            Mute.Visible = false;
            w.Volume = 0;
        }
    }
}