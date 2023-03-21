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
    public partial class MenuFuncionario : Form
    {
        Principal principal;
        
        public string CPFenviado, cpf;


        public MenuFuncionario(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

     

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario nova = new CadastroFuncionario(this);
            nova.MdiParent = principal;
            nova.Show();
        }

        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario Atualizar = new CadastroFuncionario(CPFenviado);            
            Atualizar.Show();
        }
        
        private void btnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection("Server=SUPAFdelivery.mssql.somee.com;Database=supafdelivery;User Id=EvolutionT41N_SQLLogin_1;Password=l9m8wr4u6y;");
            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.strConexao.ToString());
            SqlCommand command = new SqlCommand();
            command.CommandText = "pd_Funcionario";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.AddWithValue("cpfFuncionario", CPFenviado);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Funcionario Excluído");

            Listar();

        }

        private void MenuFuncionario_Load(object sender, EventArgs e)
        {
            Listar();
        }

    
        private void btnVoltarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listar()
        {

            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.strConexao.ToString());
           
           
            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Funcionario"; 
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

         
            command.Parameters.AddWithValue("nomeFuncionario", txtCpfFuncionario.Text); // MUDAR PARA NOME E CPF NA BUSCA
            command.Parameters.AddWithValue("cpfFuncionario", txtCpfFuncionario.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command); 
            DataTable ds = new DataTable(); 

            adapter.Fill(ds);

            DGVfuncionario.DataSource = ds;
        }

        private void DGVfuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CPFenviado = DGVfuncionario.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
