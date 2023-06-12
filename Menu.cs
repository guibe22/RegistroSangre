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
        public Menu(String usuario, bool admin)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; 
            this.Bounds = Screen.PrimaryScreen.Bounds;
            LbUsuario.Text= usuario;
            if(admin== false)
            {
                BtnConsultaUsuario.Visible = false; 
                BtnRegistroUsuario.Visible = false;
            }
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

        private void BtnConsultaPacientes_Click(object sender, EventArgs e)
        {
            C_Pacientes c_Pacientes = new C_Pacientes();
            c_Pacientes.Show();
        }

        private void BtnConsultaDoctores_Click(object sender, EventArgs e)
        {
            C_Doctores c_Doctores = new C_Doctores();
            c_Doctores.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           R_GrupoSangre r_GrupoSangre = new R_GrupoSangre();
            r_GrupoSangre.Show();

        }

        private void BtnConsultaSangre_Click(object sender, EventArgs e)
        {
            C_GrupoSangre c_GrupoSangre = new C_GrupoSangre();
            c_GrupoSangre.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            R_Usuario r_Usuario = new R_Usuario();
            r_Usuario.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultaUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
