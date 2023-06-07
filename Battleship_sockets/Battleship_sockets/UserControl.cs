using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Battleship_sockets
{
    public partial class UserControl : Form
    {
        #region ATTRIBUTES
        string connectionString = @"Data Source=(local);Initial Catalog=Usuarios;Integrated Security=True";
        string queryString = "SELECT COUNT(*) FROM usersData WHERE userName = @usuario AND userPassword = @contraseña";
        #endregion

        public UserControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var userViewModel = new UserViewModel();
            userViewModel.userName = userTxt.Text;
            string password = pswdTxt.Text;

            // Realizar la consulta a la base de datos al momento de crear la ventana
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@usuario", userViewModel.userName);
                command.Parameters.AddWithValue("@contraseña", password);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count == 1)
                {
                    // El usuario y la contraseña son válidos
                    this.Hide(); //oculta el formulario
                    MainMenu mainMenu = new(userViewModel);
                    mainMenu.ShowDialog(); //muestra el formulario MainMenu
                    this.Close();
                }
                else
                {
                    // El usuario y/o la contraseña son incorrectos
                    LblErrorMessage.Text = "Usuario o contraseña incorrectos.";
                }
            }
            
        }
        private void Label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro r = new();
            r.ShowDialog();
            this.Close();
        }
        private void UserControl_Load(object sender, EventArgs e)
        {
            userTxt.Focus();
        }
        private void PswdTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Button1_Click(sender, e);
            }
        }
        private void Btn_Enter(object sender, EventArgs e)
        {
            Program.PlaySoundEffect_ButtonOver();
        }
    }
}
