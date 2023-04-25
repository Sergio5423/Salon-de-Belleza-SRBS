namespace PresentaciónIF
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtFechaCumpleaños = new System.Windows.Forms.DateTimePicker();
            this.dtUltimaVisita = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridViewClientes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnElminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridUltimaVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCumpleaños = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridRegreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbCorreo);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Alisado Profesional",
            "Trabajo de Color",
            "Mantenimiento de Químicos",
            "Cliente Irregular"});
            this.cbCategoria.Location = new System.Drawing.Point(98, 36);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(158, 21);
            this.cbCategoria.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Categoria";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(95, 154);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(161, 20);
            this.tbCorreo.TabIndex = 10;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(95, 118);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(161, 20);
            this.tbTelefono.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(95, 79);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(161, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFechaCumpleaños);
            this.groupBox2.Controls.Add(this.dtUltimaVisita);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(372, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtFechaCumpleaños
            // 
            this.dtFechaCumpleaños.Location = new System.Drawing.Point(164, 97);
            this.dtFechaCumpleaños.Name = "dtFechaCumpleaños";
            this.dtFechaCumpleaños.Size = new System.Drawing.Size(215, 20);
            this.dtFechaCumpleaños.TabIndex = 11;
            // 
            // dtUltimaVisita
            // 
            this.dtUltimaVisita.Location = new System.Drawing.Point(123, 36);
            this.dtUltimaVisita.Name = "dtUltimaVisita";
            this.dtUltimaVisita.Size = new System.Drawing.Size(215, 20);
            this.dtUltimaVisita.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(304, 152);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de Cumpleaños";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ultima Visita";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbFiltro);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.tbBusqueda);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.gridViewClientes);
            this.groupBox3.Location = new System.Drawing.Point(23, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(849, 265);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Filtro";
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Alisado Profesional",
            "Trabajo de Color",
            "Mantenimiento de Químicos",
            "Clientes Irregular"});
            this.cbFiltro.Location = new System.Drawing.Point(558, 27);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(170, 21);
            this.cbFiltro.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(238, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(98, 28);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(121, 20);
            this.tbBusqueda.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Busqueda";
            // 
            // gridViewClientes
            // 
            this.gridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridCategoria,
            this.gridNombre,
            this.gridTelefono,
            this.gridCorreo,
            this.gridUltimaVisita,
            this.gridCumpleaños,
            this.gridRegreso});
            this.gridViewClientes.Location = new System.Drawing.Point(33, 65);
            this.gridViewClientes.Name = "gridViewClientes";
            this.gridViewClientes.Size = new System.Drawing.Size(796, 167);
            this.gridViewClientes.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnActualizar);
            this.groupBox4.Controls.Add(this.btnElminar);
            this.groupBox4.Location = new System.Drawing.Point(23, 581);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(130, 15);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnElminar
            // 
            this.btnElminar.Location = new System.Drawing.Point(23, 15);
            this.btnElminar.Name = "btnElminar";
            this.btnElminar.Size = new System.Drawing.Size(75, 23);
            this.btnElminar.TabIndex = 13;
            this.btnElminar.Text = "Eliminar";
            this.btnElminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de Clientes Salon de Belleza";
            // 
            // gridCategoria
            // 
            this.gridCategoria.HeaderText = "Categoria";
            this.gridCategoria.Name = "gridCategoria";
            // 
            // gridNombre
            // 
            this.gridNombre.HeaderText = "Nombre";
            this.gridNombre.Name = "gridNombre";
            // 
            // gridTelefono
            // 
            this.gridTelefono.HeaderText = "Telefono";
            this.gridTelefono.Name = "gridTelefono";
            // 
            // gridCorreo
            // 
            this.gridCorreo.HeaderText = "Correo";
            this.gridCorreo.Name = "gridCorreo";
            // 
            // gridUltimaVisita
            // 
            this.gridUltimaVisita.HeaderText = "Ultima Visita";
            this.gridUltimaVisita.Name = "gridUltimaVisita";
            // 
            // gridCumpleaños
            // 
            this.gridCumpleaños.HeaderText = "Cumpleaños";
            this.gridCumpleaños.Name = "gridCumpleaños";
            // 
            // gridRegreso
            // 
            this.gridRegreso.HeaderText = "Regreso";
            this.gridRegreso.Name = "gridRegreso";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridViewClientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnElminar;
        private System.Windows.Forms.DateTimePicker dtFechaCumpleaños;
        private System.Windows.Forms.DateTimePicker dtUltimaVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridUltimaVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCumpleaños;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridRegreso;
    }
}

