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
    public partial class CadastroCliente : Form
    {
        MenuCliente menuCliente;

        string CPFrecebido, ativo, conveniado;

        public CadastroCliente(MenuCliente _menuCliente)
        {
            menuCliente = _menuCliente;
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            cmbConveniado.Text = "Não";
            cmbAtivo.Text = "Ativo";
            if (CPFrecebido != null)
            {
                //SqlConnection connection = new SqlConnection("Server=SUPAFdelivery.mssql.somee.com;Database=supafdelivery;User Id=EvolutionT41N_SQLLogin_1;Password=l9m8wr4u6y;");
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());
                SqlCommand command = new SqlCommand();
                command.CommandText = "ps_Cliente"; //definir o comando de texto que será executado
                command.CommandType = CommandType.StoredProcedure; //definir que o comando a ser executado é uma procedure
                command.Connection = connection; //vinculando o comando a conexão

                //3) Alimentar os parâmetros do procedimento que será executado no SQL através dos campos da tela                
                //command.Parameters.AddWithValue("nomeCliente", txtNomeRazaoCliente.Text);
                command.Parameters.AddWithValue("cpfouCPNJCliente", CPFrecebido);

                //4) Criando o objeto que irá armazenar os dados que eu buscar no banco de dados
                SqlDataReader reader;

                //5) Abrir a conexão com o banco de dados e executar o comando
                connection.Open();

                reader = command.ExecuteReader(); //executar um comando de leitura no banco de dados e retornar esses dados para aplicação

                if (reader.HasRows) //se existirem linhas de dados dentro do leitor
                {
                    reader.Read(); //lendo a próxima linha de dados existente dentro do leitor                                     

                    txtNomeRazaoCliente.Text = reader.GetString("nomeCliente");
                    txtCpfCnpjCliente.Text = reader.GetString("cpfouCPNJCliente");
                    txtEmailCliente.Text = reader.GetString("emailCliente");
                    txtCidadeCliente.Text = reader.GetString("cidadeCliente");
                    txtEnderecoCliente.Text = reader.GetString("enderecoCliente");
                    txtNumCliente.Text = reader.GetString("enderecoNumeroCLiente");
                    txtComCliente.Text = reader.GetString("enderecoComplementoCliente");
                    txtTelefoneCliente.Text = reader.GetDecimal("telefoneCliente").ToString();
                    txtCelularCliente.Text = reader.GetDecimal("celularCliente").ToString();
                    //txtTipoCliente.Text = reader.GetString("tipoCliente");
                    txtEmailCliente.Text = reader.GetString("loginCliente");
                    txtSenhaCliente.Text = reader.GetString("senhaCliente");
                    txtConveniado.Text = reader.GetDecimal("descontoConveniado").ToString();
                    //txtCredito.Text = reader.GetDecimal("descontoConveniado").ToString();
                    ativo = reader.GetString("ativoInativoCliente");

                    //if (ativo == "1")
                    //{
                    //    chkSimCliente.Checked = true;
                    //}
                    //else
                    //{
                    //    chkNaoCliente.Checked = false;
                    //}
                    //conveniado = reader.GetString("conveniadoCLiente");

                    //if (ativo == "1")
                    //{
                    //    chkSimConvenio.Checked = true;
                    //}
                    //else
                    //{
                    //    chkNaoConvenio.Checked = false;
                    //}

                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }

                connection.Close();



            }
        }

        public CadastroCliente(string CPFenviado)
        {
            this.CPFrecebido = CPFenviado;
            InitializeComponent();
        }

        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());
            SqlCommand command = new SqlCommand();
            command.CommandText = "pi_Cliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.AddWithValue("nomeCliente", txtNomeRazaoCliente.Text);
            command.Parameters.AddWithValue("cpfouCPNJCliente", txtCpfCnpjCliente.Text);
            command.Parameters.AddWithValue("emailCliente", txtEmailCliente.Text);
            command.Parameters.AddWithValue("cidadeCliente", txtCidadeCliente.Text);
            command.Parameters.AddWithValue("enderecoCliente", txtEnderecoCliente.Text);
            command.Parameters.AddWithValue("enderecoNumeroCLiente", txtNumCliente.Text);
            command.Parameters.AddWithValue("enderecoComplementoCliente", txtComCliente.Text);
            command.Parameters.AddWithValue("telefoneCliente", txtTelefoneCliente.Text);
            command.Parameters.AddWithValue("celularCliente", txtCelularCliente.Text);
            //command.Parameters.AddWithValue("tipoCliente", txtTipoCliente.Text);
            command.Parameters.AddWithValue("ativoInativoCliente", cmbAtivo.Text);
            command.Parameters.AddWithValue("conveniadoCLiente", cmbConveniado.Text);
            command.Parameters.AddWithValue("creditoConveniado", txtCredito.Text);
            command.Parameters.AddWithValue("descontoConveniado", txtConveniado.Text);
            command.Parameters.AddWithValue("loginCliente", txtEmailCliente.Text);
            command.Parameters.AddWithValue("senhaCliente", txtSenhaCliente.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Cliente cadastrado");
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja atualizar o cadastro?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                //SqlConnection connection = new SqlConnection("Server=SUPAFdelivery.mssql.somee.com;Database=supafdelivery;User Id=EvolutionT41N_SQLLogin_1;Password=l9m8wr4u6y;");
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());
                SqlCommand command = new SqlCommand();
                command.CommandText = "pu_Cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("nomeCliente", txtNomeRazaoCliente.Text);
                command.Parameters.AddWithValue("cpfouCPNJCliente", txtCpfCnpjCliente.Text);
                command.Parameters.AddWithValue("emailCliente", txtEmailCliente.Text);
                command.Parameters.AddWithValue("cidadeCliente", txtCidadeCliente.Text);
                command.Parameters.AddWithValue("enderecoCliente", txtEnderecoCliente.Text);
                command.Parameters.AddWithValue("enderecoNumeroCLiente", txtNumCliente.Text);
                command.Parameters.AddWithValue("enderecoComplementoCliente", txtComCliente.Text);
                command.Parameters.AddWithValue("telefoneCliente", txtTelefoneCliente.Text);
                command.Parameters.AddWithValue("celularCliente", txtCelularCliente.Text);
                //command.Parameters.AddWithValue("tipoCliente", txtTipoCliente.Text);
                //command.Parameters.AddWithValue("ativoInativoCliente", chkSimCliente.Checked || chkNaoCliente.Checked);
                //command.Parameters.AddWithValue("conveniadoCLiente", chkSimConvenio.Checked || chkNaoConvenio.Checked);
                command.Parameters.AddWithValue("creditoConveniado", txtConveniado.Text);
                //command.Parameters.AddWithValue("descontoConveniado", txtCredito.Text);
                command.Parameters.AddWithValue("loginCliente", txtEmailCliente.Text);
                command.Parameters.AddWithValue("senhaCliente", txtSenhaCliente.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Funcionario Atualizado");
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox || c is ComboBox)
                    {
                        c.Text = String.Empty;
                    }

                }
            }
        }
    }
}
