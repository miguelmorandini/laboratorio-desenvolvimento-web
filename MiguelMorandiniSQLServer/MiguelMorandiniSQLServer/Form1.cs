using System.Data;
using System.Data.SqlClient;

namespace MiguelMorandiniSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string stringDeConexao = "Data Source=LAB03-D05\\SQLEXPRESS;Initial Catalog=BancoFatec;Integrated Security=True;Encrypt=False";

        private void CriarTabela(object sender, EventArgs e)
        {
            string stringDoComando = "CREATE TABLE usuarios (id int, name nchar(100), phone nchar(9), idade int)";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Tabela Criada com Sucesso!", "Tabela Criada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void DeletarTabela(object sender, EventArgs e)
        {
            string stringDoComando = "DROP TABLE usuarios";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Tabela Excluída!", "Tabela Excluída");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void InserirItem(object sender, EventArgs e)
        {
            string stringDoComando = "INSERT INTO usuarios (id, name, phone, idade) VALUES (1, 'Miguel', 123456789, 20)";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Dados Inseridos com Sucesso!", "Dados Alterados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
        private void ExcluirItem(object sender, EventArgs e)
        {
            string stringDoComando = "DELETE FROM usuarios WHERE id = 1";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Item Excluído com Sucesso!", "Item Excluído");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void AtualizaNome(object sender, EventArgs e)
        {
            string stringDoComando = "UPDATE usuarios SET name = 'Miguel Morandini'WHERE name = 'Miguel'";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Nome Alterado com Sucesso!", "Item Alterado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void AlterarIdade(object sender, EventArgs e)
        {
            string stringDoComando = "UPDATE usuarios SET idade = 19 WHERE id = 1";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Idade Alterada com Sucesso!", "Item Alterado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void AlterarTelefone(object sender, EventArgs e)
        {
            string stringDoComando = "UPDATE usuarios SET phone = '999999994' WHERE id = 1";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Telefone Alterado com Sucesso!", "Item Alterado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}
