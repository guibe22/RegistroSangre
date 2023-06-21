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

    public partial class C_Pacientes : Form
    {
        string connectionString = "Data Source=172.20.1.4;Initial Catalog=SangreBD;User ID=lbsangre;Password=12345678;";
        SqlConnection connection;

        public C_Pacientes()
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
                    dataGridView1.AllowUserToAddRows = false;

                }


            }
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Obtener la fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string? idString = row.Cells["PacienteID"].Value.ToString();
                int id = int.Parse(idString);
                R_Pacientes r_Pacientes = new R_Pacientes(id); 
                r_Pacientes.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de hacer clic en Modificar");
            }
        }

        private void C_Pacientes_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT PacienteID, Nombre, Apellido, Cedula, Direccion, Correo, Telefono, Genero, FechaNacimiento FROM Pacientes WHERE Deleted = 0";
            string filtro = "";
            string valorFiltro = txtFiltro.Text.Trim();
            string consultaFiltrada = "";

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
               consultaFiltrada = $"{query} AND {filtro}";
            }
            else
            {
               consultaFiltrada = $"{query}";
            }

           


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(consultaFiltrada, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AllowUserToAddRows = false;
                }
            }

        }
    }
}
