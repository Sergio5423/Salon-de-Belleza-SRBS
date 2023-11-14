namespace SaRaUI
{
    partial class Trabajos
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
            this.lbTrabajos = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panelTablaC = new System.Windows.Forms.Panel();
            this.cbOrdenarTrabajos = new System.Windows.Forms.ComboBox();
            this.btnBuscarTrabajos = new System.Windows.Forms.Button();
            this.tbBuscarTrabajos = new System.Windows.Forms.TextBox();
            this.dgvTrabajos = new System.Windows.Forms.DataGridView();
            this.btnBorrarTrabajos = new System.Windows.Forms.Button();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTablaC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.panelFondo.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo;
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFondo.Controls.Add(this.pictureBox1);
            this.panelFondo.Controls.Add(this.lbTrabajos);
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
            // lbTrabajos
            // 
            this.lbTrabajos.AutoSize = true;
            this.lbTrabajos.BackColor = System.Drawing.Color.Transparent;
            this.lbTrabajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrabajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbTrabajos.Location = new System.Drawing.Point(12, 19);
            this.lbTrabajos.Name = "lbTrabajos";
            this.lbTrabajos.Size = new System.Drawing.Size(206, 54);
            this.lbTrabajos.TabIndex = 0;
            this.lbTrabajos.Text = "Trabajos";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnBorrarTrabajos);
            this.panelBottom.Controls.Add(this.btnImprimir);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(822, 52);
            this.panelBottom.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Imprimir;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(748, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(44, 44);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // panelTablaC
            // 
            this.panelTablaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTablaC.BackColor = System.Drawing.Color.Transparent;
            this.panelTablaC.BackgroundImage = global::SaRaUI.Properties.Resources.Fondo_Tablas;
            this.panelTablaC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTablaC.Controls.Add(this.cbOrdenarTrabajos);
            this.panelTablaC.Controls.Add(this.btnBuscarTrabajos);
            this.panelTablaC.Controls.Add(this.tbBuscarTrabajos);
            this.panelTablaC.Controls.Add(this.dgvTrabajos);
            this.panelTablaC.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTablaC.Location = new System.Drawing.Point(15, 90);
            this.panelTablaC.Name = "panelTablaC";
            this.panelTablaC.Size = new System.Drawing.Size(790, 317);
            this.panelTablaC.TabIndex = 1;
            // 
            // cbOrdenarTrabajos
            // 
            this.cbOrdenarTrabajos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.cbOrdenarTrabajos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbOrdenarTrabajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarTrabajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cbOrdenarTrabajos.FormattingEnabled = true;
            this.cbOrdenarTrabajos.Location = new System.Drawing.Point(30, 16);
            this.cbOrdenarTrabajos.Name = "cbOrdenarTrabajos";
            this.cbOrdenarTrabajos.Size = new System.Drawing.Size(144, 32);
            this.cbOrdenarTrabajos.TabIndex = 7;
            this.cbOrdenarTrabajos.Text = "  Ordenar por";
            this.cbOrdenarTrabajos.Visible = false;
            // 
            // btnBuscarTrabajos
            // 
            this.btnBuscarTrabajos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarTrabajos.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarTrabajos.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Buscar;
            this.btnBuscarTrabajos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarTrabajos.FlatAppearance.BorderSize = 0;
            this.btnBuscarTrabajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTrabajos.Location = new System.Drawing.Point(723, 13);
            this.btnBuscarTrabajos.Name = "btnBuscarTrabajos";
            this.btnBuscarTrabajos.Size = new System.Drawing.Size(37, 35);
            this.btnBuscarTrabajos.TabIndex = 6;
            this.btnBuscarTrabajos.UseVisualStyleBackColor = false;
            this.btnBuscarTrabajos.Visible = false;
            // 
            // tbBuscarTrabajos
            // 
            this.tbBuscarTrabajos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarTrabajos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.tbBuscarTrabajos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarTrabajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarTrabajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.tbBuscarTrabajos.Location = new System.Drawing.Point(530, 16);
            this.tbBuscarTrabajos.Name = "tbBuscarTrabajos";
            this.tbBuscarTrabajos.Size = new System.Drawing.Size(187, 29);
            this.tbBuscarTrabajos.TabIndex = 1;
            this.tbBuscarTrabajos.Visible = false;
            // 
            // dgvTrabajos
            // 
            this.dgvTrabajos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrabajos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.dgvTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(183)))), ((int)(((byte)(161)))));
            this.dgvTrabajos.Location = new System.Drawing.Point(30, 61);
            this.dgvTrabajos.Name = "dgvTrabajos";
            this.dgvTrabajos.Size = new System.Drawing.Size(730, 226);
            this.dgvTrabajos.TabIndex = 0;
            this.dgvTrabajos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajos_CellClick);
            // 
            // btnBorrarTrabajos
            // 
            this.btnBorrarTrabajos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarTrabajos.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarTrabajos.BackgroundImage = global::SaRaUI.Properties.Resources.Icono_Borrar;
            this.btnBorrarTrabajos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarTrabajos.FlatAppearance.BorderSize = 0;
            this.btnBorrarTrabajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTrabajos.Location = new System.Drawing.Point(687, 3);
            this.btnBorrarTrabajos.Name = "btnBorrarTrabajos";
            this.btnBorrarTrabajos.Size = new System.Drawing.Size(44, 44);
            this.btnBorrarTrabajos.TabIndex = 5;
            this.btnBorrarTrabajos.UseVisualStyleBackColor = false;
            this.btnBorrarTrabajos.Click += new System.EventHandler(this.btnBorrarTrabajos_Click);
            // 
            // Trabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 477);
            this.Controls.Add(this.panelFondo);
            this.Name = "Trabajos";
            this.Text = "Trabajos";
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelTablaC.ResumeLayout(false);
            this.panelTablaC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTrabajos;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panelTablaC;
        private System.Windows.Forms.ComboBox cbOrdenarTrabajos;
        private System.Windows.Forms.Button btnBuscarTrabajos;
        private System.Windows.Forms.TextBox tbBuscarTrabajos;
        private System.Windows.Forms.DataGridView dgvTrabajos;
        private System.Windows.Forms.Button btnBorrarTrabajos;
    }
}