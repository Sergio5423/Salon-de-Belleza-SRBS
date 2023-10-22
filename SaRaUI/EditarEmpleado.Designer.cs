namespace SaRaUI
{
    partial class EditarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEmpleado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAtrasEC = new System.Windows.Forms.Button();
            this.lbEditarEmpleado = new System.Windows.Forms.Label();
            this.lbIngreseDatosEm = new System.Windows.Forms.Label();
            this.btnGuardarEC = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCedula = new System.Windows.Forms.Panel();
            this.lbCedEm = new System.Windows.Forms.Label();
            this.tbTelefonoEm = new System.Windows.Forms.TextBox();
            this.tbNombreEm = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCedulaEm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCedula.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.pictureBox1.TabIndex = 13;
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
            this.panel1.Location = new System.Drawing.Point(22, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 318);
            this.panel1.TabIndex = 12;
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
            this.panelBottom.TabIndex = 11;
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
            // lbEditarEmpleado
            // 
            this.lbEditarEmpleado.AutoSize = true;
            this.lbEditarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lbEditarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbEditarEmpleado.Location = new System.Drawing.Point(13, 4);
            this.lbEditarEmpleado.Name = "lbEditarEmpleado";
            this.lbEditarEmpleado.Size = new System.Drawing.Size(367, 54);
            this.lbEditarEmpleado.TabIndex = 10;
            this.lbEditarEmpleado.Text = "Editar Empleado";
            // 
            // lbIngreseDatosEm
            // 
            this.lbIngreseDatosEm.AutoSize = true;
            this.lbIngreseDatosEm.BackColor = System.Drawing.Color.Transparent;
            this.lbIngreseDatosEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseDatosEm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbIngreseDatosEm.Location = new System.Drawing.Point(18, 19);
            this.lbIngreseDatosEm.Name = "lbIngreseDatosEm";
            this.lbIngreseDatosEm.Size = new System.Drawing.Size(234, 31);
            this.lbIngreseDatosEm.TabIndex = 4;
            this.lbIngreseDatosEm.Text = "Ingrese sus Datos";
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
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panelCedula);
            this.panel2.Controls.Add(this.tbTelefonoEm);
            this.panel2.Controls.Add(this.tbNombreEm);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbCedulaEm);
            this.panel2.Controls.Add(this.btnGuardarEC);
            this.panel2.Controls.Add(this.lbIngreseDatosEm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.panelCedula.Location = new System.Drawing.Point(24, 111);
            this.panelCedula.Name = "panelCedula";
            this.panelCedula.Size = new System.Drawing.Size(137, 34);
            this.panelCedula.TabIndex = 14;
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
            // tbTelefonoEm
            // 
            this.tbTelefonoEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbTelefonoEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelefonoEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefonoEm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbTelefonoEm.Location = new System.Drawing.Point(176, 231);
            this.tbTelefonoEm.Name = "tbTelefonoEm";
            this.tbTelefonoEm.Size = new System.Drawing.Size(168, 29);
            this.tbTelefonoEm.TabIndex = 18;
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
            this.tbNombreEm.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(24, 226);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 34);
            this.panel5.TabIndex = 15;
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
            this.panel3.Location = new System.Drawing.Point(397, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 34);
            this.panel3.TabIndex = 16;
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
            this.tbCedulaEm.TabIndex = 13;
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.lbEditarEmpleado);
            this.Name = "EditarEmpleado";
            this.Text = "EditarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCedula.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAtrasEC;
        private System.Windows.Forms.Label lbEditarEmpleado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardarEC;
        private System.Windows.Forms.Label lbIngreseDatosEm;
        private System.Windows.Forms.Panel panelCedula;
        private System.Windows.Forms.Label lbCedEm;
        private System.Windows.Forms.TextBox tbTelefonoEm;
        private System.Windows.Forms.TextBox tbNombreEm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCedulaEm;
    }
}