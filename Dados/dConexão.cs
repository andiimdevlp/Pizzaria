using System.Data.SqlClient;

namespace Dados
{
    internal class dConexão
    {
        private SqlConnection Conexao = new SqlConnection("Data Source = HOME; Initial Catalog = MultMassa; Integrated Security = True; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        public SqlConnection AbrirConexao()
        {
            if (Conexao.State == System.Data.ConnectionState.Closed)
                Conexao.Open();
            return Conexao;
        }
        public SqlConnection FecharConexao()
        {
            if (Conexao.State == System.Data.ConnectionState.Open)
                Conexao.Close();
            return Conexao;
        }
    }
}
