namespace SaRaUI
{
    partial class AgregarServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarServicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCedula = new System.Windows.Forms.Panel();
            this.lbNombreServ = new System.Windows.Forms.Label();
            this.btnGuardarServ = new System.Windows.Forms.Button();
            this.tbRegresoServ = new System.Windows.Forms.TextBox();
            this.tbValorServ = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbRegresoServ = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbValorServ = new System.Windows.Forms.Label();
            this.tbNombreServ = new System.Windows.Forms.TextBox();
            this.lbIngreseElServicio = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAtrasServ = new System.Windows.Forms.Button();
            this.lbNuevoServicio = new System.Windows.Forms.Label();
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
            this.pictureBox1.Location = new System.Drawing.Point(731, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
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
            this.panel1.Location = new System.Drawing.Point(22, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 318);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo_Agregar_Servicio;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.panelCedula);
            this.panel2.Controls.Add(this.btnGuardarServ);
            this.panel2.Controls.Add(this.tbRegresoServ);
            this.panel2.Controls.Add(this.tbValorServ);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbNombreServ);
            this.panel2.Controls.Add(this.lbIngreseElServicio);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 318);
            this.panel2.TabIndex = 7;
            // 
            // panelCedula
            // 
            this.panelCedula.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panelCedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCedula.Controls.Add(this.lbNombreServ);
            this.panelCedula.Location = new System.Drawing.Point(24, 114);
            this.panelCedula.Name = "panelCedula";
            this.panelCedula.Size = new System.Drawing.Size(137, 34);
            this.panelCedula.TabIndex = 6;
            // 
            // lbNombreServ
            // 
            this.lbNombreServ.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNombreServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbNombreServ.Location = new System.Drawing.Point(0, 0);
            this.lbNombreServ.Name = "lbNombreServ";
            this.lbNombreServ.Size = new System.Drawing.Size(137, 34);
            this.lbNombreServ.TabIndex = 5;
            this.lbNombreServ.Text = "Nombre";
            this.lbNombreServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardarServ
            // 
            this.btnGuardarServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarServ.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarServ.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Guardar;
            this.btnGuardarServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarServ.FlatAppearance.BorderSize = 0;
            this.btnGuardarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarServ.Location = new System.Drawing.Point(720, 265);
            this.btnGuardarServ.Name = "btnGuardarServ";
            this.btnGuardarServ.Size = new System.Drawing.Size(44, 44);
            this.btnGuardarServ.TabIndex = 12;
            this.btnGuardarServ.UseVisualStyleBackColor = false;
            // 
            // tbRegresoServ
            // 
            this.tbRegresoServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbRegresoServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegresoServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegresoServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbRegresoServ.Location = new System.Drawing.Point(176, 231);
            this.tbRegresoServ.Name = "tbRegresoServ";
            this.tbRegresoServ.Size = new System.Drawing.Size(168, 29);
            this.tbRegresoServ.TabIndex = 10;
            // 
            // tbValorServ
            // 
            this.tbValorServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbValorServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbValorServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbValorServ.Location = new System.Drawing.Point(554, 117);
            this.tbValorServ.Name = "tbValorServ";
            this.tbValorServ.Size = new System.Drawing.Size(201, 29);
            this.tbValorServ.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lbRegresoServ);
            this.panel5.Location = new System.Drawing.Point(24, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 34);
            this.panel5.TabIndex = 7;
            // 
            // lbRegresoServ
            // 
            this.lbRegresoServ.BackColor = System.Drawing.Color.Transparent;
            this.lbRegresoServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRegresoServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegresoServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbRegresoServ.Location = new System.Drawing.Point(0, 0);
            this.lbRegresoServ.Name = "lbRegresoServ";
            this.lbRegresoServ.Size = new System.Drawing.Size(137, 34);
            this.lbRegresoServ.TabIndex = 5;
            this.lbRegresoServ.Text = "Regreso";
            this.lbRegresoServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::SaRaUI.Properties.Resources.Panel_Campos;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbValorServ);
            this.panel3.Location = new System.Drawing.Point(398, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 34);
            this.panel3.TabIndex = 7;
            // 
            // lbValorServ
            // 
            this.lbValorServ.BackColor = System.Drawing.Color.Transparent;
            this.lbValorServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbValorServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbValorServ.Location = new System.Drawing.Point(0, 0);
            this.lbValorServ.Name = "lbValorServ";
            this.lbValorServ.Size = new System.Drawing.Size(137, 34);
            this.lbValorServ.TabIndex = 5;
            this.lbValorServ.Text = "Valor";
            this.lbValorServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombreServ
            // 
            this.tbNombreServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbNombreServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreServ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbNombreServ.Location = new System.Drawing.Point(176, 116);
            this.tbNombreServ.Name = "tbNombreServ";
            this.tbNombreServ.Size = new System.Drawing.Size(168, 29);
            this.tbNombreServ.TabIndex = 5;
            // 
            // lbIngreseElServicio
            // 
            this.lbIngreseElServicio.AutoSize = true;
            this.lbIngreseElServicio.BackColor = System.Drawing.Color.Transparent;
            this.lbIngreseElServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngreseElServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbIngreseElServicio.Location = new System.Drawing.Point(18, 19);
            this.lbIngreseElServicio.Name = "lbIngreseElServicio";
            this.lbIngreseElServicio.Size = new System.Drawing.Size(237, 31);
            this.lbIngreseElServicio.TabIndex = 4;
            this.lbIngreseElServicio.Text = "Ingrese el Servicio";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnAtrasServ);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(822, 52);
            this.panelBottom.TabIndex = 12;
            // 
            // btnAtrasServ
            // 
            this.btnAtrasServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtrasServ.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasServ.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Atras;
            this.btnAtrasServ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtrasServ.FlatAppearance.BorderSize = 0;
            this.btnAtrasServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasServ.Location = new System.Drawing.Point(14, 3);
            this.btnAtrasServ.Name = "btnAtrasServ";
            this.btnAtrasServ.Size = new System.Drawing.Size(44, 44);
            this.btnAtrasServ.TabIndex = 6;
            this.btnAtrasServ.UseVisualStyleBackColor = false;
            this.btnAtrasServ.Click += new System.EventHandler(this.btnAtrasServ_Click);
            // 
            // lbNuevoServicio
            // 
            this.lbNuevoServicio.AutoSize = true;
            this.lbNuevoServicio.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbNuevoServicio.Location = new System.Drawing.Point(13, 13);
            this.lbNuevoServicio.Name = "lbNuevoServicio";
            this.lbNuevoServicio.Size = new System.Drawing.Size(338, 54);
            this.lbNuevoServicio.TabIndex = 11;
            this.lbNuevoServicio.Text = "Nuevo Servicio";
            // 
            // AgregarServicio
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
            this.Controls.Add(this.lbNuevoServicio);
            this.DoubleBuffered = true;
            this.Name = "AgregarServicio";
            this.Text = "AgregarServicio";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCedula;
        private System.Windows.Forms.Label lbNombreServ;
        private System.Windows.Forms.Button btnGuardarServ;
        private System.Windows.Forms.TextBox tbRegresoServ;
        private System.Windows.Forms.TextBox tbValorServ;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbRegresoServ;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbValorServ;
        private System.Windows.Forms.TextBox tbNombreServ;
        private System.Windows.Forms.Label lbIngreseElServicio;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAtrasServ;
        private System.Windows.Forms.Label lbNuevoServicio;
    }
}