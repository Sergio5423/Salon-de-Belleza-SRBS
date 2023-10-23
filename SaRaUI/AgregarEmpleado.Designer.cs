namespace SaRaUI
{
    partial class AgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCedula = new System.Windows.Forms.Panel();
            this.lbCedEm = new System.Windows.Forms.Label();
            this.btnGuardarEm = new System.Windows.Forms.Button();
            this.tbTelefonoEm = new System.Windows.Forms.TextBox();
            this.tbNombreEm = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCedulaEm = new System.Windows.Forms.TextBox();
            this.lbIngreseSusDatos = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAtrasEm = new System.Windows.Forms.Button();
            this.lbNuevoEmpleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCedula.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SaRaUI.Properties.Resources.Logo_pequeño;
            this.pictureBox1.Location = new System.Drawing.Point(731, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(22, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 318);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo_Nuevo_Empleado;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.panelCedula);
            this.panel2.Controls.Add(this.btnGuardarEm);
            this.panel2.Controls.Add(this.tbTelefonoEm);
            this.panel2.Controls.Add(this.tbNombreEm);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbCedulaEm);
            this.panel2.Controls.Add(this.lbIngreseSusDatos);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 318);
            this.panel2.TabIndex = 7;
            // 
            // panelCedula
            // 
            this.panelCedula.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panelCedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCedula.Controls.Add(this.lbCedEm);
            this.panelCedula.Location = new System.Drawing.Point(24, 114);
            this.panelCedula.Name = "panelCedula";
            this.panelCedula.Size = new System.Drawing.Size(137, 34);
            this.panelCedula.TabIndex = 6;
            // 
            // lbCedEm
            // 
            this.lbCedEm.BackColor = System.Drawing.Color.Transparent;
            this.lbCedEm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCedEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedEm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbCedEm.Location = new System.Drawing.Point(0, 0);
            this.lbCedEm.Name = "lbCedEm";
            this.lbCedEm.Size = new System.Drawing.Size(137, 34);
            this.lbCedEm.TabIndex = 5;
            this.lbCedEm.Text = "Cédula";
            this.lbCedEm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardarEm
            // 
            this.btnGuardarEm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEm.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarEm.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Guardar;
            this.btnGuardarEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarEm.FlatAppearance.BorderSize = 0;
            this.btnGuardarEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEm.Location = new System.Drawing.Point(720, 265);
            this.btnGuardarEm.Name = "btnGuardarEm";
            this.btnGuardarEm.Size = new System.Drawing.Size(44, 44);
            this.btnGuardarEm.TabIndex = 12;
            this.btnGuardarEm.UseVisualStyleBackColor = false;
            this.btnGuardarEm.Click += new System.EventHandler(this.btnGuardarEm_Click);
            // 
            // tbTelefonoEm
            // 
            this.tbTelefonoEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbTelefonoEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelefonoEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefonoEm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbTelefonoEm.Location = new System.Drawing.Point(176, 231);
            this.tbTelefonoEm.Name = "tbTelefonoEm";
            this.tbTelefonoEm.Size = new System.Drawing.Size(168, 29);
            this.tbTelefonoEm.TabIndex = 10;
            // 
            // tbNombreEm
            // 
            this.tbNombreEm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbNombreEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombreEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreEm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbNombreEm.Location = new System.Drawing.Point(554, 117);
            this.tbNombreEm.Name = "tbNombreEm";
            this.tbNombreEm.Size = new System.Drawing.Size(201, 29);
            this.tbNombreEm.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(24, 228);
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(398, 114);
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
            // tbCedulaEm
            // 
            this.tbCedulaEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbCedulaEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedulaEm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbCedulaEm.Location = new System.Drawing.Point(176, 116);
            this.tbCedulaEm.Name = "tbCedulaEm";
            this.tbCedulaEm.Size = new System.Drawing.Size(168, 29);
            this.tbCedulaEm.TabIndex = 5;
            // 
            // lbIngreseSusDatos
            // 
            this.lbIngreseSusDatos.AutoSize = true;
            this.lbIngreseSusDatos.BackColor = System.Drawing.Color.Transparent;
            this.lbIngreseSusDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseSusDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbIngreseSusDatos.Location = new System.Drawing.Point(18, 19);
            this.lbIngreseSusDatos.Name = "lbIngreseSusDatos";
            this.lbIngreseSusDatos.Size = new System.Drawing.Size(234, 31);
            this.lbIngreseSusDatos.TabIndex = 4;
            this.lbIngreseSusDatos.Text = "Ingrese sus Datos";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnAtrasEm);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(822, 52);
            this.panelBottom.TabIndex = 8;
            // 
            // btnAtrasEm
            // 
            this.btnAtrasEm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtrasEm.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasEm.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Atras;
            this.btnAtrasEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtrasEm.FlatAppearance.BorderSize = 0;
            this.btnAtrasEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasEm.Location = new System.Drawing.Point(14, 3);
            this.btnAtrasEm.Name = "btnAtrasEm";
            this.btnAtrasEm.Size = new System.Drawing.Size(44, 44);
            this.btnAtrasEm.TabIndex = 6;
            this.btnAtrasEm.UseVisualStyleBackColor = false;
            this.btnAtrasEm.Click += new System.EventHandler(this.btnAtrasEm_Click);
            // 
            // lbNuevoEmpleado
            // 
            this.lbNuevoEmpleado.AutoSize = true;
            this.lbNuevoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbNuevoEmpleado.Location = new System.Drawing.Point(13, 15);
            this.lbNuevoEmpleado.Name = "lbNuevoEmpleado";
            this.lbNuevoEmpleado.Size = new System.Drawing.Size(381, 54);
            this.lbNuevoEmpleado.TabIndex = 7;
            this.lbNuevoEmpleado.Text = "Nuevo Empleado";
            // 
            // AgregarEmpleado
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
            this.Controls.Add(this.lbNuevoEmpleado);
            this.DoubleBuffered = true;
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCedula.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCedula;
        private System.Windows.Forms.Label lbCedEm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardarEm;
        private System.Windows.Forms.TextBox tbTelefonoEm;
        private System.Windows.Forms.TextBox tbNombreEm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCedulaEm;
        private System.Windows.Forms.Label lbIngreseSusDatos;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAtrasEm;
        private System.Windows.Forms.Label lbNuevoEmpleado;
    }
}