namespace SaRaUI
{
    partial class Clientes
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
            this.lblClientes = new System.Windows.Forms.Label();
            this.panelTablaC = new System.Windows.Forms.Panel();
            this.cbOrdenarClientes = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tbBuscarClientes = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnServiciosClientes = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.btnBorrarClientes = new System.Windows.Forms.Button();
            this.btnEditarClientes = new System.Windows.Forms.Button();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTablaC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblClientes.Location = new System.Drawing.Point(12, 19);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(192, 54);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Clientes";
            // 
            // panelTablaC
            // 
            this.panelTablaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTablaC.BackColor = System.Drawing.Color.Transparent;
            this.panelTablaC.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo_Tablas;
            this.panelTablaC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTablaC.Controls.Add(this.cbOrdenarClientes);
            this.panelTablaC.Controls.Add(this.button4);
            this.panelTablaC.Controls.Add(this.tbBuscarClientes);
            this.panelTablaC.Controls.Add(this.dgvClientes);
            this.panelTablaC.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTablaC.Location = new System.Drawing.Point(15, 90);
            this.panelTablaC.Name = "panelTablaC";
            this.panelTablaC.Size = new System.Drawing.Size(790, 317);
            this.panelTablaC.TabIndex = 1;
            // 
            // cbOrdenarClientes
            // 
            this.cbOrdenarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.cbOrdenarClientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbOrdenarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cbOrdenarClientes.FormattingEnabled = true;
            this.cbOrdenarClientes.Location = new System.Drawing.Point(30, 16);
            this.cbOrdenarClientes.Name = "cbOrdenarClientes";
            this.cbOrdenarClientes.Size = new System.Drawing.Size(144, 32);
            this.cbOrdenarClientes.TabIndex = 7;
            this.cbOrdenarClientes.Text = "  Ordenar por";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Buscar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(723, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 35);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // tbBuscarClientes
            // 
            this.tbBuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbBuscarClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbBuscarClientes.Location = new System.Drawing.Point(530, 16);
            this.tbBuscarClientes.Name = "tbBuscarClientes";
            this.tbBuscarClientes.Size = new System.Drawing.Size(187, 29);
            this.tbBuscarClientes.TabIndex = 1;
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(183)))), ((int)(((byte)(161)))));
            this.dgvClientes.Location = new System.Drawing.Point(30, 61);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(730, 226);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnServiciosClientes
            // 
            this.btnServiciosClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiciosClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnServiciosClientes.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_ServiciosC;
            this.btnServiciosClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServiciosClientes.FlatAppearance.BorderSize = 0;
            this.btnServiciosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiciosClientes.Location = new System.Drawing.Point(748, 3);
            this.btnServiciosClientes.Name = "btnServiciosClientes";
            this.btnServiciosClientes.Size = new System.Drawing.Size(44, 44);
            this.btnServiciosClientes.TabIndex = 2;
            this.btnServiciosClientes.UseVisualStyleBackColor = false;
            this.btnServiciosClientes.Click += new System.EventHandler(this.btnServiciosClientes_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnAgregarClientes);
            this.panelBottom.Controls.Add(this.btnBorrarClientes);
            this.panelBottom.Controls.Add(this.btnEditarClientes);
            this.panelBottom.Controls.Add(this.btnServiciosClientes);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(822, 52);
            this.panelBottom.TabIndex = 2;
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarClientes.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Agregar;
            this.btnAgregarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarClientes.FlatAppearance.BorderSize = 0;
            this.btnAgregarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarClientes.Location = new System.Drawing.Point(568, 3);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(44, 44);
            this.btnAgregarClientes.TabIndex = 5;
            this.btnAgregarClientes.UseVisualStyleBackColor = false;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // btnBorrarClientes
            // 
            this.btnBorrarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarClientes.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Borrar;
            this.btnBorrarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarClientes.FlatAppearance.BorderSize = 0;
            this.btnBorrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarClientes.Location = new System.Drawing.Point(628, 3);
            this.btnBorrarClientes.Name = "btnBorrarClientes";
            this.btnBorrarClientes.Size = new System.Drawing.Size(44, 44);
            this.btnBorrarClientes.TabIndex = 4;
            this.btnBorrarClientes.UseVisualStyleBackColor = false;
            // 
            // btnEditarClientes
            // 
            this.btnEditarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarClientes.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Editar;
            this.btnEditarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarClientes.FlatAppearance.BorderSize = 0;
            this.btnEditarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarClientes.Location = new System.Drawing.Point(688, 3);
            this.btnEditarClientes.Name = "btnEditarClientes";
            this.btnEditarClientes.Size = new System.Drawing.Size(44, 44);
            this.btnEditarClientes.TabIndex = 3;
            this.btnEditarClientes.UseVisualStyleBackColor = false;
            this.btnEditarClientes.Click += new System.EventHandler(this.btnEditarClientes_Click);
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.Transparent;
            this.panelFondo.Controls.Add(this.pictureBox1);
            this.panelFondo.Controls.Add(this.lblClientes);
            this.panelFondo.Controls.Add(this.panelBottom);
            this.panelFondo.Controls.Add(this.panelTablaC);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(822, 477);
            this.panelFondo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaRaUI.Properties.Resources.Logo_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(738, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.panelFondo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.panelTablaC.ResumeLayout(false);
            this.panelTablaC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Panel panelTablaC;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnServiciosClientes;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.Button btnBorrarClientes;
        private System.Windows.Forms.Button btnEditarClientes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbBuscarClientes;
        private System.Windows.Forms.ComboBox cbOrdenarClientes;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}