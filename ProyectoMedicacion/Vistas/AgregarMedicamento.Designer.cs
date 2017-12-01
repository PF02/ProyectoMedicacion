namespace ProyectoMedicacion.Vistas
{
    partial class AgregarMedicamento
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
            this.textNombreMedicamento = new System.Windows.Forms.TextBox();
            this.TextFechaExpiracion = new System.Windows.Forms.DateTimePicker();
            this.TextIndicacionesMedicamento = new System.Windows.Forms.RichTextBox();
            this.TextDosisMedicamento = new System.Windows.Forms.RichTextBox();
            this.TextContenedorMedicamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarComponente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListaSintomas = new System.Windows.Forms.CheckedListBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.textBoxComponenteAAgregar = new System.Windows.Forms.TextBox();
            this.buttonAgregarComponenteALista = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNombreMedicamento
            // 
            this.textNombreMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreMedicamento.Location = new System.Drawing.Point(174, 32);
            this.textNombreMedicamento.Name = "textNombreMedicamento";
            this.textNombreMedicamento.Size = new System.Drawing.Size(200, 20);
            this.textNombreMedicamento.TabIndex = 0;
            // 
            // TextFechaExpiracion
            // 
            this.TextFechaExpiracion.CustomFormat = "yyyy-MM-dd";
            this.TextFechaExpiracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFechaExpiracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TextFechaExpiracion.Location = new System.Drawing.Point(174, 72);
            this.TextFechaExpiracion.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.TextFechaExpiracion.Name = "TextFechaExpiracion";
            this.TextFechaExpiracion.Size = new System.Drawing.Size(128, 20);
            this.TextFechaExpiracion.TabIndex = 1;
            // 
            // TextIndicacionesMedicamento
            // 
            this.TextIndicacionesMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIndicacionesMedicamento.Location = new System.Drawing.Point(174, 175);
            this.TextIndicacionesMedicamento.Name = "TextIndicacionesMedicamento";
            this.TextIndicacionesMedicamento.Size = new System.Drawing.Size(200, 79);
            this.TextIndicacionesMedicamento.TabIndex = 2;
            this.TextIndicacionesMedicamento.Text = "";
            // 
            // TextDosisMedicamento
            // 
            this.TextDosisMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDosisMedicamento.Location = new System.Drawing.Point(174, 281);
            this.TextDosisMedicamento.Name = "TextDosisMedicamento";
            this.TextDosisMedicamento.Size = new System.Drawing.Size(200, 68);
            this.TextDosisMedicamento.TabIndex = 3;
            this.TextDosisMedicamento.Text = "";
            // 
            // TextContenedorMedicamento
            // 
            this.TextContenedorMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextContenedorMedicamento.FormattingEnabled = true;
            this.TextContenedorMedicamento.Items.AddRange(new object[] {
            "Frasco",
            "Sobre",
            "Caja"});
            this.TextContenedorMedicamento.Location = new System.Drawing.Point(174, 122);
            this.TextContenedorMedicamento.Name = "TextContenedorMedicamento";
            this.TextContenedorMedicamento.Size = new System.Drawing.Size(128, 21);
            this.TextContenedorMedicamento.TabIndex = 4;
            this.TextContenedorMedicamento.Text = "Frasco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Expiración";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contenedor del Medicamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Indicaciones del Medicamento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dosis del Medicamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextDosisMedicamento);
            this.groupBox1.Controls.Add(this.TextIndicacionesMedicamento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextFechaExpiracion);
            this.groupBox1.Controls.Add(this.TextContenedorMedicamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNombreMedicamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 373);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Medicamento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAgregarComponenteALista);
            this.groupBox2.Controls.Add(this.textBoxComponenteAAgregar);
            this.groupBox2.Controls.Add(this.buttonBuscarComponente);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(461, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 208);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Componentes del Medicamento";
            // 
            // buttonBuscarComponente
            // 
            this.buttonBuscarComponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarComponente.Location = new System.Drawing.Point(181, 24);
            this.buttonBuscarComponente.Name = "buttonBuscarComponente";
            this.buttonBuscarComponente.Size = new System.Drawing.Size(60, 23);
            this.buttonBuscarComponente.TabIndex = 1;
            this.buttonBuscarComponente.Text = "Buscar...";
            this.buttonBuscarComponente.UseVisualStyleBackColor = true;
            this.buttonBuscarComponente.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdComponente,
            this.Componente});
            this.dataGridView1.Location = new System.Drawing.Point(27, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(262, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdComponente
            // 
            this.IdComponente.HeaderText = "Id";
            this.IdComponente.Name = "IdComponente";
            this.IdComponente.ReadOnly = true;
            this.IdComponente.Width = 50;
            // 
            // Componente
            // 
            this.Componente.HeaderText = "Componente";
            this.Componente.Name = "Componente";
            this.Componente.ReadOnly = true;
            this.Componente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Componente.Width = 200;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListaSintomas);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(461, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 161);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sintomas";
            // 
            // ListaSintomas
            // 
            this.ListaSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaSintomas.FormattingEnabled = true;
            this.ListaSintomas.Items.AddRange(new object[] {
            "Agotamiento",
            "Diarrea\t",
            "Dificultad Respiratoria",
            "Dolor de Cabeza",
            "Dolor de Estómago",
            "Dolor de Extremidades",
            "Extreñimiento",
            "Fiebre",
            "Ganas de Orinar",
            "Tos",
            "Picor",
            "Mareos"});
            this.ListaSintomas.Location = new System.Drawing.Point(15, 25);
            this.ListaSintomas.Name = "ListaSintomas";
            this.ListaSintomas.Size = new System.Drawing.Size(276, 124);
            this.ListaSintomas.TabIndex = 0;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.Location = new System.Drawing.Point(345, 421);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(90, 53);
            this.botonGuardar.TabIndex = 13;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // textBoxComponenteAAgregar
            // 
            this.textBoxComponenteAAgregar.Location = new System.Drawing.Point(14, 25);
            this.textBoxComponenteAAgregar.Name = "textBoxComponenteAAgregar";
            this.textBoxComponenteAAgregar.ReadOnly = true;
            this.textBoxComponenteAAgregar.Size = new System.Drawing.Size(161, 22);
            this.textBoxComponenteAAgregar.TabIndex = 2;
            this.textBoxComponenteAAgregar.TextChanged += new System.EventHandler(this.textBoxComponenteAAgregar_TextChanged);
            // 
            // buttonAgregarComponenteALista
            // 
            this.buttonAgregarComponenteALista.Enabled = false;
            this.buttonAgregarComponenteALista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarComponenteALista.Location = new System.Drawing.Point(246, 24);
            this.buttonAgregarComponenteALista.Name = "buttonAgregarComponenteALista";
            this.buttonAgregarComponenteALista.Size = new System.Drawing.Size(60, 23);
            this.buttonAgregarComponenteALista.TabIndex = 3;
            this.buttonAgregarComponenteALista.Text = "Agregar";
            this.buttonAgregarComponenteALista.UseVisualStyleBackColor = true;
            this.buttonAgregarComponenteALista.Click += new System.EventHandler(this.buttonAgregarComponenteALista_Click);
            // 
            // AgregarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 476);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgregarMedicamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Medicamento";
            this.Activated += new System.EventHandler(this.AgregarMedicamento_Activated);
            this.Load += new System.EventHandler(this.AgregarMedicamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textNombreMedicamento;
        private System.Windows.Forms.DateTimePicker TextFechaExpiracion;
        private System.Windows.Forms.RichTextBox TextIndicacionesMedicamento;
        private System.Windows.Forms.RichTextBox TextDosisMedicamento;
        private System.Windows.Forms.ComboBox TextContenedorMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox ListaSintomas;
        private System.Windows.Forms.Button buttonBuscarComponente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Componente;
        private System.Windows.Forms.Button buttonAgregarComponenteALista;
        private System.Windows.Forms.TextBox textBoxComponenteAAgregar;
    }
}