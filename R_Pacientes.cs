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
    public partial class R_Pacientes : Form
    {
        string connectionString = "Data Source=172.20.1.4;Initial Catalog=SangreBD;User ID=lbsangre;Password=12345678;";
        SqlConnection connection;
        int PacienteId = 0;
        public R_Pacientes()
        {

            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();


        }
        public R_Pacientes(int id)
        {

            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            PacienteId = id;
            BtnEliminar.Enabled = true;

            string selectQuery = "SELECT Nombre, Apellido, Cedula, Direccion, Telefono, Correo, Genero, FechaNacimiento FROM Pacientes WHERE PacienteID = @PacienteID";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@PacienteID", PacienteId);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Asignar los valores a los TextBox correspondientes
                TxtNombre.Text = reader["Nombre"].ToString();
                TxtApellido.Text = reader["Apellido"].ToString();
                TxtCedula.Text = reader["Cedula"].ToString();
                TxtDireccion.Text = reader["Direccion"].ToString();
                TxtTelefono.Text = reader["Telefono"].ToString();
                TxtCorreo.Text = reader["Correo"].ToString();
                TxtGenero.Text = reader["Genero"].ToString();
                TxtNacimiento.Text = reader["FechaNacimiento"].ToString();
            }
            reader.Close();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        bool Guardar()
        {
           
            try
            {
                string insertQuery = "INSERT INTO Pacientes (Nombre, Apellido, Cedula, Direccion, Telefono, Correo, Genero, FechaNacimiento) VALUES (@Nombre, @Apellido, @Cedula, @Direccion, @Telefono, @Correo, @Genero, @FechaNacimiento)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", TxtApellido.Text);
                command.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                command.Parameters.AddWithValue("@Cedula", TxtCedula.Text);
                command.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                command.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                command.Parameters.AddWithValue("@Genero", TxtGenero.Text);
                command.Parameters.AddWithValue("@FechaNacimiento", TxtNacimiento.Text);

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
                string updateQuery = "UPDATE Pacientes SET Nombre = @Nombre, Apellido = @Apellido, Cedula = @Cedula, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo, Genero = @Genero, FechaNacimiento = @FechaNacimiento WHERE PacienteId = @PacienteId ";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", TxtApellido.Text);
                command.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                command.Parameters.AddWithValue("@Cedula", TxtCedula.Text);
                command.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                command.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                command.Parameters.AddWithValue("@Genero", TxtGenero.Text);
                command.Parameters.AddWithValue("@FechaNacimiento", TxtNacimiento.Text);
                command.Parameters.AddWithValue("@PacienteId", PacienteId);
                command.ExecuteNonQuery();

                string nombrecompleto = $"{TxtNombre.Text} {TxtApellido.Text} ({TxtCedula.Text})";
                updateQuery = "UPDATE GrupoSangre SET Paciente = @Paciente WHERE PacienteId = @PacienteId ";
                command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Paciente", nombrecompleto);
                command.Parameters.AddWithValue("@PacienteId", PacienteId);
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
            TxtApellido.Clear();
            TxtDireccion.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            TxtGenero.Text = "";
            PacienteId = 0;
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
            if (TxtApellido.Text == "")
            {
                MessageBox.Show("Debe insertar el Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtApellido.Focus();
                return false;


            }
            if (TxtCedula.Text == "")
            {
                MessageBox.Show("Debe insertar La Cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCedula.Focus();
                return false;


            }
            if (TxtDireccion.Text == "")
            {
                MessageBox.Show("Debe insertar La Direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCedula.Focus();
                return false;

            }
            if (TxtCorreo.Text == "")
            {
                MessageBox.Show("Debe insertar el Correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCorreo.Focus();
                return false;

            }
            if (TxtTelefono.Text == "")
            {
                MessageBox.Show("Debe insertar el Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTelefono.Focus();
                return false;

            }
            if (TxtGenero.Text == "")
            {
                MessageBox.Show("Debe insertar el Genero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtGenero.Focus();
                return false;

            }
            return true;


        }
        private void Eliminar()
        {
            try
            {
                string updateQuery = "UPDATE Pacientes SET Deleted = 1 WHERE PacienteId = @PacienteId";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@PacienteID", PacienteId);

                command.ExecuteNonQuery();

                MessageBox.Show("Eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (!Validar())
            {
                return;
            }
            if (PacienteId > 0)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void R_Pacientes_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Limpiar();
            BtnEliminar.Enabled = false;

        }
    }
}
