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
    public partial class R_GrupoSangre : Form
    {
        string connectionString = "Data Source=DESKTOP-3STQB8L\\SQLEXPRESS;Initial Catalog=SangreBD;Integrated Security=True";
        SqlConnection connection;
        int GrupoSangreId = 0;
        public R_GrupoSangre()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            CargarDatos();
        }
        public R_GrupoSangre(int Id)
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            CargarDatos();
            GrupoSangreId = Id;
            BtnEliminar.Enabled = true;


            string selectQuery = "SELECT Paciente, Doctor, Grupo, Volumen, Estado, Fecha FROM GrupoSangre WHERE GrupoSangreId = @GrupoSangreId";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@GrupoSangreId", GrupoSangreId);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Asignar los valores a los TextBox correspondientes
                TxtPaciente.Text = reader["Paciente"].ToString();
                TxtDoctor.Text = reader["Doctor"].ToString();
                TxtGrupo.Text = reader["Grupo"].ToString();
                TxtVolumen.Text= reader["Volumen"].ToString();
                TxtEstado.Text = reader["Estado"].ToString();
                TxtFecha.Text = reader["Fecha"].ToString();

            }
            reader.Close();

        }



        void CargarDatos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string selectQuery = "SELECT Nombre, Apellido, Cedula FROM Pacientes WHERE Deleted=0";
                SqlCommand command = new SqlCommand(selectQuery, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellido"].ToString();
                    string cedula = reader["Cedula"].ToString();
                    string nombreCompleto = $"{nombre} {apellido} ({cedula})";

                    TxtPaciente.Items.Add(nombreCompleto);
                }
                reader.Close();

                selectQuery = "SELECT Nombre, Apellido, Especialidad FROM Doctores WHERE Deleted=0";
                 command = new SqlCommand(selectQuery, connection);
                 reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellido"].ToString();
                    string especialidad = reader["Especialidad"].ToString();
                    string nombreCompleto = $"{nombre} {apellido} ({especialidad})";

                    TxtDoctor.Items.Add(nombreCompleto);
                }
                reader.Close();
            }
        }
        bool Validar()
        {
            if (TxtPaciente.Text == "")
            {
                MessageBox.Show("Debe insertar el Paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPaciente.Focus();
                return false;
            }

            if (TxtDoctor.Text == "")
            {
                MessageBox.Show("Debe insertar el Doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDoctor.Focus();
                return false;
            }

            if (TxtGrupo.Text == "")
            {
                MessageBox.Show("Debe insertar el Grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtGrupo.Focus();
                return false;
            }
            if (TxtVolumen.Text == "")
            {
                MessageBox.Show("Debe insertar el Volumen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtVolumen.Focus();
                return false;
            }
            if (TxtEstado.Text == "")
            {
                MessageBox.Show("Debe insertar el Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEstado.Focus();
                return false;
            }
            return true;
        }
        void Limpiar()
        {
            TxtPaciente.Text = "";
            TxtDoctor.Text = "";
            TxtGrupo.Text = "";
            TxtVolumen.Clear();
            TxtEstado.Text = "";
            GrupoSangreId = 0;


        }
        bool Guardar()
        {


            try
            {
                string insertQuery = "INSERT INTO GrupoSangre (Paciente, Doctor, Grupo, Volumen, Estado, Fecha)   VALUES (@Paciente, @Doctor, @Grupo, @Volumen, @Estado, @Fecha)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Paciente", TxtPaciente.Text);
                command.Parameters.AddWithValue("@Doctor", TxtDoctor.Text);
                command.Parameters.AddWithValue("@Grupo", TxtGrupo.Text);
                command.Parameters.AddWithValue("@Volumen", TxtVolumen.Text);
                command.Parameters.AddWithValue("@Estado", TxtEstado.Text);
                command.Parameters.AddWithValue("@Fecha", TxtFecha.Text);


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
        bool Modificar()
        {
            try
            {
                string updateQuery = "UPDATE GrupoSangre SET Paciente = @Paciente, Doctor = @Doctor, Grupo = @Grupo, Volumen = @Volumen, Estado = @Estado, Fecha = @Fecha WHERE GrupoSangreId = @GrupoSangreId";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@GrupoSangreId", GrupoSangreId);
                command.Parameters.AddWithValue("@Paciente", TxtPaciente.Text);
                command.Parameters.AddWithValue("@Doctor", TxtDoctor.Text);
                command.Parameters.AddWithValue("@Grupo", TxtGrupo.Text);
                command.Parameters.AddWithValue("@Volumen", TxtVolumen.Text);
                command.Parameters.AddWithValue("@Estado", TxtEstado.Text);
                command.Parameters.AddWithValue("@Fecha", TxtFecha.Text);

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
        private void Eliminar()
        {
            try
            {
                string updateQuery = "UPDATE GrupoSangre SET Deleted = 1 WHERE GrupoSangreId = @GrupoSangreId";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@GrupoSangreId", GrupoSangreId);

                command.ExecuteNonQuery();

                MessageBox.Show("Eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void R_GupoSangre_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            if (GrupoSangreId > 0)
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
