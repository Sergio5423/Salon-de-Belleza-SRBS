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
            this.lbId = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtFechaCumpleaños = new System.Windows.Forms.DateTimePicker();
            this.dtUltimaVisita = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBuscarClientes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnActualizarServicio = new System.Windows.Forms.Button();
            this.btnElminarServicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnCargarServicios = new System.Windows.Forms.Button();
            this.btnActualizarServicios = new System.Windows.Forms.Button();
            this.btnEliminarServicios = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbFiltroServicios = new System.Windows.Forms.ComboBox();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.tbBuscarServicios = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Controls.Add(this.tbCorreo);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(30, 44);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(199, 13);
            this.lbId.TabIndex = 13;
            this.lbId.Text = "ID de cliente generado automaticamente";
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
            this.groupBox2.Controls.Add(this.btnGuardarCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(376, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtFechaCumpleaños
            // 
            this.dtFechaCumpleaños.Location = new System.Drawing.Point(164, 37);
            this.dtFechaCumpleaños.Name = "dtFechaCumpleaños";
            this.dtFechaCumpleaños.Size = new System.Drawing.Size(215, 20);
            this.dtFechaCumpleaños.TabIndex = 11;
            // 
            // dtUltimaVisita
            // 
            this.dtUltimaVisita.Location = new System.Drawing.Point(164, 98);
            this.dtUltimaVisita.Name = "dtUltimaVisita";
            this.dtUltimaVisita.Size = new System.Drawing.Size(215, 20);
            this.dtUltimaVisita.TabIndex = 10;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(305, 152);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCliente.TabIndex = 8;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de Cumpleaños";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ultima Visita";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbBuscarClientes);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dgvClientes);
            this.groupBox3.Location = new System.Drawing.Point(21, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(849, 265);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tbBuscarClientes
            // 
            this.tbBuscarClientes.Location = new System.Drawing.Point(98, 28);
            this.tbBuscarClientes.Name = "tbBuscarClientes";
            this.tbBuscarClientes.Size = new System.Drawing.Size(121, 20);
            this.tbBuscarClientes.TabIndex = 13;
            this.tbBuscarClientes.TextChanged += new System.EventHandler(this.tbBuscarClientes_TextChanged);
            this.tbBuscarClientes.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tbBuscarClientes_ControlRemoved);
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
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(33, 75);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(796, 167);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnActualizarServicio);
            this.groupBox4.Controls.Add(this.btnElminarServicio);
            this.groupBox4.Location = new System.Drawing.Point(21, 533);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnActualizarServicio
            // 
            this.btnActualizarServicio.Location = new System.Drawing.Point(130, 15);
            this.btnActualizarServicio.Name = "btnActualizarServicio";
            this.btnActualizarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarServicio.TabIndex = 14;
            this.btnActualizarServicio.Text = "Actualizar";
            this.btnActualizarServicio.UseVisualStyleBackColor = true;
            this.btnActualizarServicio.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnElminarServicio
            // 
            this.btnElminarServicio.Location = new System.Drawing.Point(23, 15);
            this.btnElminarServicio.Name = "btnElminarServicio";
            this.btnElminarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnElminarServicio.TabIndex = 13;
            this.btnElminarServicio.Text = "Eliminar";
            this.btnElminarServicio.UseVisualStyleBackColor = true;
            this.btnElminarServicio.Click += new System.EventHandler(this.btnElminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de Clientes Salon de Belleza";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 626);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vincular Servicio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnCargarServicios);
            this.groupBox8.Controls.Add(this.btnActualizarServicios);
            this.groupBox8.Controls.Add(this.btnEliminarServicios);
            this.groupBox8.Location = new System.Drawing.Point(28, 538);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(334, 49);
            this.groupBox8.TabIndex = 23;
            this.groupBox8.TabStop = false;
            // 
            // btnCargarServicios
            // 
            this.btnCargarServicios.Location = new System.Drawing.Point(238, 15);
            this.btnCargarServicios.Name = "btnCargarServicios";
            this.btnCargarServicios.Size = new System.Drawing.Size(75, 23);
            this.btnCargarServicios.TabIndex = 12;
            this.btnCargarServicios.Text = "Cargar";
            this.btnCargarServicios.UseVisualStyleBackColor = true;
            // 
            // btnActualizarServicios
            // 
            this.btnActualizarServicios.Location = new System.Drawing.Point(130, 15);
            this.btnActualizarServicios.Name = "btnActualizarServicios";
            this.btnActualizarServicios.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarServicios.TabIndex = 14;
            this.btnActualizarServicios.Text = "Actualizar";
            this.btnActualizarServicios.UseVisualStyleBackColor = true;
            // 
            // btnEliminarServicios
            // 
            this.btnEliminarServicios.Location = new System.Drawing.Point(23, 15);
            this.btnEliminarServicios.Name = "btnEliminarServicios";
            this.btnEliminarServicios.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarServicios.TabIndex = 13;
            this.btnEliminarServicios.Text = "Eliminar";
            this.btnEliminarServicios.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.lbNombre);
            this.groupBox7.Controls.Add(this.lbCorreo);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.lbTelefono);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.lbInfo);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Location = new System.Drawing.Point(507, 50);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(304, 239);
            this.groupBox7.TabIndex = 22;
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
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(64, 191);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(174, 26);
            this.lbInfo.TabIndex = 15;
            this.lbInfo.Text = "Seleccione un servicio\r\npara ver el cliente al que se vincula";
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
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.cbFiltroServicios);
            this.groupBox6.Controls.Add(this.btnBuscarServicio);
            this.groupBox6.Controls.Add(this.tbBuscarServicios);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.dgvServicios);
            this.groupBox6.Location = new System.Drawing.Point(28, 300);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(835, 232);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(510, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Filtro";
            // 
            // cbFiltroServicios
            // 
            this.cbFiltroServicios.FormattingEnabled = true;
            this.cbFiltroServicios.Items.AddRange(new object[] {
            "Alisado Profesional",
            "Trabajo de Color",
            "Mantenimiento de Químicos",
            "Clientes Irregular"});
            this.cbFiltroServicios.Location = new System.Drawing.Point(558, 27);
            this.cbFiltroServicios.Name = "cbFiltroServicios";
            this.cbFiltroServicios.Size = new System.Drawing.Size(170, 21);
            this.cbFiltroServicios.TabIndex = 13;
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Location = new System.Drawing.Point(238, 26);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarServicio.TabIndex = 13;
            this.btnBuscarServicio.Text = "Buscar";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            // 
            // tbBuscarServicios
            // 
            this.tbBuscarServicios.Location = new System.Drawing.Point(86, 28);
            this.tbBuscarServicios.Name = "tbBuscarServicios";
            this.tbBuscarServicios.Size = new System.Drawing.Size(121, 20);
            this.tbBuscarServicios.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Busqueda";
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(20, 77);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(796, 131);
            this.dgvServicios.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Vincular Servicio a Cliente";
            // 
            // groupBox5
            // 
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
            this.groupBox5.Location = new System.Drawing.Point(72, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 239);
            this.groupBox5.TabIndex = 15;
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
            this.lbIdServicio.Location = new System.Drawing.Point(17, 31);
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
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbBuscarClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualizarServicio;
        private System.Windows.Forms.Button btnElminarServicio;
        private System.Windows.Forms.DateTimePicker dtFechaCumpleaños;
        private System.Windows.Forms.DateTimePicker dtUltimaVisita;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.Label lbIdServicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbDuracion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbRegreso;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbFiltroServicios;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.TextBox tbBuscarServicios;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnCargarServicios;
        private System.Windows.Forms.Button btnActualizarServicios;
        private System.Windows.Forms.Button btnEliminarServicios;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGuardarServicio;
    }
}

