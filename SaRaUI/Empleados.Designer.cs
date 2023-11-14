namespace SaRaUI
{
    partial class Empleados
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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbEmpleados = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnBorrarEmpleado = new System.Windows.Forms.Button();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.btnTrabajosEmpleados = new System.Windows.Forms.Button();
            this.panelTablaC = new System.Windows.Forms.Panel();
            this.cbOrdenarEmpleados = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscarEmpleados = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTablaC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.panelFondo.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo;
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFondo.Controls.Add(this.pictureBox1);
            this.panelFondo.Controls.Add(this.lbEmpleados);
            this.panelFondo.Controls.Add(this.panelBottom);
            this.panelFondo.Controls.Add(this.panelTablaC);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(822, 477);
            this.panelFondo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SaRaUI.Properties.Resources.Logo_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(738, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbEmpleados
            // 
            this.lbEmpleados.AutoSize = true;
            this.lbEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.lbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbEmpleados.Location = new System.Drawing.Point(12, 19);
            this.lbEmpleados.Name = "lbEmpleados";
            this.lbEmpleados.Size = new System.Drawing.Size(257, 54);
            this.lbEmpleados.TabIndex = 0;
            this.lbEmpleados.Text = "Empleados";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnAgregarEmpleado);
            this.panelBottom.Controls.Add(this.btnBorrarEmpleado);
            this.panelBottom.Controls.Add(this.btnEditarEmpleado);
            this.panelBottom.Controls.Add(this.btnTrabajosEmpleados);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(822, 52);
            this.panelBottom.TabIndex = 2;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEmpleado.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Agregar;
            this.btnAgregarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(568, 3);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(44, 44);
            this.btnAgregarEmpleado.TabIndex = 5;
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarEmpleado.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Borrar;
            this.btnBorrarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnBorrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarEmpleado.Location = new System.Drawing.Point(628, 3);
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Size = new System.Drawing.Size(44, 44);
            this.btnBorrarEmpleado.TabIndex = 4;
            this.btnBorrarEmpleado.UseVisualStyleBackColor = false;
            this.btnBorrarEmpleado.Click += new System.EventHandler(this.btnBorrarEmpleado_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarEmpleado.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Editar;
            this.btnEditarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmpleado.Location = new System.Drawing.Point(688, 3);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(44, 44);
            this.btnEditarEmpleado.TabIndex = 3;
            this.btnEditarEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnTrabajosEmpleados
            // 
            this.btnTrabajosEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrabajosEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnTrabajosEmpleados.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Trabajo2;
            this.btnTrabajosEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrabajosEmpleados.FlatAppearance.BorderSize = 0;
            this.btnTrabajosEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajosEmpleados.Location = new System.Drawing.Point(748, 3);
            this.btnTrabajosEmpleados.Name = "btnTrabajosEmpleados";
            this.btnTrabajosEmpleados.Size = new System.Drawing.Size(44, 44);
            this.btnTrabajosEmpleados.TabIndex = 2;
            this.btnTrabajosEmpleados.UseVisualStyleBackColor = false;
            this.btnTrabajosEmpleados.Click += new System.EventHandler(this.btnTrabajosEmpleados_Click);
            // 
            // panelTablaC
            // 
            this.panelTablaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTablaC.BackColor = System.Drawing.Color.Transparent;
            this.panelTablaC.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo_Tablas;
            this.panelTablaC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTablaC.Controls.Add(this.cbOrdenarEmpleados);
            this.panelTablaC.Controls.Add(this.btnBuscar);
            this.panelTablaC.Controls.Add(this.tbBuscarEmpleados);
            this.panelTablaC.Controls.Add(this.dgvEmpleados);
            this.panelTablaC.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTablaC.Location = new System.Drawing.Point(15, 90);
            this.panelTablaC.Name = "panelTablaC";
            this.panelTablaC.Size = new System.Drawing.Size(790, 317);
            this.panelTablaC.TabIndex = 1;
            // 
            // cbOrdenarEmpleados
            // 
            this.cbOrdenarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.cbOrdenarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbOrdenarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cbOrdenarEmpleados.FormattingEnabled = true;
            this.cbOrdenarEmpleados.Location = new System.Drawing.Point(30, 16);
            this.cbOrdenarEmpleados.Name = "cbOrdenarEmpleados";
            this.cbOrdenarEmpleados.Size = new System.Drawing.Size(144, 32);
            this.cbOrdenarEmpleados.TabIndex = 7;
            this.cbOrdenarEmpleados.Text = "  Ordenar por";
            this.cbOrdenarEmpleados.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Buscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(723, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 35);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            // 
            // tbBuscarEmpleados
            // 
            this.tbBuscarEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbBuscarEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbBuscarEmpleados.Location = new System.Drawing.Point(530, 16);
            this.tbBuscarEmpleados.Name = "tbBuscarEmpleados";
            this.tbBuscarEmpleados.Size = new System.Drawing.Size(187, 29);
            this.tbBuscarEmpleados.TabIndex = 1;
            this.tbBuscarEmpleados.Visible = false;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(183)))), ((int)(((byte)(161)))));
            this.dgvEmpleados.Location = new System.Drawing.Point(30, 61);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(730, 226);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.panelFondo);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelTablaC.ResumeLayout(false);
            this.panelTablaC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbEmpleados;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnBorrarEmpleado;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.Button btnTrabajosEmpleados;
        private System.Windows.Forms.Panel panelTablaC;
        private System.Windows.Forms.ComboBox cbOrdenarEmpleados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscarEmpleados;
        public System.Windows.Forms.DataGridView dgvEmpleados;
    }
}