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

namespace RegistroSangre
{
    public partial class Login : Form
    {
        string connectionString = "Data Source=DESKTOP-3STQB8L\\SQLEXPRESS;Initial Catalog=SangreBD;Integrated Security=True";
        SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            CrearUsuarioSiEstaVacia();


        }
        private void CrearUsuarioSiEstaVacia()
        {
            string countQuery = "SELECT COUNT(*) FROM Usuarios";
            SqlCommand countCommand = new SqlCommand(countQuery, connection);
            int count = (int)countCommand.ExecuteScalar();

            if (count == 0)
            {
                string insertQuery = "INSERT INTO Usuarios ( Nombre, Contraseña, Admin, Deleted) VALUES ( @Nombre, @Contraseña, @Admin, @Deleted)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@Nombre", "admin");
                insertCommand.Parameters.AddWithValue("@Contraseña", "admin123");
                insertCommand.Parameters.AddWithValue("@Admin", true);
                insertCommand.Parameters.AddWithValue("@Deleted", false);

                insertCommand.ExecuteNonQuery();

             
            }
        }
        void InciarSesion()
        {

            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Realizar la validación del usuario en la base de datos
            string selectQuery = "SELECT COUNT(*), Admin FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña AND Deleted = 0 GROUP BY Admin";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            selectCommand.Parameters.AddWithValue("@Nombre", nombreUsuario);
            selectCommand.Parameters.AddWithValue("@Contraseña", contraseña);

            using (SqlDataReader reader = selectCommand.ExecuteReader())
            {

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    bool esAdmin = reader.GetBoolean(1);

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Menu menu = new Menu(nombreUsuario, esAdmin);
                        menu.Show();
                        this.Close();

                    }
                   
                }
                else
                {
                    MessageBox.Show("Credenciales inválidas o usuario eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
     




        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistroPacientes_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                MessageBox.Show("Deber Proporcionar un Nombre de Usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreUsuario.Focus();
                return;
            }
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Deber Proporcionar una Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return;
            }
            InciarSesion();
        }
    }
}
