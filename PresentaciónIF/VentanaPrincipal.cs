using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PresentaciónIF
{
    public partial class VentanaPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public VentanaPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(204, 189, 171);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
