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
            this.LbUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegistroPacientes = new System.Windows.Forms.Button();
            this.BtnConsultaPacientes = new System.Windows.Forms.Button();
            this.BtnConsultaDoctores = new System.Windows.Forms.Button();
            this.BtnRegistroDoctores = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.LbUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 76);
            this.panel1.TabIndex = 0;
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbUsuario.Location = new System.Drawing.Point(382, 8);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(218, 50);
            this.LbUsuario.TabIndex = 1;
            this.LbUsuario.Text = "Bienvenido";
            this.LbUsuario.Click += new System.EventHandler(this.LbUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 8);
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
            // 
            // BtnConsultaDoctores
            // 
            this.BtnConsultaDoctores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConsultaDoctores.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnConsultaDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaDoctores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // 
            // BtnRegistroDoctores
            // 
            this.BtnRegistroDoctores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRegistroDoctores.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegistroDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroDoctores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.panel2.Controls.Add(this.BtnRegistroPacientes);
            this.panel2.Controls.Add(this.BtnConsultaDoctores);
            this.panel2.Controls.Add(this.BtnConsultaPacientes);
            this.panel2.Controls.Add(this.BtnRegistroDoctores);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 372);
            this.panel2.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
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
    }
}