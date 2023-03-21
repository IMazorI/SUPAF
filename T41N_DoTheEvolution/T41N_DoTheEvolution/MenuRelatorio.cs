using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace T41N_DoTheEvolution
{
    public partial class MenuRelatorio : Form
    {
        Principal principal;
        public MenuRelatorio(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        private void btnVoltarRelatorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
