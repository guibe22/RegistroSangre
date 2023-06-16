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


    public partial class C_Usuarios : Form
    {
        string connectionString = "Data Source=172.20.1.4;Initial Catalog=SangreBD;User ID=lbsangre;Password=12345678;";
        SqlConnection connection;
        public C_Usuarios()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT UsuarioId , Nombre , Contraseña FROM Usuarios WHERE Deleted = 0";

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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string idString = row.Cells["UsuarioId"].Value.ToString();
                int id = int.Parse(idString);
                R_Usuario r_Usuario = new R_Usuario(id);
                r_Usuario.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de hacer clic en Modificar");
            }
        }
    }
}
