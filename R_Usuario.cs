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
    public partial class R_Usuario : Form
    {
        string connectionString = "Data Source=172.20.1.4;Initial Catalog=SangreBD;User ID=lbsangre;Password=12345678;";
        SqlConnection connection;
        int UsuarioId = 0;
        public R_Usuario()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public R_Usuario(int id)
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            UsuarioId=id;

            BtnEliminar.Enabled = true;

            string selectQuery = "SELECT  Nombre, Contraseña FROM Usuarios WHERE UsuarioId = @UsuarioId";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("UsuarioId", UsuarioId);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Asignar los valores a los TextBox correspondientes
                TxtNombre.Text = reader["Nombre"].ToString();
               TxtContra.Text = reader["Contraseña"].ToString();
            }
            reader.Close();

        }

        bool Guardar()
        {

            try
            {
                string insertQuery = "INSERT INTO Usuarios ( Nombre, Contraseña) VALUES ( @Nombre, @Contraseña)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                command.Parameters.AddWithValue("@Contraseña", TxtContra.Text);


                command.ExecuteNonQuery();

                // Si no se produce una excepción, se muestra un mensaje de guardado exitoso
                MessageBox.Show("Guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        bool Modificar()
        {
            try
            {
                string updateQuery = "UPDATE Usuarios SET Nombre = @Nombre,Contraseña= @Contraseña  WHERE UsuarioId = @UsuarioId  ";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                command.Parameters.AddWithValue("@Contraseña", TxtContra.Text);
                command.Parameters.AddWithValue("@UsuarioId", UsuarioId);



                command.ExecuteNonQuery();

                MessageBox.Show("Modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        void Limpiar()
        {
            TxtNombre.Clear();
            TxtContra.Clear();
            UsuarioId = 0;
            BtnEliminar.Enabled = false;

        }
        bool Validar()
        {
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("Debe insertar el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombre.Focus();
                return false;

            }
            if (TxtContra.Text == "")
            {
                MessageBox.Show("Debe insertar La Contraseña ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtContra.Focus();
                return false;

            }
            return true;


        }
        private void Eliminar()
        {
            try
            {
                string updateQuery = "UPDATE Usuarios SET Deleted = 1 WHERE UsuarioId = @UsuarioId";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@UsuarioId", UsuarioId);

                command.ExecuteNonQuery();

                MessageBox.Show("Eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void R_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            if (UsuarioId > 0)
            {
                if (Modificar())
                {
                    Limpiar();
                    BtnEliminar.Enabled = false;
                }
                
            }
            else
            {
                if (Guardar())
                {
                    Limpiar();
                }
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Limpiar();
            BtnEliminar.Enabled = false;

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
