using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroSangre
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; 
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        

        private void LbUsuario_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistroPacientes_Click(object sender, EventArgs e)
        {
            R_Pacientes r_Pacientes = new R_Pacientes();
            r_Pacientes.Show();

        }

        private void BtnRegistroDoctores_Click(object sender, EventArgs e)
        {
            R_Doctores r_Doctores = new R_Doctores();
            r_Doctores.Show();
        }
    }
}
