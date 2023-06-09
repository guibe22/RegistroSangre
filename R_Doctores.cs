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
    public partial class R_Doctores : Form
    {
        public R_Doctores()
        {
            InitializeComponent();
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
            if (TxtEspecialidad.Text == "")
            {

                MessageBox.Show("Debe insertar La especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEspecialidad.Focus();
                return false;

            }
            if (TxtConsultorio.Text == "")
            {

                MessageBox.Show("Debe insertar El Consultorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtConsultorio.Focus();
                return false;

            }
            return true;


        }
        void Limpiar()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDireccion.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            TxtConsultorio.Clear();
            TxtEspecialidad.Clear();
        }

       bool Guardar()
        {
            string connectionString = "Data Source=DESKTOP-3STQB8L\\SQLEXPRESS;Initial Catalog=SangreBD;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                string insertQuery = "INSERT INTO Doctores (Nombre, Apellido, Cedula, Direccion, Telefono, Correo, Genero, FechaNacimiento, Especialidad, Consultorio) VALUES (@Nombre, @Apellido, @Cedula, @Direccion, @Telefono, @Correo, @Genero, @FechaNacimiento, @Especialidad, @Consultorio)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", TxtApellido.Text);
                command.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                command.Parameters.AddWithValue("@Cedula", TxtCedula.Text);
                command.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                command.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                command.Parameters.AddWithValue("@Genero", TxtGenero.Text);
                command.Parameters.AddWithValue("@FechaNacimiento", TxtNacimiento.Text);
                command.Parameters.AddWithValue("@Especialidad", TxtEspecialidad.Text);
                command.Parameters.AddWithValue("@Consultorio", TxtConsultorio.Text);

                command.ExecuteNonQuery();

             
                MessageBox.Show("Guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            if (Guardar())
            {
                Limpiar();
            }
       
           
        }
    }
}
