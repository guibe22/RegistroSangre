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
        string connectionString = "Data Source=DESKTOP-3STQB8L\\SQLEXPRESS;Initial Catalog=SangreBD;Integrated Security=True";
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
    }
}
