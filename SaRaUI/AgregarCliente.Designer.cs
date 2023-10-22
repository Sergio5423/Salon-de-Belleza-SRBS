namespace SaRaUI
{
    partial class AgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.lblNC = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAtrasNC = new System.Windows.Forms.Button();
            this.lblIngresaDatosNC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCedula = new System.Windows.Forms.Panel();
            this.lbCedNC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardarNC = new System.Windows.Forms.Button();
            this.tbCorreoNC = new System.Windows.Forms.TextBox();
            this.tbTelefonoNC = new System.Windows.Forms.TextBox();
            this.tbCumpleañosNC = new System.Windows.Forms.TextBox();
            this.tbNombreNC = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCedulaNC = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCedula.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNC
            // 
            this.lblNC.AutoSize = true;
            this.lblNC.BackColor = System.Drawing.Color.Transparent;
            this.lblNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblNC.Location = new System.Drawing.Point(13, 19);
            this.lblNC.Name = "lblNC";
            this.lblNC.Size = new System.Drawing.Size(316, 54);
            this.lblNC.TabIndex = 1;
            this.lblNC.Text = "Nuevo Cliente";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnAtrasNC);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(822, 52);
            this.panelBottom.TabIndex = 3;
            // 
            // btnAtrasNC
            // 
            this.btnAtrasNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtrasNC.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasNC.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Atras;
            this.btnAtrasNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtrasNC.FlatAppearance.BorderSize = 0;
            this.btnAtrasNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasNC.Location = new System.Drawing.Point(14, 3);
            this.btnAtrasNC.Name = "btnAtrasNC";
            this.btnAtrasNC.Size = new System.Drawing.Size(44, 44);
            this.btnAtrasNC.TabIndex = 6;
            this.btnAtrasNC.UseVisualStyleBackColor = false;
            this.btnAtrasNC.Click += new System.EventHandler(this.btnAtrasNC_Click);
            // 
            // lblIngresaDatosNC
            // 
            this.lblIngresaDatosNC.AutoSize = true;
            this.lblIngresaDatosNC.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresaDatosNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresaDatosNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblIngresaDatosNC.Location = new System.Drawing.Point(18, 19);
            this.lblIngresaDatosNC.Name = "lblIngresaDatosNC";
            this.lblIngresaDatosNC.Size = new System.Drawing.Size(234, 31);
            this.lblIngresaDatosNC.TabIndex = 4;
            this.lblIngresaDatosNC.Text = "Ingrese sus Datos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelCedula);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(22, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 318);
            this.panel1.TabIndex = 5;
            // 
            // panelCedula
            // 
            this.panelCedula.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panelCedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCedula.Controls.Add(this.lbCedNC);
            this.panelCedula.Location = new System.Drawing.Point(24, 76);
            this.panelCedula.Name = "panelCedula";
            this.panelCedula.Size = new System.Drawing.Size(137, 34);
            this.panelCedula.TabIndex = 6;
            // 
            // lbCedNC
            // 
            this.lbCedNC.BackColor = System.Drawing.Color.Transparent;
            this.lbCedNC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCedNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbCedNC.Location = new System.Drawing.Point(0, 0);
            this.lbCedNC.Name = "lbCedNC";
            this.lbCedNC.Size = new System.Drawing.Size(137, 34);
            this.lbCedNC.TabIndex = 5;
            this.lbCedNC.Text = "Cédula";
            this.lbCedNC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo_Nuevo_Cliente;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.btnGuardarNC);
            this.panel2.Controls.Add(this.tbCorreoNC);
            this.panel2.Controls.Add(this.tbTelefonoNC);
            this.panel2.Controls.Add(this.tbCumpleañosNC);
            this.panel2.Controls.Add(this.tbNombreNC);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbCedulaNC);
            this.panel2.Controls.Add(this.lblIngresaDatosNC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 318);
            this.panel2.TabIndex = 7;
            // 
            // btnGuardarNC
            // 
            this.btnGuardarNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarNC.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarNC.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Guardar;
            this.btnGuardarNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarNC.FlatAppearance.BorderSize = 0;
            this.btnGuardarNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNC.Location = new System.Drawing.Point(720, 265);
            this.btnGuardarNC.Name = "btnGuardarNC";
            this.btnGuardarNC.Size = new System.Drawing.Size(44, 44);
            this.btnGuardarNC.TabIndex = 12;
            this.btnGuardarNC.UseVisualStyleBackColor = false;
            // 
            // tbCorreoNC
            // 
            this.tbCorreoNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCorreoNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbCorreoNC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorreoNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreoNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbCorreoNC.Location = new System.Drawing.Point(554, 165);
            this.tbCorreoNC.Name = "tbCorreoNC";
            this.tbCorreoNC.Size = new System.Drawing.Size(201, 29);
            this.tbCorreoNC.TabIndex = 11;
            // 
            // tbTelefonoNC
            // 
            this.tbTelefonoNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbTelefonoNC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelefonoNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefonoNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbTelefonoNC.Location = new System.Drawing.Point(176, 165);
            this.tbTelefonoNC.Name = "tbTelefonoNC";
            this.tbTelefonoNC.Size = new System.Drawing.Size(168, 29);
            this.tbTelefonoNC.TabIndex = 10;
            // 
            // tbCumpleañosNC
            // 
            this.tbCumpleañosNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbCumpleañosNC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCumpleañosNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCumpleañosNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbCumpleañosNC.Location = new System.Drawing.Point(176, 250);
            this.tbCumpleañosNC.Name = "tbCumpleañosNC";
            this.tbCumpleañosNC.Size = new System.Drawing.Size(168, 29);
            this.tbCumpleañosNC.TabIndex = 9;
            // 
            // tbNombreNC
            // 
            this.tbNombreNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbNombreNC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombreNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbNombreNC.Location = new System.Drawing.Point(554, 76);
            this.tbNombreNC.Name = "tbNombreNC";
            this.tbNombreNC.Size = new System.Drawing.Size(201, 29);
            this.tbNombreNC.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(398, 160);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 34);
            this.panel6.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(24, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 34);
            this.panel5.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teléfono";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(24, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 34);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cumpleaños";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(398, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 34);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCedulaNC
            // 
            this.tbCedulaNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbCedulaNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedulaNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbCedulaNC.Location = new System.Drawing.Point(176, 78);
            this.tbCedulaNC.Name = "tbCedulaNC";
            this.tbCedulaNC.Size = new System.Drawing.Size(168, 29);
            this.tbCedulaNC.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SaRaUI.Properties.Resources.Logo_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(731, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.lblNC);
            this.DoubleBuffered = true;
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.panelBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCedula.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNC;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAtrasNC;
        private System.Windows.Forms.Label lblIngresaDatosNC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCedNC;
        private System.Windows.Forms.Panel panelCedula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbCedulaNC;
        private System.Windows.Forms.TextBox tbCorreoNC;
        private System.Windows.Forms.TextBox tbTelefonoNC;
        private System.Windows.Forms.TextBox tbCumpleañosNC;
        private System.Windows.Forms.TextBox tbNombreNC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarNC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}