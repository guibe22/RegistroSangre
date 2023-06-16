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

    public partial class BuscarDoctor : Form
    {
        string connectionString = "Data Source=172.20.1.4;Initial Catalog=SangreBD;User ID=lbsangre;Password=12345678;";
        SqlConnection connection;
        public BuscarDoctor()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);

            string query = "SELECT DoctorId, Nombre, Apellido, Cedula, Direccion, Correo, Telefono, Genero, FechaNacimiento, Especialidad, Consultorio FROM Doctores WHERE Deleted = 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }


            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT DoctorId, Nombre, Apellido, Cedula, Direccion, Correo, Telefono, Genero, FechaNacimiento, Especialidad, Consultorio FROM Doctores WHERE Deleted = 0";
            string filtro = "";
            string valorFiltro = txtFiltro.Text.Trim();

            if (!string.IsNullOrEmpty(valorFiltro))
            {
                
                filtro += $"( DoctorId LIKE '%{valorFiltro}%' OR " +
                          $"Nombre LIKE '%{valorFiltro}%' OR " +
                          $"Apellido LIKE '%{valorFiltro}%' OR " +
                          $"Cedula LIKE '%{valorFiltro}%' OR " +
                          $"Direccion LIKE '%{valorFiltro}%' OR " +
                          $"Correo LIKE '%{valorFiltro}%' OR " +
                          $"Telefono LIKE '%{valorFiltro}%' OR " +
                          $"Genero LIKE '%{valorFiltro}%' OR " +
                          $"FechaNacimiento LIKE '%{valorFiltro}%' OR " +
                          $"Especialidad LIKE '%{valorFiltro}%' OR " +
                          $"Consultorio LIKE '%{valorFiltro}%')";
            }
            else
            {
                return;
            }

            string consultaFiltrada = $"{query} AND {filtro}";


            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(consultaFiltrada, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                int pacienteID = Convert.ToInt32(filaSeleccionada.Cells["DoctorId"].Value);
                string? nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string? apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string? especialidad = filaSeleccionada.Cells["Especialidad"].Value.ToString();
                string? dato = $"{nombre} {apellido} ({especialidad})";

                Global gb = new Global();
                gb.Doctor = dato;


                this.Close();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
