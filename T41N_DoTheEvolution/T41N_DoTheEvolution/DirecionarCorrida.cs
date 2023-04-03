using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void btnBuscarCorrida_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new
               SqlConnection(Properties.Settings.Default.strConexao.ToString());


            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Cliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;


            command.Parameters.AddWithValue("nomeCliente", txtNomeSolicitante.Text);
            command.Parameters.AddWithValue("cpfouCPNJCliente", txtNomeSolicitante.Text);


            SqlDataReader reader;

            //5) Abrir a conexão com o banco de dados e executar o comando
            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                txtIDcliente.Text = reader.GetInt32("idCliente").ToString();
                txtNomeCliente.Text = reader.GetString("nomeCliente");

            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }

            connection.Close();


        }

        private void btnConfirmarCorrida_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());

            SqlCommand command = new SqlCommand();
            command.CommandText = "pi_Corrida";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;


            command.Parameters.AddWithValue("idMotoboy", txtIDMotoboy.Text);
            command.Parameters.AddWithValue("idCliente", txtIDcliente.Text);
            command.Parameters.AddWithValue("idFuncionario",         .Text);   //criar
            command.Parameters.AddWithValue("valorCorrida", txtValorCorrida.Text);
            command.Parameters.AddWithValue("previsaoTempoCorrida",    .Text); //criar
            command.Parameters.AddWithValue("distanciaCorrida", txtDistanciaCorrida.Text);
            //Retira
            command.Parameters.AddWithValue("horarioRetiraCorrida", dtpHoraRetira.Text);
            command.Parameters.AddWithValue("dataRetiraCorrida", dtpDataRetira.Text);
            command.Parameters.AddWithValue("cidadeRetiradaCorrida", txtCidadeRetira.Text);
            command.Parameters.AddWithValue("enderecoRetiradaCorrida", txtEnderecoRetira.Text);
            command.Parameters.AddWithValue("enderecoNumeroRetiradaCorrida", txtNumRetira.Text);
            command.Parameters.AddWithValue("enderecoComplementoRetiradaCorrida", txtComRetira.Text);
            command.Parameters.AddWithValue("cepRetiraCorrida", txtCepRetira.Text);
            //Entrega
            command.Parameters.AddWithValue("horarioEntregaCorrida", dtpHoraEntrega.Text);
            command.Parameters.AddWithValue("dataEntregaCorrida", dtpDataEntrega.Text);
            command.Parameters.AddWithValue("cidadeEntregaCorrida", txtCidadeEntrega.Text);
            command.Parameters.AddWithValue("enderecoEntregaCorrida", txtEnderecoEntrega.Text);            
            command.Parameters.AddWithValue("enderecoNumeroEntregaCorrida", txtNumEntrega.Text);
            command.Parameters.AddWithValue("enderecoComplementoEntregaCorrida", txtComEntrega.Text);            
            command.Parameters.AddWithValue("cepEntregaCorrida", txtCepEntrega.Text);            
            //status
            command.Parameters.AddWithValue("  ", .Text); //criar



            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Corrida cadastrada");



        }

        private void DirecionarCorrida_Load(object sender, EventArgs e)
        {
            

        }

        private void cmbMotoboy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NAO ESTA FUNCIONANDO

            SqlConnection connection = new
             SqlConnection(Properties.Settings.Default.strConexao.ToString());

            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Motoboy";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            SqlDataReader reader;

            connection.Open();

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                cmbMotoboy.Items.Clear();

                while (reader.Read())
                {

                    txtIDMotoboy.Text = reader.GetInt32("idMotoboy").ToString();   //No clique da combo box                 
                    cmbMotoboy.Items.Add(reader["nomeMotoboy"].ToString());

                }

                connection.Close();

            }
        }
    }
}
