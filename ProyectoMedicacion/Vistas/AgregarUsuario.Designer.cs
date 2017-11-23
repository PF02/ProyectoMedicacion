namespace ProyectoMedicacion.Vistas
{
    partial class AgregarUsuario
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
            this.textNombreUsuario = new System.Windows.Forms.TextBox();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.textComfirmacionContrasena = new System.Windows.Forms.TextBox();
            this.TextEstadoUsuario = new System.Windows.Forms.ComboBox();
            this.textIdPersona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombreApellido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombreUsuario
            // 
            this.textNombreUsuario.Location = new System.Drawing.Point(167, 57);
            this.textNombreUsuario.Name = "textNombreUsuario";
            this.textNombreUsuario.ReadOnly = true;
            this.textNombreUsuario.Size = new System.Drawing.Size(121, 20);
            this.textNombreUsuario.TabIndex = 0;
            // 
            // textContrasena
            // 
            this.textContrasena.Location = new System.Drawing.Point(167, 95);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.PasswordChar = '*';
            this.textContrasena.Size = new System.Drawing.Size(121, 20);
            this.textContrasena.TabIndex = 1;
            // 
            // textComfirmacionContrasena
            // 
            this.textComfirmacionContrasena.Location = new System.Drawing.Point(167, 137);
            this.textComfirmacionContrasena.Name = "textComfirmacionContrasena";
            this.textComfirmacionContrasena.PasswordChar = '*';
            this.textComfirmacionContrasena.Size = new System.Drawing.Size(121, 20);
            this.textComfirmacionContrasena.TabIndex = 2;
            // 
            // TextEstadoUsuario
            // 
            this.TextEstadoUsuario.FormattingEnabled = true;
            this.TextEstadoUsuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.TextEstadoUsuario.Location = new System.Drawing.Point(167, 178);
            this.TextEstadoUsuario.Name = "TextEstadoUsuario";
            this.TextEstadoUsuario.Size = new System.Drawing.Size(121, 21);
            this.TextEstadoUsuario.TabIndex = 3;
            this.TextEstadoUsuario.Text = "Inactivo";
            // 
            // textIdPersona
            // 
            this.textIdPersona.Location = new System.Drawing.Point(167, 21);
            this.textIdPersona.Name = "textIdPersona";
            this.textIdPersona.ReadOnly = true;
            this.textIdPersona.Size = new System.Drawing.Size(73, 20);
            this.textIdPersona.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirmación Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado del Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre del Empleado";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxNombreApellido
            // 
            this.textBoxNombreApellido.Location = new System.Drawing.Point(435, 21);
            this.textBoxNombreApellido.Name = "textBoxNombreApellido";
            this.textBoxNombreApellido.ReadOnly = true;
            this.textBoxNombreApellido.Size = new System.Drawing.Size(150, 20);
            this.textBoxNombreApellido.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 178);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaEmpleados_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.TablaEmpleados_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNombreApellido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textIdPersona);
            this.Controls.Add(this.TextEstadoUsuario);
            this.Controls.Add(this.textComfirmacionContrasena);
            this.Controls.Add(this.textContrasena);
            this.Controls.Add(this.textNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgregarUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombreUsuario;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.TextBox textComfirmacionContrasena;
        private System.Windows.Forms.ComboBox TextEstadoUsuario;
        private System.Windows.Forms.TextBox textIdPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNombreApellido;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}