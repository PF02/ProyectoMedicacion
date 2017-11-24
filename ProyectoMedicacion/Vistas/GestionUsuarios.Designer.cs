namespace ProyectoMedicacion.Vistas
{
    partial class GestionUsuarios
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
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TablaUsuarios = new System.Windows.Forms.DataGridView();
            this.textIdPersona = new System.Windows.Forms.TextBox();
            this.textEstadoUsuario = new System.Windows.Forms.ComboBox();
            this.textConfirmacionCon = new System.Windows.Forms.TextBox();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.textNombreUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textIdUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textNombreEmpleado = new System.Windows.Forms.TextBox();
            this.ListPermisos = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonSI = new System.Windows.Forms.RadioButton();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.Location = new System.Drawing.Point(356, 390);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(121, 23);
            this.buttonGuardarCambios.TabIndex = 23;
            this.buttonGuardarCambios.Text = "Guardar Cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = true;
            this.buttonGuardarCambios.Click += new System.EventHandler(this.buttonGuardarCambios_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Estado del Usuario";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Confirmación Contraseña";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Persona";
            // 
            // TablaUsuarios
            // 
            this.TablaUsuarios.AllowUserToAddRows = false;
            this.TablaUsuarios.AllowUserToDeleteRows = false;
            this.TablaUsuarios.AllowUserToResizeColumns = false;
            this.TablaUsuarios.AllowUserToResizeRows = false;
            this.TablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TablaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.TablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaUsuarios.Location = new System.Drawing.Point(16, 100);
            this.TablaUsuarios.MultiSelect = false;
            this.TablaUsuarios.Name = "TablaUsuarios";
            this.TablaUsuarios.ReadOnly = true;
            this.TablaUsuarios.ShowEditingIcon = false;
            this.TablaUsuarios.Size = new System.Drawing.Size(470, 152);
            this.TablaUsuarios.TabIndex = 17;
            this.TablaUsuarios.Click += new System.EventHandler(this.TablaUsuarios_Click);
            // 
            // textIdPersona
            // 
            this.textIdPersona.Location = new System.Drawing.Point(73, 17);
            this.textIdPersona.Name = "textIdPersona";
            this.textIdPersona.ReadOnly = true;
            this.textIdPersona.Size = new System.Drawing.Size(45, 20);
            this.textIdPersona.TabIndex = 16;
            // 
            // textEstadoUsuario
            // 
            this.textEstadoUsuario.FormattingEnabled = true;
            this.textEstadoUsuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.textEstadoUsuario.Location = new System.Drawing.Point(356, 73);
            this.textEstadoUsuario.Name = "textEstadoUsuario";
            this.textEstadoUsuario.Size = new System.Drawing.Size(121, 21);
            this.textEstadoUsuario.TabIndex = 15;
            this.textEstadoUsuario.Text = "Inactivo";
            this.textEstadoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textConfirmacionCon
            // 
            this.textConfirmacionCon.Enabled = false;
            this.textConfirmacionCon.Location = new System.Drawing.Point(15, 83);
            this.textConfirmacionCon.Name = "textConfirmacionCon";
            this.textConfirmacionCon.PasswordChar = '*';
            this.textConfirmacionCon.Size = new System.Drawing.Size(142, 20);
            this.textConfirmacionCon.TabIndex = 14;
            this.textConfirmacionCon.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textContrasena
            // 
            this.textContrasena.Enabled = false;
            this.textContrasena.Location = new System.Drawing.Point(15, 37);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.PasswordChar = '*';
            this.textContrasena.Size = new System.Drawing.Size(143, 20);
            this.textContrasena.TabIndex = 13;
            this.textContrasena.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textNombreUsuario
            // 
            this.textNombreUsuario.Location = new System.Drawing.Point(127, 74);
            this.textNombreUsuario.Name = "textNombreUsuario";
            this.textNombreUsuario.ReadOnly = true;
            this.textNombreUsuario.Size = new System.Drawing.Size(121, 20);
            this.textNombreUsuario.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "ID Usuario";
            // 
            // textIdUsuario
            // 
            this.textIdUsuario.Location = new System.Drawing.Point(190, 17);
            this.textIdUsuario.Name = "textIdUsuario";
            this.textIdUsuario.ReadOnly = true;
            this.textIdUsuario.Size = new System.Drawing.Size(52, 20);
            this.textIdUsuario.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nombre del Empleado";
            // 
            // textNombreEmpleado
            // 
            this.textNombreEmpleado.Location = new System.Drawing.Point(129, 48);
            this.textNombreEmpleado.Name = "textNombreEmpleado";
            this.textNombreEmpleado.ReadOnly = true;
            this.textNombreEmpleado.Size = new System.Drawing.Size(260, 20);
            this.textNombreEmpleado.TabIndex = 28;
            // 
            // ListPermisos
            // 
            this.ListPermisos.FormattingEnabled = true;
            this.ListPermisos.Items.AddRange(new object[] {
            "Módulo de Usuarios",
            "Módulo de Personas",
            "Módulo de Medicamentos y Composión",
            "Módulo de Consulta Médica ",
            "Módulo de Proveedores",
            "Módulo de Compras",
            "Módulo de Inventario"});
            this.ListPermisos.Location = new System.Drawing.Point(73, 275);
            this.ListPermisos.Name = "ListPermisos";
            this.ListPermisos.Size = new System.Drawing.Size(249, 109);
            this.ListPermisos.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Permisos";
            // 
            // radioButtonSI
            // 
            this.radioButtonSI.AutoSize = true;
            this.radioButtonSI.Location = new System.Drawing.Point(21, 17);
            this.radioButtonSI.Name = "radioButtonSI";
            this.radioButtonSI.Size = new System.Drawing.Size(35, 17);
            this.radioButtonSI.TabIndex = 32;
            this.radioButtonSI.Text = "SI";
            this.radioButtonSI.UseVisualStyleBackColor = true;
            this.radioButtonSI.CheckedChanged += new System.EventHandler(this.radioButtonSI_CheckedChanged);
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Checked = true;
            this.radioButtonNO.Location = new System.Drawing.Point(80, 17);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNO.TabIndex = 33;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            this.radioButtonNO.CheckedChanged += new System.EventHandler(this.radioButtonNO_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textConfirmacionCon);
            this.groupBox1.Controls.Add(this.radioButtonNO);
            this.groupBox1.Controls.Add(this.textContrasena);
            this.groupBox1.Controls.Add(this.radioButtonSI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(328, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 109);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Actualizar Contraseña?";
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ListPermisos);
            this.Controls.Add(this.textNombreEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textIdUsuario);
            this.Controls.Add(this.buttonGuardarCambios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaUsuarios);
            this.Controls.Add(this.textIdPersona);
            this.Controls.Add(this.textEstadoUsuario);
            this.Controls.Add(this.textNombreUsuario);
            this.MaximizeBox = false;
            this.Name = "GestionUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardarCambios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TablaUsuarios;
        private System.Windows.Forms.TextBox textIdPersona;
        private System.Windows.Forms.ComboBox textEstadoUsuario;
        private System.Windows.Forms.TextBox textConfirmacionCon;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.TextBox textNombreUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textIdUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNombreEmpleado;
        private System.Windows.Forms.CheckedListBox ListPermisos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonSI;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}