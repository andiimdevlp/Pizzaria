using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class ConPizza
    {
        private dConexão conexao = new dConexão();

        SqlDataReader ler;
        DataTable tabela = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "select * from [dbo].pizzas";
            ler = comando.ExecuteReader();
            tabela.Load(ler);
            conexao.FecharConexao();
            return tabela;
        }
    }
}
