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
    public partial class CadastroMotoboy : Form
    {
        MenuMotoboy menuMotoboy;

        string CNHrecebida;
        string ativo;



        public CadastroMotoboy(MenuMotoboy _menuMotoboy)
        {
            menuMotoboy = _menuMotoboy;
            InitializeComponent();

        }        

        public CadastroMotoboy(string CNHenviada)
        {
            this.CNHrecebida = CNHenviada;
            InitializeComponent();
        }

        private void btnVoltarMotoboy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarMotoboy_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new
                 SqlConnection(Properties.Settings.Default.strConexao.ToString());

            SqlCommand command = new SqlCommand();
            command.CommandText = "pi_Motoboy";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.AddWithValue("cnhMotoboy", txtCnhMotoboy.Text);
            command.Parameters.AddWithValue("nomeMotoboy", txtNomeMotoboy.Text);
            command.Parameters.AddWithValue("idadeMotoboy", DataNascimentoMotoboy.Value);
            command.Parameters.AddWithValue("veiculoMotoboy", txtVeiculoMotoboy.Text);
            command.Parameters.AddWithValue("modeloMotoboy", txtModeloMotoboy.Text);
            command.Parameters.AddWithValue("placaMotoboy", txtPlacaMotoboy.Text);            
            command.Parameters.AddWithValue("enderecoMotoboy", txtEnderecoMotoboy.Text);
            command.Parameters.AddWithValue("enderecoNumeroMotoboy", txtNumMotoboy.Text);
            command.Parameters.AddWithValue("EnderecoComplementoMotoboy", txtComMotoboy.Text);
            command.Parameters.AddWithValue("celularMotoboy", txtCelularMotoboy.Text);            
            command.Parameters.AddWithValue("ativoInativoMotoboy", chkSimMotoboy.Checked || chkNaoMotoboy.Checked);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Motoboy cadastrado");
        }

        private void CadastroMotoboy_Load(object sender, EventArgs e)
        {
            if (CNHrecebida != null)
            {
                //SqlConnection connection = new SqlConnection("Server=SUPAFdelivery.mssql.somee.com;Database=supafdelivery;User Id=EvolutionT41N_SQLLogin_1;Password=l9m8wr4u6y;");
                SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.strConexao.ToString());

                SqlCommand command = new SqlCommand();
                command.CommandText = "ps_Motoboy";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                //command.Parameters.AddWithValue("nomeMotoboy", txtCnhMotoboy.Text);
                command.Parameters.AddWithValue("cnhMotoboy", CNHrecebida);

                SqlDataReader reader;

                connection.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    txtCnhMotoboy.Text = reader.GetString("cnhMotoboy");
                    txtNomeMotoboy.Text = reader.GetString("nomeMotoboy");
                    DataNascimentoMotoboy.Value = reader.GetDateTime("idadeMotoboy");
                    txtVeiculoMotoboy.Text = reader.GetString("veiculoMotoboy");
                    txtModeloMotoboy.Text = reader.GetString("modeloMotoboy");
                    txtPlacaMotoboy.Text = reader.GetString("placaMotoboy");
                    txtEnderecoMotoboy.Text  = reader.GetString("enderecoMotoboy");
                    txtNumMotoboy.Text  = reader.GetString("enderecoNumeroMotoboy");
                    txtComMotoboy.Text = reader.GetString("EnderecoComplementoMotoboy");
                    txtCelularMotoboy.Text  = reader.GetDecimal("celularMotoboy").ToString();
                    //"ativoInativoMotoboy", chkSimMotoboy.Checked || chkNaoMotoboy.Checked)
                     ativo = reader.GetString("ativoInativoMotoboy");


                    if (ativo == "1")
                    {
                        chkSimMotoboy.Checked = true;
                    }
                    else
                    {
                        chkNaoMotoboy.Checked = false;
                    }


                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }

                connection.Close();
            }



        }

        private void btnAtualizarMotoboy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja atualizar o cadastro?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.strConexao.ToString());

                SqlCommand command = new SqlCommand();
                command.CommandText = "PU_Motoboy";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("nomeMotoboy", txtNomeMotoboy.Text);
                command.Parameters.AddWithValue("cnhMotoboy", txtCnhMotoboy.Text);
                command.Parameters.AddWithValue("idadeMotoboy", DataNascimentoMotoboy.Value);
                command.Parameters.AddWithValue("enderecoMotoboy", txtEnderecoMotoboy.Text);
                command.Parameters.AddWithValue("enderecoNumeroMotoboy", txtNumMotoboy.Text);
                command.Parameters.AddWithValue("EnderecoComplementoMotoboy", txtComMotoboy.Text);
                command.Parameters.AddWithValue("celularMotoboy", txtCelularMotoboy.Text);
                command.Parameters.AddWithValue("veiculoMotoboy", txtVeiculoMotoboy.Text);
                command.Parameters.AddWithValue("modeloMotoboy", txtModeloMotoboy.Text);
                command.Parameters.AddWithValue("placaMotoboy", txtPlacaMotoboy.Text);
                command.Parameters.AddWithValue("ativoInativoMotoboy", chkSimMotoboy.Checked || chkNaoMotoboy.Checked);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Motoboy Atualizado");
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox || c is ComboBox)
                    {
                        c.Text = String.Empty;
                    }

                }
            }


        }

        private void chkSimMotoboy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSimMotoboy.Checked)
            {
                    chkNaoMotoboy.Checked = false;
             }
        }

        private void chkNaoMotoboy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNaoMotoboy.Checked)
            {
                chkSimMotoboy.Checked = false;
            }
        }
    }
}

