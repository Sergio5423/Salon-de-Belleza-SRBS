namespace SaRaUI
{
    partial class Servicios_Cliente
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
            this.panelTablaC = new System.Windows.Forms.Panel();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.dgvServicios_Cliente = new System.Windows.Forms.DataGridView();
            this.cbServicios = new System.Windows.Forms.ComboBox();
            this.panelNombreCliente = new System.Windows.Forms.Panel();
            this.lbNombreCliente = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAtrasSC = new System.Windows.Forms.Button();
            this.btnGuardarSC = new System.Windows.Forms.Button();
            this.btnBorrarSC = new System.Windows.Forms.Button();
            this.lbServicios_del_Cliente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelTablaC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios_Cliente)).BeginInit();
            this.panelNombreCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTablaC
            // 
            this.panelTablaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTablaC.BackColor = System.Drawing.Color.Transparent;
            this.panelTablaC.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Nuevo_Cliente;
            this.panelTablaC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTablaC.Controls.Add(this.cbEmpleados);
            this.panelTablaC.Controls.Add(this.dgvServicios_Cliente);
            this.panelTablaC.Controls.Add(this.cbServicios);
            this.panelTablaC.Controls.Add(this.panelNombreCliente);
            this.panelTablaC.Controls.Add(this.pictureBox2);
            this.panelTablaC.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTablaC.Location = new System.Drawing.Point(15, 90);
            this.panelTablaC.Name = "panelTablaC";
            this.panelTablaC.Size = new System.Drawing.Size(790, 317);
            this.panelTablaC.TabIndex = 1;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.cbEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(640, 16);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(124, 32);
            this.cbEmpleados.TabIndex = 12;
            this.cbEmpleados.Text = "Empleados";
            // 
            // dgvServicios_Cliente
            // 
            this.dgvServicios_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicios_Cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.dgvServicios_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios_Cliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(183)))), ((int)(((byte)(161)))));
            this.dgvServicios_Cliente.Location = new System.Drawing.Point(30, 61);
            this.dgvServicios_Cliente.Name = "dgvServicios_Cliente";
            this.dgvServicios_Cliente.Size = new System.Drawing.Size(730, 226);
            this.dgvServicios_Cliente.TabIndex = 0;
            this.dgvServicios_Cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_Cliente_CellClick);
            // 
            // cbServicios
            // 
            this.cbServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.cbServicios.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cbServicios.FormattingEnabled = true;
            this.cbServicios.Location = new System.Drawing.Point(510, 16);
            this.cbServicios.Name = "cbServicios";
            this.cbServicios.Size = new System.Drawing.Size(124, 32);
            this.cbServicios.TabIndex = 7;
            this.cbServicios.Text = " Servicios";
            // 
            // panelNombreCliente
            // 
            this.panelNombreCliente.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Nombre_Cliente1;
            this.panelNombreCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelNombreCliente.Controls.Add(this.lbNombreCliente);
            this.panelNombreCliente.Location = new System.Drawing.Point(30, 9);
            this.panelNombreCliente.Name = "panelNombreCliente";
            this.panelNombreCliente.Size = new System.Drawing.Size(474, 39);
            this.panelNombreCliente.TabIndex = 10;
            // 
            // lbNombreCliente
            // 
            this.lbNombreCliente.AutoSize = true;
            this.lbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbNombreCliente.Location = new System.Drawing.Point(3, 3);
            this.lbNombreCliente.Name = "lbNombreCliente";
            this.lbNombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNombreCliente.Size = new System.Drawing.Size(202, 31);
            this.lbNombreCliente.TabIndex = 8;
            this.lbNombreCliente.Text = "Nombre Cliente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::SaRaUI.Properties.Resources.Fondo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(790, 317);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnAtrasSC);
            this.panelBottom.Controls.Add(this.btnGuardarSC);
            this.panelBottom.Controls.Add(this.btnBorrarSC);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(822, 52);
            this.panelBottom.TabIndex = 2;
            // 
            // btnAtrasSC
            // 
            this.btnAtrasSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtrasSC.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasSC.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Atras;
            this.btnAtrasSC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtrasSC.FlatAppearance.BorderSize = 0;
            this.btnAtrasSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasSC.Location = new System.Drawing.Point(14, 3);
            this.btnAtrasSC.Name = "btnAtrasSC";
            this.btnAtrasSC.Size = new System.Drawing.Size(44, 44);
            this.btnAtrasSC.TabIndex = 11;
            this.btnAtrasSC.UseVisualStyleBackColor = false;
            this.btnAtrasSC.Click += new System.EventHandler(this.btnAtrasSC_Click);
            // 
            // btnGuardarSC
            // 
            this.btnGuardarSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarSC.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarSC.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Guardar_2;
            this.btnGuardarSC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarSC.FlatAppearance.BorderSize = 0;
            this.btnGuardarSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSC.Location = new System.Drawing.Point(748, 3);
            this.btnGuardarSC.Name = "btnGuardarSC";
            this.btnGuardarSC.Size = new System.Drawing.Size(44, 44);
            this.btnGuardarSC.TabIndex = 5;
            this.btnGuardarSC.UseVisualStyleBackColor = false;
            this.btnGuardarSC.Click += new System.EventHandler(this.btnGuardarSC_Click);
            // 
            // btnBorrarSC
            // 
            this.btnBorrarSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarSC.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarSC.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Borrar;
            this.btnBorrarSC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarSC.FlatAppearance.BorderSize = 0;
            this.btnBorrarSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarSC.Location = new System.Drawing.Point(688, 3);
            this.btnBorrarSC.Name = "btnBorrarSC";
            this.btnBorrarSC.Size = new System.Drawing.Size(44, 44);
            this.btnBorrarSC.TabIndex = 4;
            this.btnBorrarSC.UseVisualStyleBackColor = false;
            this.btnBorrarSC.Click += new System.EventHandler(this.btnBorrarSC_Click);
            // 
            // lbServicios_del_Cliente
            // 
            this.lbServicios_del_Cliente.AutoSize = true;
            this.lbServicios_del_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.lbServicios_del_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServicios_del_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbServicios_del_Cliente.Location = new System.Drawing.Point(12, 19);
            this.lbServicios_del_Cliente.Name = "lbServicios_del_Cliente";
            this.lbServicios_del_Cliente.Size = new System.Drawing.Size(445, 54);
            this.lbServicios_del_Cliente.TabIndex = 0;
            this.lbServicios_del_Cliente.Text = "Servicios del Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaRaUI.Properties.Resources.Logo_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(738, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFondo.Controls.Add(this.pictureBox1);
            this.panelFondo.Controls.Add(this.lbServicios_del_Cliente);
            this.panelFondo.Controls.Add(this.panelBottom);
            this.panelFondo.Controls.Add(this.panelTablaC);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(822, 477);
            this.panelFondo.TabIndex = 4;
            // 
            // Servicios_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.panelFondo);
            this.Name = "Servicios_Cliente";
            this.Text = "Servicios_Cliente";
            this.panelTablaC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios_Cliente)).EndInit();
            this.panelNombreCliente.ResumeLayout(false);
            this.panelNombreCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTablaC;
        private System.Windows.Forms.DataGridView dgvServicios_Cliente;
        private System.Windows.Forms.ComboBox cbServicios;
        private System.Windows.Forms.Panel panelNombreCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAtrasSC;
        private System.Windows.Forms.Button btnGuardarSC;
        private System.Windows.Forms.Button btnBorrarSC;
        private System.Windows.Forms.Label lbServicios_del_Cliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.ComboBox cbEmpleados;
        public System.Windows.Forms.Label lbNombreCliente;
    }
}