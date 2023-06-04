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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnElminarServicio = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tbBuscarClientes = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSalirC = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbId = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEstilista = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaCumpleaños = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.dtUltimaVisita = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnAgregarTrabajo = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lbComisionE = new System.Windows.Forms.Label();
            this.cbTrabajoE = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbValorE = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNombreE = new System.Windows.Forms.TextBox();
            this.btnGuardarE = new System.Windows.Forms.Button();
            this.tbCedulaE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnActualizarE = new System.Windows.Forms.Button();
            this.btnPdfE = new System.Windows.Forms.Button();
            this.btnSalirE = new System.Windows.Forms.Button();
            this.btnEliminarE = new System.Windows.Forms.Button();
            this.tbBuscarEmpleados = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.tbBuscarClientes);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dgvClientes);
            this.panel5.Location = new System.Drawing.Point(-4, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(848, 309);
            this.panel5.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(105)))), ((int)(((byte)(96)))));
            this.panel8.Location = new System.Drawing.Point(0, -6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(806, 10);
            this.panel8.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.panel7.Controls.Add(this.btnServicios);
            this.panel7.Controls.Add(this.btnElminarServicio);
            this.panel7.Controls.Add(this.btnExportar);
            this.panel7.Controls.Add(this.btnActualizar);
            this.panel7.Location = new System.Drawing.Point(368, 249);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(419, 44);
            this.panel7.TabIndex = 21;
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicios.Location = new System.Drawing.Point(333, 12);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(75, 23);
            this.btnServicios.TabIndex = 14;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnElminarServicio
            // 
            this.btnElminarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnElminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElminarServicio.Location = new System.Drawing.Point(15, 12);
            this.btnElminarServicio.Name = "btnElminarServicio";
            this.btnElminarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnElminarServicio.TabIndex = 13;
            this.btnElminarServicio.Text = "Eliminar";
            this.btnElminarServicio.UseVisualStyleBackColor = false;
            this.btnElminarServicio.Click += new System.EventHandler(this.btnElminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportar.Location = new System.Drawing.Point(200, 12);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(114, 23);
            this.btnExportar.TabIndex = 15;
            this.btnExportar.Text = "Exportar PDF";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Location = new System.Drawing.Point(106, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tbBuscarClientes
            // 
            this.tbBuscarClientes.BackColor = System.Drawing.Color.White;
            this.tbBuscarClientes.Location = new System.Drawing.Point(109, 16);
            this.tbBuscarClientes.Name = "tbBuscarClientes";
            this.tbBuscarClientes.Size = new System.Drawing.Size(157, 25);
            this.tbBuscarClientes.TabIndex = 17;
            this.tbBuscarClientes.TextChanged += new System.EventHandler(this.tbBuscarClientes_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.panel6.Controls.Add(this.btnSalirC);
            this.panel6.Location = new System.Drawing.Point(20, 249);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(105, 44);
            this.panel6.TabIndex = 20;
            // 
            // btnSalirC
            // 
            this.btnSalirC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnSalirC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirC.Location = new System.Drawing.Point(12, 12);
            this.btnSalirC.Name = "btnSalirC";
            this.btnSalirC.Size = new System.Drawing.Size(75, 23);
            this.btnSalirC.TabIndex = 13;
            this.btnSalirC.Text = "Salir";
            this.btnSalirC.UseVisualStyleBackColor = false;
            this.btnSalirC.Click += new System.EventHandler(this.btnSalirC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Busqueda";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(32, 61);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(744, 182);
            this.dgvClientes.TabIndex = 15;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick_1);
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(844, 44);
            this.panel4.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de Clientes Sa Ra";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Controls.Add(this.tbCorreo);
            this.panel2.Controls.Add(this.tbTelefono);
            this.panel2.Controls.Add(this.tbNombre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(39, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 194);
            this.panel2.TabIndex = 17;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(17, 20);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(190, 17);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "Introduzca los datos del cliente";
            // 
            // tbCorreo
            // 
            this.tbCorreo.BackColor = System.Drawing.Color.White;
            this.tbCorreo.Location = new System.Drawing.Point(82, 149);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(161, 25);
            this.tbCorreo.TabIndex = 19;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.Color.White;
            this.tbTelefono.Location = new System.Drawing.Point(82, 108);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(161, 25);
            this.tbTelefono.TabIndex = 18;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.White;
            this.tbNombre.Location = new System.Drawing.Point(82, 58);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(161, 25);
            this.tbNombre.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbEstilista);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtFechaCumpleaños);
            this.panel1.Controls.Add(this.btnGuardarCliente);
            this.panel1.Controls.Add(this.dtUltimaVisita);
            this.panel1.Location = new System.Drawing.Point(368, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 194);
            this.panel1.TabIndex = 16;
            // 
            // tbEstilista
            // 
            this.tbEstilista.BackColor = System.Drawing.Color.White;
            this.tbEstilista.Location = new System.Drawing.Point(170, 108);
            this.tbEstilista.Name = "tbEstilista";
            this.tbEstilista.Size = new System.Drawing.Size(161, 25);
            this.tbEstilista.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de Cumpleaños";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estilista Preferido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ultima Visita";
            // 
            // dtFechaCumpleaños
            // 
            this.dtFechaCumpleaños.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dtFechaCumpleaños.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaCumpleaños.Location = new System.Drawing.Point(170, 19);
            this.dtFechaCumpleaños.Name = "dtFechaCumpleaños";
            this.dtFechaCumpleaños.Size = new System.Drawing.Size(215, 22);
            this.dtFechaCumpleaños.TabIndex = 11;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.White;
            this.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCliente.Location = new System.Drawing.Point(310, 157);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCliente.TabIndex = 8;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtUltimaVisita
            // 
            this.dtUltimaVisita.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dtUltimaVisita.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtUltimaVisita.Location = new System.Drawing.Point(170, 62);
            this.dtUltimaVisita.Name = "dtUltimaVisita";
            this.dtUltimaVisita.Size = new System.Drawing.Size(215, 22);
            this.dtUltimaVisita.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 623);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tabPage2.Controls.Add(this.panel11);
            this.tabPage2.Controls.Add(this.panel10);
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empleados";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnAgregarTrabajo);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Controls.Add(this.lbComisionE);
            this.panel11.Controls.Add(this.cbTrabajoE);
            this.panel11.Controls.Add(this.label17);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.lbValorE);
            this.panel11.Location = new System.Drawing.Point(388, 66);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(330, 197);
            this.panel11.TabIndex = 21;
            // 
            // btnAgregarTrabajo
            // 
            this.btnAgregarTrabajo.BackColor = System.Drawing.Color.White;
            this.btnAgregarTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarTrabajo.Location = new System.Drawing.Point(252, 162);
            this.btnAgregarTrabajo.Name = "btnAgregarTrabajo";
            this.btnAgregarTrabajo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTrabajo.TabIndex = 14;
            this.btnAgregarTrabajo.Text = "Agregar";
            this.btnAgregarTrabajo.UseVisualStyleBackColor = false;
            this.btnAgregarTrabajo.Click += new System.EventHandler(this.btnAgregarTrabajo_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "Trabajo Realizado";
            // 
            // lbComisionE
            // 
            this.lbComisionE.AutoSize = true;
            this.lbComisionE.Location = new System.Drawing.Point(141, 124);
            this.lbComisionE.Name = "lbComisionE";
            this.lbComisionE.Size = new System.Drawing.Size(17, 17);
            this.lbComisionE.TabIndex = 21;
            this.lbComisionE.Text = "...";
            // 
            // cbTrabajoE
            // 
            this.cbTrabajoE.BackColor = System.Drawing.Color.White;
            this.cbTrabajoE.FormattingEnabled = true;
            this.cbTrabajoE.Items.AddRange(new object[] {
            "Alisado Permanente",
            "Diseño de Color",
            "Mantenimiento de Químicos",
            "Restauración Capilar",
            "Blower"});
            this.cbTrabajoE.Location = new System.Drawing.Point(144, 23);
            this.cbTrabajoE.Name = "cbTrabajoE";
            this.cbTrabajoE.Size = new System.Drawing.Size(158, 25);
            this.cbTrabajoE.TabIndex = 15;
            this.cbTrabajoE.SelectedIndexChanged += new System.EventHandler(this.cbTrabajoE_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Comision";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Valor";
            // 
            // lbValorE
            // 
            this.lbValorE.AutoSize = true;
            this.lbValorE.Location = new System.Drawing.Point(141, 80);
            this.lbValorE.Name = "lbValorE";
            this.lbValorE.Size = new System.Drawing.Size(17, 17);
            this.lbValorE.TabIndex = 19;
            this.lbValorE.Text = "...";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.tbNombreE);
            this.panel10.Controls.Add(this.btnGuardarE);
            this.panel10.Controls.Add(this.tbCedulaE);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Location = new System.Drawing.Point(22, 66);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(292, 197);
            this.panel10.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ingrese los datos del Empleado";
            // 
            // tbNombreE
            // 
            this.tbNombreE.BackColor = System.Drawing.Color.White;
            this.tbNombreE.Location = new System.Drawing.Point(82, 116);
            this.tbNombreE.Name = "tbNombreE";
            this.tbNombreE.Size = new System.Drawing.Size(161, 25);
            this.tbNombreE.TabIndex = 9;
            // 
            // btnGuardarE
            // 
            this.btnGuardarE.BackColor = System.Drawing.Color.White;
            this.btnGuardarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarE.Location = new System.Drawing.Point(214, 162);
            this.btnGuardarE.Name = "btnGuardarE";
            this.btnGuardarE.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarE.TabIndex = 8;
            this.btnGuardarE.Text = "Guardar";
            this.btnGuardarE.UseVisualStyleBackColor = false;
            this.btnGuardarE.Click += new System.EventHandler(this.btnGuardarE_Click);
            // 
            // tbCedulaE
            // 
            this.tbCedulaE.BackColor = System.Drawing.Color.White;
            this.tbCedulaE.Location = new System.Drawing.Point(82, 75);
            this.tbCedulaE.Name = "tbCedulaE";
            this.tbCedulaE.Size = new System.Drawing.Size(161, 25);
            this.tbCedulaE.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cédula";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.panel9.Controls.Add(this.label15);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(844, 44);
            this.panel9.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Registro de Empleados Sa Ra";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.btnActualizarE);
            this.panel3.Controls.Add(this.btnPdfE);
            this.panel3.Controls.Add(this.btnSalirE);
            this.panel3.Controls.Add(this.btnEliminarE);
            this.panel3.Controls.Add(this.tbBuscarEmpleados);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dgvEmpleados);
            this.panel3.Location = new System.Drawing.Point(-4, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 313);
            this.panel3.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(105)))), ((int)(((byte)(96)))));
            this.panel12.Location = new System.Drawing.Point(2, -6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(806, 10);
            this.panel12.TabIndex = 23;
            // 
            // btnActualizarE
            // 
            this.btnActualizarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnActualizarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarE.Location = new System.Drawing.Point(510, 268);
            this.btnActualizarE.Name = "btnActualizarE";
            this.btnActualizarE.Size = new System.Drawing.Size(83, 23);
            this.btnActualizarE.TabIndex = 14;
            this.btnActualizarE.Text = "Actualizar";
            this.btnActualizarE.UseVisualStyleBackColor = false;
            this.btnActualizarE.Click += new System.EventHandler(this.btnActualizarE_Click);
            // 
            // btnPdfE
            // 
            this.btnPdfE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnPdfE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdfE.Location = new System.Drawing.Point(365, 268);
            this.btnPdfE.Name = "btnPdfE";
            this.btnPdfE.Size = new System.Drawing.Size(114, 23);
            this.btnPdfE.TabIndex = 15;
            this.btnPdfE.Text = "Exportar PDF";
            this.btnPdfE.UseVisualStyleBackColor = false;
            this.btnPdfE.Click += new System.EventHandler(this.btnPdfE_Click);
            // 
            // btnSalirE
            // 
            this.btnSalirE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnSalirE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirE.Location = new System.Drawing.Point(108, 268);
            this.btnSalirE.Name = "btnSalirE";
            this.btnSalirE.Size = new System.Drawing.Size(75, 23);
            this.btnSalirE.TabIndex = 13;
            this.btnSalirE.Text = "Salir";
            this.btnSalirE.UseVisualStyleBackColor = false;
            this.btnSalirE.Click += new System.EventHandler(this.btnSalirE_Click);
            // 
            // btnEliminarE
            // 
            this.btnEliminarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnEliminarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarE.Location = new System.Drawing.Point(616, 268);
            this.btnEliminarE.Name = "btnEliminarE";
            this.btnEliminarE.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarE.TabIndex = 13;
            this.btnEliminarE.Text = "Eliminar";
            this.btnEliminarE.UseVisualStyleBackColor = false;
            this.btnEliminarE.Click += new System.EventHandler(this.btnEliminarE_Click);
            // 
            // tbBuscarEmpleados
            // 
            this.tbBuscarEmpleados.BackColor = System.Drawing.Color.White;
            this.tbBuscarEmpleados.Location = new System.Drawing.Point(191, 19);
            this.tbBuscarEmpleados.Name = "tbBuscarEmpleados";
            this.tbBuscarEmpleados.Size = new System.Drawing.Size(161, 25);
            this.tbBuscarEmpleados.TabIndex = 17;
            this.tbBuscarEmpleados.TextChanged += new System.EventHandler(this.tbBuscarEmpleados_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Busqueda";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(125, 57);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(545, 190);
            this.dgvEmpleados.TabIndex = 15;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnElminarServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaCumpleaños;
        private System.Windows.Forms.DateTimePicker dtUltimaVisita;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.TextBox tbEstilista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbBuscarEmpleados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnGuardarE;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNombreE;
        private System.Windows.Forms.TextBox tbCedulaE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbTrabajoE;
        private System.Windows.Forms.Label lbComisionE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbValorE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAgregarTrabajo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnPdfE;
        private System.Windows.Forms.Button btnSalirC;
        private System.Windows.Forms.Button btnSalirE;
        private System.Windows.Forms.Button btnActualizarE;
        private System.Windows.Forms.Button btnEliminarE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbBuscarClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel12;
    }
}

