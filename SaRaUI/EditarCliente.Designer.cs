namespace SaRaUI
{
    partial class EditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCedula = new System.Windows.Forms.Panel();
            this.lbCedEC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardarEC = new System.Windows.Forms.Button();
            this.tbCorreoEC = new System.Windows.Forms.TextBox();
            this.tbTelEC = new System.Windows.Forms.TextBox();
            this.tbNomEC = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbCorreoEC = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTelEC = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbCumpEC = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNombEC = new System.Windows.Forms.Label();
            this.tbCedEC = new System.Windows.Forms.TextBox();
            this.lbIngreseDatosEC = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAtrasEC = new System.Windows.Forms.Button();
            this.lblEC = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpCumpleañosEC = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panelCedula.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(22, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 318);
            this.panel1.TabIndex = 8;
            // 
            // panelCedula
            // 
            this.panelCedula.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panelCedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCedula.Controls.Add(this.lbCedEC);
            this.panelCedula.Location = new System.Drawing.Point(24, 76);
            this.panelCedula.Name = "panelCedula";
            this.panelCedula.Size = new System.Drawing.Size(137, 34);
            this.panelCedula.TabIndex = 6;
            // 
            // lbCedEC
            // 
            this.lbCedEC.BackColor = System.Drawing.Color.Transparent;
            this.lbCedEC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCedEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbCedEC.Location = new System.Drawing.Point(0, 0);
            this.lbCedEC.Name = "lbCedEC";
            this.lbCedEC.Size = new System.Drawing.Size(137, 34);
            this.lbCedEC.TabIndex = 5;
            this.lbCedEC.Text = "Cédula";
            this.lbCedEC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo_Editar_Cliente;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.dtpCumpleañosEC);
            this.panel2.Controls.Add(this.btnGuardarEC);
            this.panel2.Controls.Add(this.tbCorreoEC);
            this.panel2.Controls.Add(this.tbTelEC);
            this.panel2.Controls.Add(this.tbNomEC);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbCedEC);
            this.panel2.Controls.Add(this.lbIngreseDatosEC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 318);
            this.panel2.TabIndex = 7;
            // 
            // btnGuardarEC
            // 
            this.btnGuardarEC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEC.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarEC.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Guardar;
            this.btnGuardarEC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarEC.FlatAppearance.BorderSize = 0;
            this.btnGuardarEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEC.Location = new System.Drawing.Point(720, 265);
            this.btnGuardarEC.Name = "btnGuardarEC";
            this.btnGuardarEC.Size = new System.Drawing.Size(44, 44);
            this.btnGuardarEC.TabIndex = 12;
            this.btnGuardarEC.UseVisualStyleBackColor = false;
            this.btnGuardarEC.Click += new System.EventHandler(this.btnGuardarEC_Click);
            // 
            // tbCorreoEC
            // 
            this.tbCorreoEC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCorreoEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbCorreoEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCorreoEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreoEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbCorreoEC.Location = new System.Drawing.Point(554, 165);
            this.tbCorreoEC.Name = "tbCorreoEC";
            this.tbCorreoEC.Size = new System.Drawing.Size(201, 29);
            this.tbCorreoEC.TabIndex = 11;
            // 
            // tbTelEC
            // 
            this.tbTelEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbTelEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbTelEC.Location = new System.Drawing.Point(176, 165);
            this.tbTelEC.Name = "tbTelEC";
            this.tbTelEC.Size = new System.Drawing.Size(168, 29);
            this.tbTelEC.TabIndex = 10;
            // 
            // tbNomEC
            // 
            this.tbNomEC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbNomEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbNomEC.Location = new System.Drawing.Point(554, 76);
            this.tbNomEC.Name = "tbNomEC";
            this.tbNomEC.Size = new System.Drawing.Size(201, 29);
            this.tbNomEC.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.lbCorreoEC);
            this.panel6.Location = new System.Drawing.Point(398, 160);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 34);
            this.panel6.TabIndex = 7;
            // 
            // lbCorreoEC
            // 
            this.lbCorreoEC.BackColor = System.Drawing.Color.Transparent;
            this.lbCorreoEC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCorreoEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreoEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbCorreoEC.Location = new System.Drawing.Point(0, 0);
            this.lbCorreoEC.Name = "lbCorreoEC";
            this.lbCorreoEC.Size = new System.Drawing.Size(137, 34);
            this.lbCorreoEC.TabIndex = 5;
            this.lbCorreoEC.Text = "Correo";
            this.lbCorreoEC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lbTelEC);
            this.panel5.Location = new System.Drawing.Point(24, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 34);
            this.panel5.TabIndex = 7;
            // 
            // lbTelEC
            // 
            this.lbTelEC.BackColor = System.Drawing.Color.Transparent;
            this.lbTelEC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTelEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbTelEC.Location = new System.Drawing.Point(0, 0);
            this.lbTelEC.Name = "lbTelEC";
            this.lbTelEC.Size = new System.Drawing.Size(137, 34);
            this.lbTelEC.TabIndex = 5;
            this.lbTelEC.Text = "Teléfono";
            this.lbTelEC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lbCumpEC);
            this.panel4.Location = new System.Drawing.Point(24, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 34);
            this.panel4.TabIndex = 7;
            // 
            // lbCumpEC
            // 
            this.lbCumpEC.BackColor = System.Drawing.Color.Transparent;
            this.lbCumpEC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCumpEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCumpEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbCumpEC.Location = new System.Drawing.Point(0, 0);
            this.lbCumpEC.Name = "lbCumpEC";
            this.lbCumpEC.Size = new System.Drawing.Size(137, 34);
            this.lbCumpEC.TabIndex = 5;
            this.lbCumpEC.Text = "Cumpleaños";
            this.lbCumpEC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbNombEC);
            this.panel3.Location = new System.Drawing.Point(398, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 34);
            this.panel3.TabIndex = 7;
            // 
            // lbNombEC
            // 
            this.lbNombEC.BackColor = System.Drawing.Color.Transparent;
            this.lbNombEC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNombEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbNombEC.Location = new System.Drawing.Point(0, 0);
            this.lbNombEC.Name = "lbNombEC";
            this.lbNombEC.Size = new System.Drawing.Size(137, 34);
            this.lbNombEC.TabIndex = 5;
            this.lbNombEC.Text = "Nombre";
            this.lbNombEC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCedEC
            // 
            this.tbCedEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbCedEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbCedEC.Location = new System.Drawing.Point(176, 78);
            this.tbCedEC.Name = "tbCedEC";
            this.tbCedEC.Size = new System.Drawing.Size(168, 29);
            this.tbCedEC.TabIndex = 5;
            // 
            // lbIngreseDatosEC
            // 
            this.lbIngreseDatosEC.AutoSize = true;
            this.lbIngreseDatosEC.BackColor = System.Drawing.Color.Transparent;
            this.lbIngreseDatosEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseDatosEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbIngreseDatosEC.Location = new System.Drawing.Point(18, 19);
            this.lbIngreseDatosEC.Name = "lbIngreseDatosEC";
            this.lbIngreseDatosEC.Size = new System.Drawing.Size(234, 31);
            this.lbIngreseDatosEC.TabIndex = 4;
            this.lbIngreseDatosEC.Text = "Ingrese sus Datos";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnAtrasEC);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(822, 52);
            this.panelBottom.TabIndex = 7;
            // 
            // btnAtrasEC
            // 
            this.btnAtrasEC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtrasEC.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasEC.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Atras;
            this.btnAtrasEC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtrasEC.FlatAppearance.BorderSize = 0;
            this.btnAtrasEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasEC.Location = new System.Drawing.Point(14, 3);
            this.btnAtrasEC.Name = "btnAtrasEC";
            this.btnAtrasEC.Size = new System.Drawing.Size(44, 44);
            this.btnAtrasEC.TabIndex = 6;
            this.btnAtrasEC.UseVisualStyleBackColor = false;
            this.btnAtrasEC.Click += new System.EventHandler(this.btnAtrasEC_Click);
            // 
            // lblEC
            // 
            this.lblEC.AutoSize = true;
            this.lblEC.BackColor = System.Drawing.Color.Transparent;
            this.lblEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblEC.Location = new System.Drawing.Point(13, 9);
            this.lblEC.Name = "lblEC";
            this.lblEC.Size = new System.Drawing.Size(302, 54);
            this.lblEC.TabIndex = 6;
            this.lblEC.Text = "Editar Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SaRaUI.Properties.Resources.Logo_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(731, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dtpCumpleañosEC
            // 
            this.dtpCumpleañosEC.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dtpCumpleañosEC.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.dtpCumpleañosEC.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.dtpCumpleañosEC.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dtpCumpleañosEC.Location = new System.Drawing.Point(176, 252);
            this.dtpCumpleañosEC.Name = "dtpCumpleañosEC";
            this.dtpCumpleañosEC.Size = new System.Drawing.Size(200, 20);
            this.dtpCumpleañosEC.TabIndex = 13;
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.lblEC);
            this.DoubleBuffered = true;
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            this.panel1.ResumeLayout(false);
            this.panelCedula.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCedula;
        private System.Windows.Forms.Label lbCedEC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardarEC;
        private System.Windows.Forms.TextBox tbCorreoEC;
        private System.Windows.Forms.TextBox tbTelEC;
        private System.Windows.Forms.TextBox tbNomEC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbCorreoEC;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTelEC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbCumpEC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbNombEC;
        private System.Windows.Forms.TextBox tbCedEC;
        private System.Windows.Forms.Label lbIngreseDatosEC;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAtrasEC;
        private System.Windows.Forms.Label lblEC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpCumpleañosEC;
    }
}