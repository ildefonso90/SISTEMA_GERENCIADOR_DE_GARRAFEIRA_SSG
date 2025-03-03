using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace $safeprojectname$
{
    public partial class Gerenciar_Usuarios : Form
    {
        public Gerenciar_Usuarios()
        {
            InitializeComponent();
        }
        //conexao com o banco de dados
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Integrated security=true; Initial Catalog=LOGINS_GARRAFEIRA");
        //vamso instaciar o sql comand --- usar delete, insirt, update...
       
        //vamso instaciar o sql DataReader --- para usarmos o select
        SqlDataReader dt;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Dessbilitar_bt()
        {
            //aqui nos CRIAMOS UM METODO CHAMADO Dessbilitar_bt Q QUANDO INCIADO ELE DESABILITAS OS CAMPOS OU TEXBOXS
            bt_excluir.Enabled = false;
            bt_salvar.Enabled = false;
            tbx_nome_usuario.Enabled = false;
            tbx_nome.Enabled = false;
            tbx_Senha.Enabled = false;
            cotbx_tipo.Enabled = false;

        }
        private void Habilitar_bt()
        {
            //aqui nos CRIAMOS UM METODO CHAMADO Habilitar_bt Q QUANDO INCIADO ELE HABILIATA OS CAMPOS OU TEXBOXS
            bt_excluir.Enabled = true;
            bt_salvar.Enabled = true;
            tbx_nome_usuario.Enabled = true;
            tbx_Senha.Enabled = true;
            cotbx_tipo.Enabled = true;
            tbx_nome.Enabled = true;
            //aqui colocamos o focus no texbox tbx_nome_usuario
            tbx_nome.Focus();
            bt_novo.Enabled = false;
        }
        private void Limparcampos()
        {
            tbx_nome.Clear();
            tbx_nome_usuario.Clear();
            tbx_Senha.Clear();
            tbx_nome.Focus();
        }
        private void Gerenciar_Usuarios_Load(object sender, EventArgs e)
        {
            Dessbilitar_bt(); //CHAMANDO Dessbilitar_bt Q QUANDO INCIADO ELE DESABILITAS OS CAMPOS OU TEXBOXS

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            Habilitar_bt(); // CHAMADO Habilitar_bt Q QUANDO INCIADO ELE HABILIATA OS CAMPOS OU TEXBOXS
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            //CRIAMOS UMA VERIFICÃO PARA PERGUNTARMSO AO USER SE CAR MESMO EXCLUIR OS CAMPOS
            DialogResult excluir_ou_limpar;
            DialogResult = excluir_ou_limpar = MessageBox.Show("Tem certeza que deseja excluir??","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (excluir_ou_limpar == DialogResult.Yes)
            {
                //Aqui limpamos os campos
                Limparcampos();
               
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string Nome = tbx_nome.Text;
            string User = tbx_nome_usuario.Text;
            string Pass = tbx_Senha.Text;
            //Validação dos campos
            if (Nome == "" && User == "" && Pass == "")
            {
                MessageBox.Show("Todos os Campos estão vazios!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Nome == "")
            {
                MessageBox.Show("Campos Nome vazio!!", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tbx_nome.Focus();
            }
            else if (User == "")
            {
                MessageBox.Show("Campos usuario vazio!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_nome_usuario.Focus();
            }
            else if(Pass == "")
            {
                MessageBox.Show("Campos Senha vazio!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_Senha.Focus();
            }
            else if (Nome.Length < 5)
            {
                MessageBox.Show("O campo Nome tem de ter 5 caracteres no minimo!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_nome.Focus();
            }
            else if (Pass.Length < 5)
            {
                MessageBox.Show("O campo Senha tem de ter 5 caracteres no minimo!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_Senha.Focus();
            }
            else if (User.Length < 5)
            {
                MessageBox.Show("O campo Ususario tem de ter 5 caracteres no minimo!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_nome_usuario.Focus();
            }
            else if (Pass.Length < 5)
            {
                MessageBox.Show("O campo Senha tem de ter 5 caracteres no minimo!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_Senha.Focus();
            }
            //  |
            //  |
            //  |____ Ogica do BANCO DE DADOS NO FORM GERENCIAR USUARIOS
            else
            {
                //aqui guadei a escolha do usuario do combox
                //pois depois vou usar para fazer uma verificação
                string escolha = cotbx_tipo.Text;

              try //Aqui usamos o try para fazemos um tratamento de erro
                {
                   if (escolha == "Administrador")
                        { 
                    //Aqui estamos a enviar os valores dos texbox q guardamos nas nossas variaveis no banco de dados
                    //string Nome = tbx_nome.Text;
                    //string User = tbx_nome_usuario.Text;
                    //string Pass = tbx_Senha.Text;
                    string sql = "insert into TBL_LOGIN_ADM (USUARIO_ADM, SENHA_ADM, NOME_ADM) values (@User,@Pass,@Nome)";

                    SqlCommand cm = new SqlCommand(sql, cn);

                    cm.Parameters.Add("@User", SqlDbType.VarChar).Value = User;
                    cm.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Pass;
                    cm.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                    //aqui abrimos a conexão
                    cn.Open();
                    //Aqui vamos executar sem consulta "execute sem consulta ------- ExecuteNonQuery"
                    cm.ExecuteNonQuery();
                        MessageBox.Show("Gefistro efetuado com sucesso", "Novo", MessageBoxButtons.OK);
                        Limparcampos();
                        }
                   else if (escolha == "Atendente")
                    {
                        //Aqui estamos a enviar os valores dos texbox q guardamos nas nossas variaveis no banco de dados
                        //string Nome = tbx_nome.Text;
                        //string User = tbx_nome_usuario.Text;
                        //string Pass = tbx_Senha.Text;
                        string sql = "insert into TBL_LOGIN_ATD (USUARIO_ATD, SENHA_ATD, NOME_ATD) values (@User,@Pass,@Nome)";

                        SqlCommand cm = new SqlCommand(sql, cn);

                        cm.Parameters.Add("@User", SqlDbType.VarChar).Value = User;
                        cm.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Pass;
                        cm.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                        //aqui abrimos a conexão
                        cn.Open();
                        //Aqui vamos executar sem consulta "execute sem consulta ------- ExecuteNonQuery"
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Gefistro efetuado com sucesso", "Novo", MessageBoxButtons.OK);
                        Limparcampos();
                    }
                   else
                    {
                        MessageBox.Show("Escolha vazia! Escolha uma opção", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error) //tratamento de erros
                {
                    MessageBox.Show(""+error);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }

            }
        }
    }
}
