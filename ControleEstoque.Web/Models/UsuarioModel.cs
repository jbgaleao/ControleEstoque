using System.Data.SqlClient;

namespace Controle_Estoque.Web.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            bool ret = false;

            using (SqlConnection conexao = new SqlConnection())
            {   
                conexao.ConnectionString = "Data Source=localhost;Initial Catalog=controle-estoque;User ID=sa;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conexao.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format(
                        "select count(*) from usuario where login = '{0}' and senha = '{1}'", login, senha);

                    ret = (int)comando.ExecuteScalar() > 0;
                }
            }
            return ret;
        }
    }
}
