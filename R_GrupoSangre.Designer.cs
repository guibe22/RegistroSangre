namespace RegistroSangre
{
    partial class R_GrupoSangre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPaciente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDoctor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtVolumen = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtGrupo = new System.Windows.Forms.ComboBox();
            this.TxtEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 67);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO GRUPO SANGUINEO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtPaciente
            // 
            this.TxtPaciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPaciente.FormattingEnabled = true;
            this.TxtPaciente.Location = new System.Drawing.Point(83, 123);
            this.TxtPaciente.Name = "TxtPaciente";
            this.TxtPaciente.Size = new System.Drawing.Size(247, 29);
            this.TxtPaciente.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(83, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Paciente:";
            // 
            // TxtDoctor
            // 
            this.TxtDoctor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDoctor.FormattingEnabled = true;
            this.TxtDoctor.Location = new System.Drawing.Point(394, 123);
            this.TxtDoctor.Name = "TxtDoctor";
            this.TxtDoctor.Size = new System.Drawing.Size(247, 29);
            this.TxtDoctor.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(394, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Grupo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(394, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Volumen:";
            // 
            // TxtVolumen
            // 
            this.TxtVolumen.CausesValidation = false;
            this.TxtVolumen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVolumen.Location = new System.Drawing.Point(394, 215);
            this.TxtVolumen.Name = "TxtVolumen";
            this.TxtVolumen.Size = new System.Drawing.Size(247, 29);
            this.TxtVolumen.TabIndex = 44;
            // 
            // TxtFecha
            // 
            this.TxtFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFecha.CustomFormat = "yyyy-MM-dd";
            this.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtFecha.Location = new System.Drawing.Point(394, 313);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(247, 23);
            this.TxtFecha.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(394, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fecha :";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 67);
            this.panel2.TabIndex = 48;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Location = new System.Drawing.Point(461, 15);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(113, 32);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(168, 15);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(113, 32);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(322, 15);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(113, 32);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtGrupo
            // 
            this.TxtGrupo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGrupo.FormattingEnabled = true;
            this.TxtGrupo.Items.AddRange(new object[] {
            "Grupo A positivo (A+)",
            "Grupo A negativo (A-)",
            "Grupo B positivo (B+)",
            "Grupo B negativo (B-)",
            "Grupo AB positivo (AB+)",
            "Grupo AB negativo (AB-)",
            "Grupo O positivo (O+)",
            "Grupo O negativo (O-)"});
            this.TxtGrupo.Location = new System.Drawing.Point(83, 215);
            this.TxtGrupo.Name = "TxtGrupo";
            this.TxtGrupo.Size = new System.Drawing.Size(247, 29);
            this.TxtGrupo.TabIndex = 49;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEstado.FormattingEnabled = true;
            this.TxtEstado.Items.AddRange(new object[] {
            "DONADO",
            "ENTREGADO",
            "RECIBIDO"});
            this.TxtEstado.Location = new System.Drawing.Point(83, 311);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(247, 29);
            this.TxtEstado.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(83, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Estado";
            // 
            // R_GrupoSangre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtGrupo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtVolumen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDoctor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtPaciente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "R_GrupoSangre";
            this.Text = "R_GupoSangre";
            this.Load += new System.EventHandler(this.R_GupoSangre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox TxtPaciente;
        private Label label8;
        private ComboBox TxtDoctor;
        private Label label12;
        private Label label2;
        private Label label3;
        private TextBox TxtVolumen;
        private DateTimePicker TxtFecha;
        private Label label4;
        private Panel panel2;
        private Button BtnEliminar;
        private Button BtnNuevo;
        private Button BtnGuardar;
        private ComboBox TxtGrupo;
        private ComboBox TxtEstado;
        private Label label5;
    }
}