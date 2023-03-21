using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace T41N_DoTheEvolution
{
    public partial class DirecionarCorrida : Form
    {
        Principal principal;
        public DirecionarCorrida(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        private void txtTelefoneCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarCorrida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
