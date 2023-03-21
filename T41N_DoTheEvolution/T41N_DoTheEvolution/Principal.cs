using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T41N_DoTheEvolution
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void fUNCIONARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFuncionario nova = new MenuFuncionario(this);
            nova.MdiParent = this;
            nova.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuRelatorio nova = new MenuRelatorio(this);
            nova.MdiParent = this;
            nova.Show();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCliente nova = new MenuCliente(this);
            nova.MdiParent = this;
            nova.Show();
        }

        private void mOTOBOYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuMotoboy nova = new MenuMotoboy(this);
            nova.MdiParent = this;
            nova.Show();
        }

        private void selecionarMotoboyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirecionarCorrida nova = new DirecionarCorrida(this);
            nova.MdiParent = this;
            nova.Show();
        }

        private void emAndamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCorridas nova = new MenuCorridas(this);
            nova.MdiParent = this;
            nova.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Login acessar = new Login(this);
            acessar.MdiParent = this;
            acessar.Show();
        }

        private void cONECTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login acessar = new Login(this);
            acessar.Show();
        }
    }
}
