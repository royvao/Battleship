using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_sockets
{

    public partial class Settings : Form
    {
        #region ATTRIBUTES
        private readonly UserViewModel _userViewModel;
        bool su;
        private int n1 = Properties.Settings.Default.v1;
        private int n2 = Properties.Settings.Default.v2;
        private int n3 = Properties.Settings.Default.v3;
        #endregion
        public Settings(UserViewModel userViewModel)
        {
            InitializeComponent();
            _userViewModel = userViewModel;
            n3++;
            if (n3 > 9)
            {
                n3 = 0;
                n2++;

                if (n2 > 9)
                {
                    n2 = 0;
                    n1++;
                }
            }
            Properties.Settings.Default.v1 = n1;
            Properties.Settings.Default.v2 = n2;
            Properties.Settings.Default.v3 = n3;
            Properties.Settings.Default.Save();
            lblVersion.Text = $"Version {n1}.{n2}.{n3}";

            BtnSecreto.Visible = false;
            lblUnlock.Enabled = false;

        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserControl uc = new();
            uc.ShowDialog();
            this.Close();
        }
        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                BtnSecreto.Text = "BLOQUEADO";
                BtnSecreto.Visible = true;
                lblUnlock.Enabled = true;
                BtnSecreto.Enabled = false;
                MessageBox.Show("HAS ACTIVADO UN NUEVO BOTÓN, BUSCA COMO DESBLOQUEARLO");
            }
        }
        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new(_userViewModel);
            mm.ShowDialog();
            this.Close();
        }
        private void BtnChPswd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChPswd cp = new(_userViewModel);
            cp.ShowDialog();
            this.Close();
        }
        private void BtnSecreto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has activado los poderes.\nLos logros que consigas durante esta sesión no se guardarán.\nPulsa 'Ctrl+D' en la pantalla de juego para activar el modo desarrollador.");
            this.Hide();
            Game gsu = new(su, _userViewModel);
            gsu.ShowDialog();

        }
        private void LblUnlock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ENHORABUENA, HAS DESBLOQUEADO EL BOTÓN");
            BtnSecreto.Enabled = true;
            BtnSecreto.Text = "ACTIVAR PODERES";

        }
        private void Btn_Enter(object sender, EventArgs e)
        {
            Program.PlaySoundEffect_ButtonOver();
        }
    }
}
