using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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


            string selectQuery = "SELECT Paciente, Doctor, Grupo, Volumen, Estado, Ingresado, Fecha FROM GrupoSangre WHERE GrupoSangreId = @GrupoSangreId";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@GrupoSangreId", GrupoSangreId);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string? Doctor = reader["Doctor"].ToString();
                string? Paciente = reader["Paciente"].ToString();
                GetPaciente(Paciente);
                GetDoctor(Doctor);
                TxtGrupo.Text = reader["Grupo"].ToString();
                TxtVolumen.Text= reader["Volumen"].ToString();
                TxtEstado.Text = reader["Estado"].ToString();
                TxtFecha.Text = reader["Fecha"].ToString();
                TxtIngresado.Text= reader["Ingresado"].ToString();

            }
            reader.Close();

        }



        void CargarDatos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string selectQuery = "SELECT PacienteId, Nombre, Apellido, Cedula FROM Pacientes WHERE Deleted=0";
                SqlCommand command = new SqlCommand(selectQuery, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string? nombre = reader["Nombre"].ToString();
                    string? apellido = reader["Apellido"].ToString();
                    string? cedula = reader["Cedula"].ToString();
                    string? nombreCompleto = $"{nombre} {apellido} ({cedula})";
                    int Id = Convert.ToInt32(reader["PacienteId"]);
                    KeyValuePair<int, string> item = new KeyValuePair<int, string>(Id, nombreCompleto);

                    TxtPaciente.Items.Add(item);
                }
                TxtPaciente.ValueMember = "Key";
                TxtPaciente.DisplayMember = "Value";
                reader.Close();

                selectQuery = "SELECT DoctorId, Nombre, Apellido, Especialidad FROM Doctores WHERE Deleted=0";
                 command = new SqlCommand(selectQuery, connection);
                 reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string? nombre = reader["Nombre"].ToString();
                    string? apellido = reader["Apellido"].ToString();
                    string? especialidad = reader["Especialidad"].ToString();
                    string nombreCompleto = $"{nombre} {apellido} ({especialidad})";
                    int Id = Convert.ToInt32(reader["DoctorId"]);

                    KeyValuePair<int, string> item = new KeyValuePair<int, string>(Id, nombreCompleto);

                    TxtDoctor.Items.Add(item);
                }
                TxtDoctor.ValueMember = "Key";
                TxtDoctor.DisplayMember = "Value";
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
            if (TxtIngresado.Text == "")
            {
                MessageBox.Show("Debe insertar Ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtIngresado.Focus();
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
            BtnEliminar.Enabled = false;


        }
        bool Guardar()
        {
            KeyValuePair<int, string> selectedDoctor = (KeyValuePair<int, string>)TxtDoctor.SelectedItem;
            KeyValuePair<int, string> selectedPaciente = (KeyValuePair<int, string>)TxtPaciente.SelectedItem;


            try
            {
                string insertQuery = "INSERT INTO GrupoSangre (Paciente,PacienteId, Doctor,DoctorId, Grupo, Volumen, Estado, Ingresado, Fecha)   VALUES (@Paciente, @PacienteId, @Doctor, @DoctorId, @Grupo, @Volumen, @Estado,@Ingresado, @Fecha)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Paciente", selectedPaciente.Value);
                command.Parameters.AddWithValue("@PacienteId", selectedPaciente.Key);
                command.Parameters.AddWithValue("@Doctor", selectedDoctor.Value);
                command.Parameters.AddWithValue("@DoctorId", selectedDoctor.Key);
                command.Parameters.AddWithValue("@Grupo", TxtGrupo.Text);
                command.Parameters.AddWithValue("@Volumen", TxtVolumen.Text);
                command.Parameters.AddWithValue("@Estado", TxtEstado.Text);
                command.Parameters.AddWithValue("@Ingresado", TxtIngresado.Text);
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
                string updateQuery = "UPDATE GrupoSangre SET Paciente = @Paciente,PacienteId=@PacienteId Doctor = @Doctor,DoctorId=DoctorId, Grupo = @Grupo, Volumen = @Volumen, Estado = @Estado,Ingresado=@Ingresado, Fecha = @Fecha WHERE GrupoSangreId = @GrupoSangreId";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@GrupoSangreId", GrupoSangreId);
                command.Parameters.AddWithValue("@Paciente", TxtPaciente.Text);
                command.Parameters.AddWithValue("@Doctor", TxtDoctor.Text);
                command.Parameters.AddWithValue("@Grupo", TxtGrupo.Text);
                command.Parameters.AddWithValue("@Volumen", TxtVolumen.Text);
                command.Parameters.AddWithValue("@Estado", TxtEstado.Text);
                command.Parameters.AddWithValue("@Ingresado", TxtIngresado.Text);
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




        public void GetPaciente(string nombre)
        {

            if(TxtPaciente.Items.Count > 0)
            {
                for (int i = 0; i < TxtPaciente.Items.Count; i++)
                {
                    TxtPaciente.SelectedIndex = i;
                    string valor = TxtPaciente.Text;
          
        
                    if (valor == nombre)
                    {
                        TxtPaciente.SelectedIndex = i;
                        break;
                    }

                }
            }
        }

        public void GetDoctor(string nombre)
        {

            if (TxtDoctor.Items.Count > 0)
            {
                for (int i = 0; i < TxtDoctor.Items.Count; i++)
                {
                    TxtDoctor.SelectedIndex = i;
                    string valor = TxtDoctor.Text;
                    

                    if (valor == nombre)
                    {
                        TxtDoctor.SelectedIndex = i;
                        break;
                    }

                }
            }
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

        private void TxtPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtPaciente_TextChanged(object sender, EventArgs e)
        {
            string filtro = TxtPaciente.Text.ToLower();
            List<string> elementosFiltrados = new List<string>();

            // Filtrar los elementos según el texto ingresado
            foreach (string item in TxtPaciente.Items)
            {
                if (item.ToLower().Contains(filtro))
                {
                    elementosFiltrados.Add(item);
                }
            }

            // Actualizar los elementos en el ComboBox
            TxtPaciente.Items.Clear();
            TxtPaciente.Items.AddRange(elementosFiltrados.ToArray());
        }


        private void R_GrupoSangre_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarPaciente buscarCliente = new BuscarPaciente();
            buscarCliente.ShowDialog();
            
            Global gb = new Global();
           
            GetPaciente(gb.Paciente);

        }

        private void BtnBuscarDoctor_Click(object sender, EventArgs e)
        {
            BuscarDoctor buscarDoctor = new BuscarDoctor();
            buscarDoctor.ShowDialog();

            Global gb = new Global();

            GetDoctor(gb.Doctor);
        }
    }
}
