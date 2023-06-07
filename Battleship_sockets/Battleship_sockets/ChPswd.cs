using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_sockets
{
    public partial class ChPswd : Form
    {
        #region components
        private readonly UserViewModel _userViewModel;
        string connectionString = @"Data Source=(local);Initial Catalog=Usuarios;Integrated Security=True";
        string _selectQuery = "SELECT * FROM usersData WHERE userName = @usuario";
        string _updateQuery = "UPDATE usersData SET userPassword = @contraseña WHERE userName = @usuario";
        #endregion
        public ChPswd(UserViewModel userViewModel)
        {
            InitializeComponent();
            _userViewModel = userViewModel;
        }

        private void BtnChngpwd_Click(object sender, EventArgs e)
        {
            string oldPassword = txtActualPwd.Text;
            string newPassword1 = txtNewPassword.Text;
            string newPassword2 = txtNewPassword2.Text;

            if (string.IsNullOrWhiteSpace(oldPassword))
            {
                lblAp.Text = "Debe ingresar la contraseña actual.";
                lblNpw2.Text = "";
                lblNpw.Text = "";
                return;
            }
            else if (string.IsNullOrWhiteSpace(newPassword1))
            {
                lblNpw.Text = "Debe ingresar una contraseña nueva.";
                lblNpw2.Text = "";
                lblAp.Text = "";
                return;
            }
            else if (string.IsNullOrWhiteSpace(newPassword2))
            {
                lblNpw2.Text = "Debe repetir la contraseña nueva.";
                lblNpw.Text = "";
                lblAp.Text = "";
                return;
            }
            else if (newPassword1 != newPassword2)
            {
                lblAp.Text = "";
                lblNpw.Text = "";
                lblNpw2.Text = "";
                lblErrorMessage.Text = "Las contraseñas no coinciden.";
            }
            else if (oldPassword == newPassword1)
            {
                lblAp.Text = "";
                lblNpw.Text = "";
                lblNpw2.Text = "";
                lblErrorMessage.Text = "Las nueva contraseña es igual que la actual.";
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Busca al usuario en la base de datos
                    SqlCommand selectCommand = new SqlCommand(_selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@usuario", _userViewModel.userName);
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Si se encuentra al usuario, comprueba la contraseña
                        string actualPassword = reader.GetString(reader.GetOrdinal("userPassword"));
                        reader.Close(); // <-- Cerrar la lectura de datos aquí
                        if (oldPassword == actualPassword)
                        {
                            // Si la contraseña es correcta, actualiza la contraseña en la base de datos
                            SqlCommand updateCommand = new SqlCommand(_updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@contraseña", newPassword1);
                            updateCommand.Parameters.AddWithValue("@usuario", _userViewModel.userName);
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Si se ha actualizado la contraseña, muestra un mensaje de éxito y vuelve a la página de configuración
                                MessageBox.Show("Contraseña cambiada con éxito.");
                                this.Hide();
                                Settings s = new(_userViewModel);
                                s.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                // Si no se ha actualizado la contraseña, muestra un mensaje de error
                                lblAp.Text = "";
                                lblNpw.Text = "";
                                lblNpw2.Text = "";
                                lblErrorMessage.Text = "No se ha podido cambiar la contraseña.";
                            }
                        }
                        else
                        {
                            // Si la contraseña es incorrecta, muestra un mensaje de error
                            lblAp.Text = "";
                            lblNpw.Text = "";
                            lblNpw2.Text = "";
                            lblErrorMessage.Text = "La contraseña actual es incorrecta.";
                        }
                    }
                    else
                    {
                        // Si no se encuentra al usuario, muestra un mensaje de error
                        lblAp.Text = "";
                        lblNpw.Text = "";
                        lblNpw2.Text = "";
                        lblErrorMessage.Text = "No se ha encontrado al usuario.";
                    }

                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new(_userViewModel);
            mm.ShowDialog();
            this.Close();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings s = new(_userViewModel);
            s.ShowDialog();
            this.Close();
        }
        private void Btn_Enter(object sender, EventArgs e)
        {
            Program.PlaySoundEffect_ButtonOver();
        }
    }
}
