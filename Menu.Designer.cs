namespace RegistroSangre
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegistroPacientes = new System.Windows.Forms.Button();
            this.BtnConsultaPacientes = new System.Windows.Forms.Button();
            this.BtnConsultaDoctores = new System.Windows.Forms.Button();
            this.BtnRegistroDoctores = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnConsultaUsuario = new System.Windows.Forms.Button();
            this.BtnRegistroUsuario = new System.Windows.Forms.Button();
            this.BtnConsultaSangre = new System.Windows.Forms.Button();
            this.BtnRegistroGrupoSangre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.LbUsuario);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 76);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(641, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "CERRAR      PROGRAMA";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbUsuario.Location = new System.Drawing.Point(219, 8);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(218, 50);
            this.LbUsuario.TabIndex = 1;
            this.LbUsuario.Text = "Bienvenido";
            this.LbUsuario.Click += new System.EventHandler(this.LbUsuario_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(475, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "CERRAR SESION";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // BtnRegistroPacientes
            // 
            this.BtnRegistroPacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRegistroPacientes.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegistroPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroPacientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistroPacientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistroPacientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroPacientes.Image")));
            this.BtnRegistroPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroPacientes.Location = new System.Drawing.Point(3, 20);
            this.BtnRegistroPacientes.Name = "BtnRegistroPacientes";
            this.BtnRegistroPacientes.Size = new System.Drawing.Size(225, 60);
            this.BtnRegistroPacientes.TabIndex = 1;
            this.BtnRegistroPacientes.Text = "REGISTRO DE PANCIENTES";
            this.BtnRegistroPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistroPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistroPacientes.UseVisualStyleBackColor = false;
            this.BtnRegistroPacientes.Click += new System.EventHandler(this.BtnRegistroPacientes_Click);
            // 
            // BtnConsultaPacientes
            // 
            this.BtnConsultaPacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConsultaPacientes.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnConsultaPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaPacientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultaPacientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaPacientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaPacientes.Image")));
            this.BtnConsultaPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaPacientes.Location = new System.Drawing.Point(3, 97);
            this.BtnConsultaPacientes.Name = "BtnConsultaPacientes";
            this.BtnConsultaPacientes.Size = new System.Drawing.Size(225, 60);
            this.BtnConsultaPacientes.TabIndex = 2;
            this.BtnConsultaPacientes.Text = "CONSULTA DE PANCIENTES";
            this.BtnConsultaPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultaPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultaPacientes.UseVisualStyleBackColor = false;
            this.BtnConsultaPacientes.Click += new System.EventHandler(this.BtnConsultaPacientes_Click);
            // 
            // BtnConsultaDoctores
            // 
            this.BtnConsultaDoctores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConsultaDoctores.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnConsultaDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaDoctores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultaDoctores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaDoctores.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaDoctores.Image")));
            this.BtnConsultaDoctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaDoctores.Location = new System.Drawing.Point(3, 254);
            this.BtnConsultaDoctores.Name = "BtnConsultaDoctores";
            this.BtnConsultaDoctores.Size = new System.Drawing.Size(225, 60);
            this.BtnConsultaDoctores.TabIndex = 4;
            this.BtnConsultaDoctores.Text = "CONSULTA DE DOCTORES";
            this.BtnConsultaDoctores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultaDoctores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultaDoctores.UseVisualStyleBackColor = false;
            this.BtnConsultaDoctores.Click += new System.EventHandler(this.BtnConsultaDoctores_Click);
            // 
            // BtnRegistroDoctores
            // 
            this.BtnRegistroDoctores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRegistroDoctores.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegistroDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroDoctores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistroDoctores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistroDoctores.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroDoctores.Image")));
            this.BtnRegistroDoctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroDoctores.Location = new System.Drawing.Point(3, 175);
            this.BtnRegistroDoctores.Name = "BtnRegistroDoctores";
            this.BtnRegistroDoctores.Size = new System.Drawing.Size(225, 60);
            this.BtnRegistroDoctores.TabIndex = 3;
            this.BtnRegistroDoctores.Text = "REGISTRO DE DOCTORES";
            this.BtnRegistroDoctores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistroDoctores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistroDoctores.UseVisualStyleBackColor = false;
            this.BtnRegistroDoctores.Click += new System.EventHandler(this.BtnRegistroDoctores_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.BtnConsultaUsuario);
            this.panel2.Controls.Add(this.BtnRegistroUsuario);
            this.panel2.Controls.Add(this.BtnConsultaSangre);
            this.panel2.Controls.Add(this.BtnRegistroGrupoSangre);
            this.panel2.Controls.Add(this.BtnRegistroPacientes);
            this.panel2.Controls.Add(this.BtnConsultaDoctores);
            this.panel2.Controls.Add(this.BtnConsultaPacientes);
            this.panel2.Controls.Add(this.BtnRegistroDoctores);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 668);
            this.panel2.TabIndex = 5;
            // 
            // BtnConsultaUsuario
            // 
            this.BtnConsultaUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConsultaUsuario.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnConsultaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultaUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaUsuario.Image")));
            this.BtnConsultaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaUsuario.Location = new System.Drawing.Point(3, 568);
            this.BtnConsultaUsuario.Name = "BtnConsultaUsuario";
            this.BtnConsultaUsuario.Size = new System.Drawing.Size(225, 60);
            this.BtnConsultaUsuario.TabIndex = 8;
            this.BtnConsultaUsuario.Text = "CONSULTA USUARIOS";
            this.BtnConsultaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultaUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultaUsuario.UseVisualStyleBackColor = false;
            this.BtnConsultaUsuario.Click += new System.EventHandler(this.BtnConsultaUsuario_Click);
            // 
            // BtnRegistroUsuario
            // 
            this.BtnRegistroUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRegistroUsuario.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistroUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistroUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroUsuario.Image")));
            this.BtnRegistroUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroUsuario.Location = new System.Drawing.Point(3, 487);
            this.BtnRegistroUsuario.Name = "BtnRegistroUsuario";
            this.BtnRegistroUsuario.Size = new System.Drawing.Size(225, 60);
            this.BtnRegistroUsuario.TabIndex = 7;
            this.BtnRegistroUsuario.Text = "REGISTRO USUARIOS";
            this.BtnRegistroUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistroUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistroUsuario.UseVisualStyleBackColor = false;
            this.BtnRegistroUsuario.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnConsultaSangre
            // 
            this.BtnConsultaSangre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConsultaSangre.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnConsultaSangre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaSangre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultaSangre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultaSangre.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaSangre.Image")));
            this.BtnConsultaSangre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaSangre.Location = new System.Drawing.Point(3, 410);
            this.BtnConsultaSangre.Name = "BtnConsultaSangre";
            this.BtnConsultaSangre.Size = new System.Drawing.Size(225, 60);
            this.BtnConsultaSangre.TabIndex = 6;
            this.BtnConsultaSangre.Text = "CONSULTA DE GRUP. SANG.";
            this.BtnConsultaSangre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultaSangre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultaSangre.UseVisualStyleBackColor = false;
            this.BtnConsultaSangre.Click += new System.EventHandler(this.BtnConsultaSangre_Click);
            // 
            // BtnRegistroGrupoSangre
            // 
            this.BtnRegistroGrupoSangre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRegistroGrupoSangre.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegistroGrupoSangre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroGrupoSangre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistroGrupoSangre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistroGrupoSangre.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroGrupoSangre.Image")));
            this.BtnRegistroGrupoSangre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroGrupoSangre.Location = new System.Drawing.Point(3, 334);
            this.BtnRegistroGrupoSangre.Name = "BtnRegistroGrupoSangre";
            this.BtnRegistroGrupoSangre.Size = new System.Drawing.Size(225, 60);
            this.BtnRegistroGrupoSangre.TabIndex = 5;
            this.BtnRegistroGrupoSangre.Text = "REGISTRO DE GRUP. SANG.";
            this.BtnRegistroGrupoSangre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistroGrupoSangre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistroGrupoSangre.UseVisualStyleBackColor = false;
            this.BtnRegistroGrupoSangre.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 746);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label LbUsuario;
        private Button BtnRegistroPacientes;
        private Button BtnConsultaPacientes;
        private Button BtnConsultaDoctores;
        private Button BtnRegistroDoctores;
        private Panel panel2;
        private Button BtnRegistroGrupoSangre;
        private Button BtnConsultaSangre;
        private Button BtnConsultaUsuario;
        private Button BtnRegistroUsuario;
        private Button button1;
        private Button button2;
    }
}