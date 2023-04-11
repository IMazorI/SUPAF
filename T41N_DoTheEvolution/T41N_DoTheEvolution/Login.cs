using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace T41N_DoTheEvolution
{
    public partial class Login : Form
    {
        public static int idFun;

        public Principal principal;
        public Login(Principal _Principal)
        {
            this.principal = _Principal;
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
           


            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.strConexao.ToString());
                        //ConfigurationManager.ConnectionStrings["T41N_DoTheEvolution.Properties.Settings.strConexao"

            SqlCommand command = new SqlCommand();
            command.CommandText = "PS_Login";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.AddWithValue("loginFuncionario", txtLogin.Text);
            command.Parameters.AddWithValue("senhaFuncionario", txtSenha.Text);

            SqlDataReader reader;
            connection.Open();
           

            reader = command.ExecuteReader();

            reader.Read();

            Login.idFun = reader.GetInt32(0);
          

            if (reader.HasRows)
            {
                
                //lIBERAR O LOGIN
                MessageBox.Show("Bem vindo!");


                principal.CORRIDASToolStripMenuItem.Visible = true;                                
                principal.FUNCIONARIOSToolStripMenuItem.Visible = true;
                principal.MOTOBOYSToolStripMenuItem.Visible = true;
                principal.CLIENTESToolStripMenuItem.Visible = true;
                principal.RELATORIOToolStripMenuItem.Visible = true;
                principal.editarPerfilToolStripMenuItem.Visible = true;
                principal.deslogarToolStripMenuItem.Visible = true;
               

                connection.Close();
                this.Close();

            }

            else
            {
                connection.Close();
                MessageBox.Show("Usuario e/ou Senha Incorreto(s)!");
            }

         

            connection.Close();

            

        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
