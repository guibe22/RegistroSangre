using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RegistroSangre
{
    public partial class BuscarPaciente : Form
    {
        string connectionString = "Data Source=172.20.1.4;Initial Catalog=SangreBD;User ID=lbsangre;Password=12345678;";
        SqlConnection connection;
        public BuscarPaciente()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT PacienteID, Nombre, Apellido, Cedula, Direccion, Correo, Telefono, Genero, FechaNacimiento FROM Pacientes WHERE Deleted = 0";

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
            string query = "SELECT PacienteID, Nombre, Apellido, Cedula, Direccion, Correo, Telefono, Genero, FechaNacimiento FROM Pacientes WHERE Deleted = 0";
            string filtro = "";
            string valorFiltro = txtFiltro.Text.Trim();
            
            if (!string.IsNullOrEmpty(valorFiltro))
            {
                // Agregar el criterio de filtrado para cada campo que deseas incluir en la búsqueda
                filtro += $"(PacienteID LIKE '%{valorFiltro}%' OR " +
                          $"Nombre LIKE '%{valorFiltro}%' OR " +
                          $"Apellido LIKE '%{valorFiltro}%' OR " +
                          $"Cedula LIKE '%{valorFiltro}%' OR " +
                          $"Direccion LIKE '%{valorFiltro}%' OR " +
                          $"Correo LIKE '%{valorFiltro}%' OR " +
                          $"Telefono LIKE '%{valorFiltro}%' OR " +
                          $"Genero LIKE '%{valorFiltro}%' OR " +
                          $"FechaNacimiento LIKE '%{valorFiltro}%')";
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
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                int pacienteID = Convert.ToInt32(filaSeleccionada.Cells["PacienteID"].Value);
                string? nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string? apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string? cedula = filaSeleccionada.Cells["Cedula"].Value.ToString();
                string? dato = $"{nombre} {apellido} ({cedula})";

                Global gb = new Global();
                gb.Paciente = dato;
              
                this.Close();
            }

            
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
