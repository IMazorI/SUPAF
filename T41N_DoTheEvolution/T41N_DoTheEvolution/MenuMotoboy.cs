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
    public partial class MenuMotoboy : Form
    {
        Principal principal;

       
        public string CNHenviada, cnh;
      


        public MenuMotoboy(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        private void btnBuscarMotoboy_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnNovoMotoboy_Click(object sender, EventArgs e)
        {
            CadastroMotoboy nova = new CadastroMotoboy(this);
            nova.MdiParent = principal;
            nova.Show();
        }

        private void btnAtualizarMotoboy_Click(object sender, EventArgs e)
        {
            CadastroMotoboy Atualizar = new CadastroMotoboy(CNHenviada);
            Atualizar.Show();
        }

        private void btnDeletarMotoboy_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new
              SqlConnection(Properties.Settings.Default.strConexao.ToString());
            SqlCommand command = new SqlCommand();
            command.CommandText = "pd_Motoboy";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.AddWithValue("cnhMotoboy", CNHenviada);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Funcionario Excluído");

            Listar();
        }

        private void MenuMotoboy_Load(object sender, EventArgs e)
        {
           Listar();
        }

        private void btnVoltarMotoboy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DGVMotoboy_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            CNHenviada = DGVmotoboy.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void DGVmotoboy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void DGVmotoboy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    CNHenviada = DGVmotoboy.Rows[e.RowIndex].Cells[1].Value.ToString();
        //}

        private void Listar()
        {

            //SqlConnection connection = new SqlConnection(Properties.Settings.Default.strConexao.ToString());
            //SqlConnection connection = new SqlConnection("Server=SUPAFdelivery.mssql.somee.com;Database=supafdelivery;User Id=EvolutionT41N_SQLLogin_1;Password=l9m8wr4u6y;");
            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.strConexao.ToString());

            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Motoboy";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;


            command.Parameters.AddWithValue("nomeMotoboy", txtCNHMotoboy.Text); // MUDAR PARA NOME E CPF NA BUSCA
            command.Parameters.AddWithValue("cnhMotoboy", txtCNHMotoboy.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable ds = new DataTable();

            adapter.Fill(ds);

            DGVmotoboy.DataSource = ds;
        }


    }
}
