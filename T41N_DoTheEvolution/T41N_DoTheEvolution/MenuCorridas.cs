using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace T41N_DoTheEvolution
{
    public partial class MenuCorridas : Form
    {
        Principal principal;
        public MenuCorridas(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        private void btnCancelarCorrida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
