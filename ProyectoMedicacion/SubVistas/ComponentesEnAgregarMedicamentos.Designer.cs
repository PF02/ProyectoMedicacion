namespace ProyectoMedicacion.SubVistas
{
    partial class ComponentesEnAgregarMedicamentos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAgregarNuevoComponente = new System.Windows.Forms.Button();
            this.textNombreNuevoComponente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSeleccionarComponente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFiltrarBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(225, 132);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAgregarNuevoComponente);
            this.groupBox1.Controls.Add(this.textNombreNuevoComponente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Componente";
            // 
            // buttonAgregarNuevoComponente
            // 
            this.buttonAgregarNuevoComponente.Location = new System.Drawing.Point(218, 53);
            this.buttonAgregarNuevoComponente.Name = "buttonAgregarNuevoComponente";
            this.buttonAgregarNuevoComponente.Size = new System.Drawing.Size(93, 44);
            this.buttonAgregarNuevoComponente.TabIndex = 2;
            this.buttonAgregarNuevoComponente.Text = "Agregar Nuevo Componente";
            this.buttonAgregarNuevoComponente.UseVisualStyleBackColor = true;
            this.buttonAgregarNuevoComponente.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNombreNuevoComponente
            // 
            this.textNombreNuevoComponente.Location = new System.Drawing.Point(155, 23);
            this.textNombreNuevoComponente.Name = "textNombreNuevoComponente";
            this.textNombreNuevoComponente.Size = new System.Drawing.Size(156, 20);
            this.textNombreNuevoComponente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Componente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSeleccionarComponente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxFiltrarBusqueda);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Componentes Existentes";
            // 
            // buttonSeleccionarComponente
            // 
            this.buttonSeleccionarComponente.Location = new System.Drawing.Point(113, 194);
            this.buttonSeleccionarComponente.Name = "buttonSeleccionarComponente";
            this.buttonSeleccionarComponente.Size = new System.Drawing.Size(117, 43);
            this.buttonSeleccionarComponente.TabIndex = 4;
            this.buttonSeleccionarComponente.Text = "Seleccionar Componente";
            this.buttonSeleccionarComponente.UseVisualStyleBackColor = true;
            this.buttonSeleccionarComponente.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtrar Busqueda";
            // 
            // textBoxFiltrarBusqueda
            // 
            this.textBoxFiltrarBusqueda.Location = new System.Drawing.Point(122, 27);
            this.textBoxFiltrarBusqueda.Name = "textBoxFiltrarBusqueda";
            this.textBoxFiltrarBusqueda.Size = new System.Drawing.Size(166, 20);
            this.textBoxFiltrarBusqueda.TabIndex = 2;
            this.textBoxFiltrarBusqueda.TextChanged += new System.EventHandler(this.textBoxFiltrarBusqueda_TextChanged);
            // 
            // ComponentesEnAgregarMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentesEnAgregarMedicamentos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccinar Componente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComponentesEnAgregarMedicamentos_FormClosed);
            this.Load += new System.EventHandler(this.ComponentesEnAgregarMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAgregarNuevoComponente;
        private System.Windows.Forms.TextBox textNombreNuevoComponente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSeleccionarComponente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFiltrarBusqueda;
    }
}