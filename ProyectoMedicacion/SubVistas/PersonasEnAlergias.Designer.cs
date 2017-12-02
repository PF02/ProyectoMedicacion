namespace ProyectoMedicacion.SubVistas
{
    partial class PersonasEnAlergias
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
            this.TablaPersonas = new System.Windows.Forms.DataGridView();
            this.textBoxNombrePersona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxIdPersona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFiltrarBusquedaPersona = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.ButtonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaPersonas
            // 
            this.TablaPersonas.AllowUserToAddRows = false;
            this.TablaPersonas.AllowUserToDeleteRows = false;
            this.TablaPersonas.AllowUserToResizeColumns = false;
            this.TablaPersonas.AllowUserToResizeRows = false;
            this.TablaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPersonas.Location = new System.Drawing.Point(12, 149);
            this.TablaPersonas.MultiSelect = false;
            this.TablaPersonas.Name = "TablaPersonas";
            this.TablaPersonas.ReadOnly = true;
            this.TablaPersonas.ShowCellErrors = false;
            this.TablaPersonas.ShowCellToolTips = false;
            this.TablaPersonas.ShowEditingIcon = false;
            this.TablaPersonas.ShowRowErrors = false;
            this.TablaPersonas.Size = new System.Drawing.Size(458, 206);
            this.TablaPersonas.TabIndex = 6;
            this.TablaPersonas.TabStop = false;
            this.TablaPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPersonas_CellContentClick);
            this.TablaPersonas.Click += new System.EventHandler(this.TablaPersonas_Click);
            // 
            // textBoxNombrePersona
            // 
            this.textBoxNombrePersona.Location = new System.Drawing.Point(53, 47);
            this.textBoxNombrePersona.Name = "textBoxNombrePersona";
            this.textBoxNombrePersona.ReadOnly = true;
            this.textBoxNombrePersona.Size = new System.Drawing.Size(215, 20);
            this.textBoxNombrePersona.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxIdPersona);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNombrePersona);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Persona";
            // 
            // textBoxIdPersona
            // 
            this.textBoxIdPersona.Location = new System.Drawing.Point(53, 21);
            this.textBoxIdPersona.Name = "textBoxIdPersona";
            this.textBoxIdPersona.ReadOnly = true;
            this.textBoxIdPersona.Size = new System.Drawing.Size(45, 20);
            this.textBoxIdPersona.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // textBoxFiltrarBusquedaPersona
            // 
            this.textBoxFiltrarBusquedaPersona.Location = new System.Drawing.Point(98, 123);
            this.textBoxFiltrarBusquedaPersona.Name = "textBoxFiltrarBusquedaPersona";
            this.textBoxFiltrarBusquedaPersona.Size = new System.Drawing.Size(205, 20);
            this.textBoxFiltrarBusquedaPersona.TabIndex = 10;
            this.textBoxFiltrarBusquedaPersona.TextChanged += new System.EventHandler(this.textBoxFiltrarBusquedaPersona_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filtrar Búsqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonLimpiar);
            this.groupBox2.Controls.Add(this.buttonSeleccionar);
            this.groupBox2.Location = new System.Drawing.Point(343, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 126);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(23, 16);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 50);
            this.buttonSeleccionar.TabIndex = 0;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // ButtonLimpiar
            // 
            this.ButtonLimpiar.Location = new System.Drawing.Point(23, 71);
            this.ButtonLimpiar.Name = "ButtonLimpiar";
            this.ButtonLimpiar.Size = new System.Drawing.Size(75, 50);
            this.ButtonLimpiar.TabIndex = 1;
            this.ButtonLimpiar.Text = "Limpiar Campos";
            this.ButtonLimpiar.UseVisualStyleBackColor = true;
            this.ButtonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // PersonasEnAlergias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFiltrarBusquedaPersona);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TablaPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonasEnAlergias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.PersonasEnAlergias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaPersonas;
        private System.Windows.Forms.TextBox textBoxNombrePersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxIdPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFiltrarBusquedaPersona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button ButtonLimpiar;
    }
}