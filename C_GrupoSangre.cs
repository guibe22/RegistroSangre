﻿using System;
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

namespace RegistroSangre
{
    public partial class C_GrupoSangre : Form
    {
        string connectionString = "Data Source=DESKTOP-3STQB8L\\SQLEXPRESS;Initial Catalog=SangreBD;Integrated Security=True";
        SqlConnection connection;
        public C_GrupoSangre()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT GrupoSangreId , Paciente, Doctor, Grupo, Volumen, Estado , Fecha FROM GrupoSangre WHERE Deleted = 0";

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

        private void C_GrupoSangre_Load(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string idString = row.Cells["GrupoSangreId"].Value.ToString();
                int id = int.Parse(idString);
                R_GrupoSangre r_GrupoSangre = new R_GrupoSangre(id);
                r_GrupoSangre.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de hacer clic en Modificar");
            }
        }
    }
}
