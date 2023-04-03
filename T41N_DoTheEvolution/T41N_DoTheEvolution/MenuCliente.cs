using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace T41N_DoTheEvolution
{
    public partial class MenuCliente : Form
    {

        public string CPFenviado;

        Principal principal;
        public MenuCliente(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente nova = new CadastroCliente(this);
            nova.MdiParent = principal;
            nova.Show();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new
    SqlConnection(Properties.Settings.Default.strConexao.ToString());
            SqlCommand command = new SqlCommand();
            command.CommandText = "pd_Cliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.AddWithValue("cpfouCPNJCliente", CPFenviado);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Cliente Excluído");

            Listar();
        }

        private void Listar()
        {

            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.strConexao.ToString());


            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Cliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;


            command.Parameters.AddWithValue("nomeCliente", txtCpfCnpjCliente.Text); // MUDAR PARA NOME E CPF NA BUSCA
            command.Parameters.AddWithValue("cpfouCPNJCliente", txtCpfCnpjCliente.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable ds = new DataTable();

            adapter.Fill(ds);

            DGVcliente.DataSource = ds;
        }


        private void DGVcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CPFenviado = DGVcliente.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente Atualizar = new CadastroCliente(CPFenviado);
            Atualizar.Show();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
