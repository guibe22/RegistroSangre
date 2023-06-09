namespace RegistroSangre
{
    partial class R_Pacientes
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TxtGenero = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTROS PACIENTES";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Location = new System.Drawing.Point(-1, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 67);
            this.panel2.TabIndex = 1;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(461, 15);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(113, 32);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
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
            // TxtNombre
            // 
            this.TxtNombre.CausesValidation = false;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(155, 129);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(154, 29);
            this.TxtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(155, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(412, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.CausesValidation = false;
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido.Location = new System.Drawing.Point(412, 129);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(154, 29);
            this.TxtApellido.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(155, 175);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 21);
            this.label.TabIndex = 7;
            this.label.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(412, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.CausesValidation = false;
            this.TxtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDireccion.Location = new System.Drawing.Point(412, 199);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(154, 29);
            this.TxtDireccion.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(155, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.CausesValidation = false;
            this.TxtCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCorreo.Location = new System.Drawing.Point(155, 276);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(154, 29);
            this.TxtCorreo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(412, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(155, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(412, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha Nacimiento:";
            // 
            // TxtNacimiento
            // 
            this.TxtNacimiento.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtNacimiento.Location = new System.Drawing.Point(412, 357);
            this.TxtNacimiento.Name = "TxtNacimiento";
            this.TxtNacimiento.Size = new System.Drawing.Size(152, 23);
            this.TxtNacimiento.TabIndex = 18;
            this.TxtNacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCedula.Location = new System.Drawing.Point(155, 205);
            this.TxtCedula.Mask = "000-0000000-0";
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(154, 29);
            this.TxtCedula.TabIndex = 19;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelefono.Location = new System.Drawing.Point(410, 276);
            this.TxtTelefono.Mask = "(000)-000-0000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(154, 29);
            this.TxtTelefono.TabIndex = 20;
            // 
            // TxtGenero
            // 
            this.TxtGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGenero.FormattingEnabled = true;
            this.TxtGenero.Items.AddRange(new object[] {
            "HOMBRE",
            "MUJER"});
            this.TxtGenero.Location = new System.Drawing.Point(155, 360);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(154, 29);
            this.TxtGenero.TabIndex = 21;
            // 
            // R_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
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
            this.Name = "R_Pacientes";
            this.Text = "R_Pacientes";
            this.Load += new System.EventHandler(this.R_Pacientes_Load);
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
        private TextBox TxtNombre;
        private Label label2;
        private Label label3;
        private TextBox TxtApellido;
        private Label label;
        private Label label5;
        private TextBox TxtDireccion;
        private Label label6;
        private TextBox TxtCorreo;
        private Label label7;
        private Label label8;
        private Label label4;
        private DateTimePicker TxtNacimiento;
        private MaskedTextBox TxtCedula;
        private MaskedTextBox TxtTelefono;
        private ComboBox TxtGenero;
    }
}