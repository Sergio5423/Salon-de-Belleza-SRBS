namespace PresentaciónIF
{
    partial class ServiciosForm
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnEliminarServicios = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGuardarServicio = new System.Windows.Forms.Button();
            this.lbRegreso = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbDuracion = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbIdServicio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnEliminarServicios);
            this.groupBox8.Location = new System.Drawing.Point(21, 536);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(127, 49);
            this.groupBox8.TabIndex = 28;
            this.groupBox8.TabStop = false;
            // 
            // btnEliminarServicios
            // 
            this.btnEliminarServicios.Location = new System.Drawing.Point(23, 15);
            this.btnEliminarServicios.Name = "btnEliminarServicios";
            this.btnEliminarServicios.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarServicios.TabIndex = 13;
            this.btnEliminarServicios.Text = "Eliminar";
            this.btnEliminarServicios.UseVisualStyleBackColor = true;
            this.btnEliminarServicios.Click += new System.EventHandler(this.btnEliminarServicios_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.lbNombre);
            this.groupBox7.Controls.Add(this.lbCorreo);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.lbTelefono);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Location = new System.Drawing.Point(500, 48);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(304, 239);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(73, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Datos del Cliente vinculado\r\n";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(83, 71);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(120, 13);
            this.lbNombre.TabIndex = 22;
            this.lbNombre.Text = "Valor tomado del cliente";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Location = new System.Drawing.Point(82, 148);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(120, 13);
            this.lbCorreo.TabIndex = 19;
            this.lbCorreo.Text = "Valor tomado del cliente";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 148);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Correo";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(82, 108);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(120, 13);
            this.lbTelefono.TabIndex = 17;
            this.lbTelefono.Text = "Valor tomado del cliente";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Telefono";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Nombre";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbBusqueda);
            this.groupBox6.Controls.Add(this.dgvServicios);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(21, 298);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(835, 232);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Items.AddRange(new object[] {
            "Alisado Profesional",
            "Trabajo de Color",
            "Mantenimiento de Químicos",
            "Cliente Irregular"});
            this.cbBusqueda.Location = new System.Drawing.Point(93, 23);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(158, 21);
            this.cbBusqueda.TabIndex = 23;
            this.cbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbBusqueda_SelectedIndexChanged);
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(23, 55);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(796, 167);
            this.dgvServicios.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Busqueda";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Vincular Servicio a Cliente";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnGuardarServicio);
            this.groupBox5.Controls.Add(this.lbRegreso);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lbDuracion);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lbValor);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.lbIdServicio);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cbServicio);
            this.groupBox5.Location = new System.Drawing.Point(65, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 239);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // btnGuardarServicio
            // 
            this.btnGuardarServicio.Location = new System.Drawing.Point(219, 206);
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarServicio.TabIndex = 22;
            this.btnGuardarServicio.Text = "Guardar";
            this.btnGuardarServicio.UseVisualStyleBackColor = true;
            this.btnGuardarServicio.Click += new System.EventHandler(this.btnGuardarServicio_Click);
            // 
            // lbRegreso
            // 
            this.lbRegreso.AutoSize = true;
            this.lbRegreso.Location = new System.Drawing.Point(82, 191);
            this.lbRegreso.Name = "lbRegreso";
            this.lbRegreso.Size = new System.Drawing.Size(125, 13);
            this.lbRegreso.TabIndex = 21;
            this.lbRegreso.Text = "Valor tomado del servicio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Regreso";
            // 
            // lbDuracion
            // 
            this.lbDuracion.AutoSize = true;
            this.lbDuracion.Location = new System.Drawing.Point(82, 148);
            this.lbDuracion.Name = "lbDuracion";
            this.lbDuracion.Size = new System.Drawing.Size(125, 13);
            this.lbDuracion.TabIndex = 19;
            this.lbDuracion.Text = "Valor tomado del servicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Duracion";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(82, 108);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(125, 13);
            this.lbValor.TabIndex = 17;
            this.lbValor.Text = "Valor tomado del servicio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Valor";
            // 
            // lbIdServicio
            // 
            this.lbIdServicio.AutoSize = true;
            this.lbIdServicio.Location = new System.Drawing.Point(82, 29);
            this.lbIdServicio.Name = "lbIdServicio";
            this.lbIdServicio.Size = new System.Drawing.Size(273, 13);
            this.lbIdServicio.TabIndex = 15;
            this.lbIdServicio.Text = "ID de servicio tomado del cliente seleccionado en la grid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Servicio";
            // 
            // cbServicio
            // 
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Items.AddRange(new object[] {
            "Alisado Profesional",
            "Trabajo de Color",
            "Mantenimiento de Químicos",
            "Cliente Irregular"});
            this.cbServicio.Location = new System.Drawing.Point(85, 68);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(158, 21);
            this.cbServicio.TabIndex = 14;
            this.cbServicio.SelectedIndexChanged += new System.EventHandler(this.cbServicio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // ServiciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 602);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox5);
            this.Name = "ServiciosForm";
            this.Text = "ServiciosForm";
            this.Load += new System.EventHandler(this.ServiciosForm_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnEliminarServicios;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGuardarServicio;
        private System.Windows.Forms.Label lbRegreso;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbIdServicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.Label lbDuracion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.ComboBox cbBusqueda;
        private System.Windows.Forms.Label label1;
    }
}