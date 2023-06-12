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
    public partial class C_Doctores : Form
    {
        string connectionString = "Data Source=DESKTOP-3STQB8L\\SQLEXPRESS;Initial Catalog=SangreBD;Integrated Security=True";
        SqlConnection connection;
        public C_Doctores()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string idString = row.Cells["DoctorId"].Value.ToString();
                int id = int.Parse(idString);
                R_Doctores r_Doctores = new R_Doctores(id);
                r_Doctores.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de hacer clic en Modificar");
            }
        }
    }
}
