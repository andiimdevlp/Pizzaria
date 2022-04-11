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
        public void Inserir(string sabor, string ingredientes, double valor)
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "INSERT INTO MultMassa.dbo.pizzas (sabor,ingredientes,valor)" +
                "VALUES('" + sabor + "','" + ingredientes + "','" + Convert.ToDouble(valor) + "')";
            comando.ExecuteNonQuery();
        }
    }
}
