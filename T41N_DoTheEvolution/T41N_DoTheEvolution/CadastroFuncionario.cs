using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace T41N_DoTheEvolution
{
    public partial class CadastroFuncionario : Form
    {
        MenuFuncionario menuFuncionario;

        string CPFrecebido, ativo;

        public CadastroFuncionario(MenuFuncionario _menuFuncionario)
        {
            menuFuncionario = _menuFuncionario;
            InitializeComponent();
        }

        public CadastroFuncionario(string CPFenviado)
        {
            this.CPFrecebido = CPFenviado;
            InitializeComponent();
        }



        private void btnVoltarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());

            SqlCommand command = new SqlCommand();
            command.CommandText = "pi_Funcionario";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.AddWithValue("nomeFuncionario", txtNomeFuncionario.Text);
            command.Parameters.AddWithValue("cpfFuncionario", txtCpfFuncionario.Text);
            command.Parameters.AddWithValue("idadeFuncionario", DataNascimentoFuncionario.Value);
            command.Parameters.AddWithValue("emailFuncionario", txtEmailFuncionario.Text);
            command.Parameters.AddWithValue("cidadeFuncionario", txtCidadeFuncionario.Text);
            command.Parameters.AddWithValue("enderecoFuncionario", txtEnderecoFuncionario.Text);
            command.Parameters.AddWithValue("enderecoNumeroFuncionario", txtNumFuncionario.Text);
            command.Parameters.AddWithValue("enderecoComplementoFuncionario", txtComFuncionario.Text);
            command.Parameters.AddWithValue("telefoneFuncionario", txtTelefoneFuncionario.Text);
            command.Parameters.AddWithValue("celularFuncionario", txtCelularFuncionario.Text);
            command.Parameters.AddWithValue("perfilFuncionario", txtPerfilFuncionario.Text);
            command.Parameters.AddWithValue("loginFuncionario", txtLoginFuncionario.Text);
            command.Parameters.AddWithValue("ativoInativoFuncionario", chkSimFuncionario.Checked || chkNaoFuncionario.Checked);
            command.Parameters.AddWithValue("senhaFuncionario", txtSenhaFuncionario.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Funcionario cadastrado");

        }

        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja atualizar o cadastro?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                //SqlConnection connection = new SqlConnection("Server=SUPAFdelivery.mssql.somee.com;Database=supafdelivery;User Id=EvolutionT41N_SQLLogin_1;Password=l9m8wr4u6y;");
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());
                SqlCommand command = new SqlCommand();
                command.CommandText = "pu_Funcionario";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("nomeFuncionario", txtNomeFuncionario.Text);
                command.Parameters.AddWithValue("cpfFuncionario", txtCpfFuncionario.Text);
                command.Parameters.AddWithValue("idadeFuncionario", DataNascimentoFuncionario.Value);
                command.Parameters.AddWithValue("emailFuncionario", txtEmailFuncionario.Text);
                command.Parameters.AddWithValue("cidadeFuncionario", txtCidadeFuncionario.Text);
                command.Parameters.AddWithValue("enderecoFuncionario", txtEnderecoFuncionario.Text);
                command.Parameters.AddWithValue("enderecoNumeroFuncionario", txtNumFuncionario.Text);
                command.Parameters.AddWithValue("enderecoComplementoFuncionario", txtComFuncionario.Text);
                command.Parameters.AddWithValue("telefoneFuncionario", txtTelefoneFuncionario.Text);
                command.Parameters.AddWithValue("celularFuncionario", txtCelularFuncionario.Text);
                command.Parameters.AddWithValue("perfilFuncionario", txtPerfilFuncionario.Text);
                command.Parameters.AddWithValue("loginFuncionario", txtLoginFuncionario.Text);
                command.Parameters.AddWithValue("ativoInativoFuncionario", chkSimFuncionario.Checked || chkNaoFuncionario.Checked);
                command.Parameters.AddWithValue("senhaFuncionario", txtSenhaFuncionario.Text);

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

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            if (CPFrecebido != null)
            {
                //SqlConnection connection = new SqlConnection("Server=SUPAFdelivery.mssql.somee.com;Database=supafdelivery;User Id=EvolutionT41N_SQLLogin_1;Password=l9m8wr4u6y;");
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());
                SqlCommand command = new SqlCommand();
                command.CommandText = "ps_Funcionario"; //definir o comando de texto que será executado
                command.CommandType = CommandType.StoredProcedure; //definir que o comando a ser executado é uma procedure
                command.Connection = connection; //vinculando o comando a conexão

                //3) Alimentar os parâmetros do procedimento que será executado no SQL através dos campos da tela                
                command.Parameters.AddWithValue("nomeFuncionario", txtCpfFuncionario.Text);
                command.Parameters.AddWithValue("cpfFuncionario", txtCpfFuncionario.Text);

                //4) Criando o objeto que irá armazenar os dados que eu buscar no banco de dados
                SqlDataReader reader;

                //5) Abrir a conexão com o banco de dados e executar o comando
                connection.Open();

                reader = command.ExecuteReader(); //executar um comando de leitura no banco de dados e retornar esses dados para aplicação

                if (reader.HasRows) //se existirem linhas de dados dentro do leitor
                {
                    reader.Read(); //lendo a próxima linha de dados existente dentro do leitor                                     

                    txtNomeFuncionario.Text = reader.GetString("nomeFuncionario");
                    txtCpfFuncionario.Text = reader.GetString("cpfFuncionario");
                    DataNascimentoFuncionario.Value = reader.GetDateTime("idadeFuncionario");
                    txtEmailFuncionario.Text = reader.GetString("EmailFuncionario");
                    txtCidadeFuncionario.Text = reader.GetString("CidadeFuncionario");
                    txtEnderecoFuncionario.Text = reader.GetString("EnderecoFuncionario");
                    txtNumFuncionario.Text = reader.GetString("enderecoNumeroFuncionario");
                    txtComFuncionario.Text = reader.GetString("enderecoComplementoFuncionario");
                    txtTelefoneFuncionario.Text = reader.GetDecimal("TelefoneFuncionario").ToString();
                    txtCelularFuncionario.Text = reader.GetDecimal("CelularFuncionario").ToString();
                    txtPerfilFuncionario.Text = reader.GetString("PerfilFuncionario");
                    txtLoginFuncionario.Text = reader.GetString("LoginFuncionario");
                    txtSenhaFuncionario.Text = reader.GetString("SenhaFuncionario");
                    ativo = reader.GetString("ativoInativoFuncionario");

                    if (ativo == "1")
                    {
                        chkSimFuncionario.Checked = true;
                    }
                    else
                    {
                        chkNaoFuncionario.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }

                connection.Close();



            }


        }
    }
}
