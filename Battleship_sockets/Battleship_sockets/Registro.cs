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
    public partial class Registro : Form
    {
        #region ATTRIBUTES
        string connectionString = @"Data Source=(local);Initial Catalog=Usuarios;Integrated Security=True";
        string queryString = "INSERT INTO usersData (userName, userPassword) VALUES (@usuario, @contraseña)";
        string checkQuery = "SELECT COUNT(*) FROM usersData WHERE userName = @userName";
        #endregion
        public Registro()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var userViewModel = new UserViewModel();
            string userName = userTxt.Text;
            string password = userPswd.Text;
            string password2 = userPswd2.Text;
            var random = new Random();
            int randomno = random.Next(0, 200);


            if (string.IsNullOrEmpty(userName))
            {
                lblError.Text = "Debe ingresar un nombre de usuario.";
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                lblError.Text = "Debe ingresar una contraseña.";
                return;
            }
            else if (string.IsNullOrEmpty(password2))
            {
                lblError.Text = "Debe repetir la contraseña.";
                return;
            }

            if (password == password2)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Verificar si el nombre de usuario ya existe en la base de datos
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@userName", userName);
                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0)
                {
                    lblError.Text = "El nombre de usuario ya existe.";
                    lblError.Text += "\nOtras opciones: " +
                        "@" + userName + randomno + 
                        " | @"+userName + ((randomno+randomno)-10) +
                        " | @"+userName + ((randomno+randomno)/3);
                    return;
                }
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@usuario", userName);
                command.Parameters.AddWithValue("@contraseña", password);
                command.ExecuteNonQuery();
                connection.Close();

                this.Hide();
                UserControl uc = new();
                uc.ShowDialog();
                this.Close();
            }
            else
            {
                lblError.Text = "Las contraseñas no coinciden.";
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserControl uc = new();
            uc.ShowDialog();
            this.Close();
        }
        private void Btn_Enter(object sender, EventArgs e)
        {
            Program.PlaySoundEffect_ButtonOver();
        }
    }
}
