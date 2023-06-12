namespace RegistroSangre
{
    partial class R_Doctores
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtGenero = new System.Windows.Forms.ComboBox();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.TxtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtConsultorio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEspecialidad = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 74);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DOCTORES";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Location = new System.Drawing.Point(-4, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 67);
            this.panel2.TabIndex = 2;
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
            // TxtGenero
            // 
            this.TxtGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGenero.FormattingEnabled = true;
            this.TxtGenero.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER"});
            this.TxtGenero.Location = new System.Drawing.Point(81, 328);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(154, 29);
            this.TxtGenero.TabIndex = 37;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelefono.Location = new System.Drawing.Point(336, 244);
            this.TxtTelefono.Mask = "(000)-000-0000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(154, 29);
            this.TxtTelefono.TabIndex = 36;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCedula.Location = new System.Drawing.Point(81, 173);
            this.TxtCedula.Mask = "000-0000000-0";
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(154, 29);
            this.TxtCedula.TabIndex = 35;
            // 
            // TxtNacimiento
            // 
            this.TxtNacimiento.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNacimiento.CustomFormat = "yyyy-MM-dd";
            this.TxtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtNacimiento.Location = new System.Drawing.Point(338, 325);
            this.TxtNacimiento.Name = "TxtNacimiento";
            this.TxtNacimiento.Size = new System.Drawing.Size(152, 23);
            this.TxtNacimiento.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(338, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(81, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Genero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(338, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(81, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Correo:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.CausesValidation = false;
            this.TxtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCorreo.Location = new System.Drawing.Point(81, 244);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(154, 29);
            this.TxtCorreo.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(338, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Direccion:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.CausesValidation = false;
            this.TxtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDireccion.Location = new System.Drawing.Point(338, 167);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(154, 29);
            this.TxtDireccion.TabIndex = 27;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(81, 143);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 21);
            this.label.TabIndex = 26;
            this.label.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(338, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.CausesValidation = false;
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido.Location = new System.Drawing.Point(338, 97);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(154, 29);
            this.TxtApellido.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.CausesValidation = false;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(81, 97);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(154, 29);
            this.TxtNombre.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(562, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 21);
            this.label12.TabIndex = 41;
            this.label12.Text = "Consultorio:";
            this.label12.Click += new System.EventHandler(this.label9_Click);
            // 
            // TxtConsultorio
            // 
            this.TxtConsultorio.CausesValidation = false;
            this.TxtConsultorio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtConsultorio.Location = new System.Drawing.Point(562, 167);
            this.TxtConsultorio.Name = "TxtConsultorio";
            this.TxtConsultorio.Size = new System.Drawing.Size(154, 29);
            this.TxtConsultorio.TabIndex = 40;
            this.TxtConsultorio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(562, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "Especialidad:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TxtEspecialidad
            // 
            this.TxtEspecialidad.CausesValidation = false;
            this.TxtEspecialidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEspecialidad.Location = new System.Drawing.Point(562, 97);
            this.TxtEspecialidad.Name = "TxtEspecialidad";
            this.TxtEspecialidad.Size = new System.Drawing.Size(154, 29);
            this.TxtEspecialidad.TabIndex = 38;
            this.TxtEspecialidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // R_Doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtConsultorio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtEspecialidad);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "R_Doctores";
            this.Text = "R_Doctores";
            this.Load += new System.EventHandler(this.R_Doctores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button BtnEliminar;
        private Button BtnNuevo;
        private Button BtnGuardar;
        private ComboBox TxtGenero;
        private MaskedTextBox TxtTelefono;
        private MaskedTextBox TxtCedula;
        private DateTimePicker TxtNacimiento;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox TxtCorreo;
        private Label label5;
        private TextBox TxtDireccion;
        private Label label;
        private Label label3;
        private TextBox TxtApellido;
        private Label label2;
        private TextBox TxtNombre;
        private Label label12;
        private TextBox TxtConsultorio;
        private Label label10;
        private TextBox TxtEspecialidad;
    }
}