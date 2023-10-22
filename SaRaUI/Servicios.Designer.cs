namespace SaRaUI
{
    partial class Servicios
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
            this.lbServicios = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAgregarServicios = new System.Windows.Forms.Button();
            this.btnBorrarServicios = new System.Windows.Forms.Button();
            this.panelTablaC = new System.Windows.Forms.Panel();
            this.cbOrdenarServicios = new System.Windows.Forms.ComboBox();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.tbBuscarServicio = new System.Windows.Forms.TextBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTablaC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.panelFondo.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo;
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFondo.Controls.Add(this.pictureBox1);
            this.panelFondo.Controls.Add(this.lbServicios);
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
            // lbServicios
            // 
            this.lbServicios.AutoSize = true;
            this.lbServicios.BackColor = System.Drawing.Color.Transparent;
            this.lbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbServicios.Location = new System.Drawing.Point(12, 19);
            this.lbServicios.Name = "lbServicios";
            this.lbServicios.Size = new System.Drawing.Size(214, 54);
            this.lbServicios.TabIndex = 0;
            this.lbServicios.Text = "Servicios";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnAgregarServicios);
            this.panelBottom.Controls.Add(this.btnBorrarServicios);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(822, 52);
            this.panelBottom.TabIndex = 2;
            // 
            // btnAgregarServicios
            // 
            this.btnAgregarServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarServicios.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarServicios.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Agregar;
            this.btnAgregarServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarServicios.FlatAppearance.BorderSize = 0;
            this.btnAgregarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicios.Location = new System.Drawing.Point(688, 3);
            this.btnAgregarServicios.Name = "btnAgregarServicios";
            this.btnAgregarServicios.Size = new System.Drawing.Size(44, 44);
            this.btnAgregarServicios.TabIndex = 5;
            this.btnAgregarServicios.UseVisualStyleBackColor = false;
            this.btnAgregarServicios.Click += new System.EventHandler(this.btnAgregarServicios_Click);
            // 
            // btnBorrarServicios
            // 
            this.btnBorrarServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarServicios.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarServicios.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Borrar;
            this.btnBorrarServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarServicios.FlatAppearance.BorderSize = 0;
            this.btnBorrarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarServicios.Location = new System.Drawing.Point(748, 3);
            this.btnBorrarServicios.Name = "btnBorrarServicios";
            this.btnBorrarServicios.Size = new System.Drawing.Size(44, 44);
            this.btnBorrarServicios.TabIndex = 4;
            this.btnBorrarServicios.UseVisualStyleBackColor = false;
            // 
            // panelTablaC
            // 
            this.panelTablaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTablaC.BackColor = System.Drawing.Color.Transparent;
            this.panelTablaC.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo_Tablas;
            this.panelTablaC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTablaC.Controls.Add(this.cbOrdenarServicios);
            this.panelTablaC.Controls.Add(this.btnBuscarServicio);
            this.panelTablaC.Controls.Add(this.tbBuscarServicio);
            this.panelTablaC.Controls.Add(this.dgvServicios);
            this.panelTablaC.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTablaC.Location = new System.Drawing.Point(15, 90);
            this.panelTablaC.Name = "panelTablaC";
            this.panelTablaC.Size = new System.Drawing.Size(790, 317);
            this.panelTablaC.TabIndex = 1;
            // 
            // cbOrdenarServicios
            // 
            this.cbOrdenarServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.cbOrdenarServicios.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbOrdenarServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cbOrdenarServicios.FormattingEnabled = true;
            this.cbOrdenarServicios.Location = new System.Drawing.Point(30, 16);
            this.cbOrdenarServicios.Name = "cbOrdenarServicios";
            this.cbOrdenarServicios.Size = new System.Drawing.Size(144, 32);
            this.cbOrdenarServicios.TabIndex = 7;
            this.cbOrdenarServicios.Text = "  Ordenar por";
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarServicio.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarServicio.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Buscar;
            this.btnBuscarServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarServicio.FlatAppearance.BorderSize = 0;
            this.btnBuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarServicio.Location = new System.Drawing.Point(723, 13);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(37, 35);
            this.btnBuscarServicio.TabIndex = 6;
            this.btnBuscarServicio.UseVisualStyleBackColor = false;
            // 
            // tbBuscarServicio
            // 
            this.tbBuscarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbBuscarServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbBuscarServicio.Location = new System.Drawing.Point(530, 16);
            this.tbBuscarServicio.Name = "tbBuscarServicio";
            this.tbBuscarServicio.Size = new System.Drawing.Size(187, 29);
            this.tbBuscarServicio.TabIndex = 1;
            // 
            // dgvServicios
            // 
            this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(183)))), ((int)(((byte)(161)))));
            this.dgvServicios.Location = new System.Drawing.Point(30, 61);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(730, 226);
            this.dgvServicios.TabIndex = 0;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.panelFondo);
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelTablaC.ResumeLayout(false);
            this.panelTablaC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbServicios;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAgregarServicios;
        private System.Windows.Forms.Button btnBorrarServicios;
        private System.Windows.Forms.Panel panelTablaC;
        private System.Windows.Forms.ComboBox cbOrdenarServicios;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.TextBox tbBuscarServicio;
        private System.Windows.Forms.DataGridView dgvServicios;
    }
}