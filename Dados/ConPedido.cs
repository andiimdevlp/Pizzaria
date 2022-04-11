using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Dados
{
    public class ConPedido
    {
        private dConexão conexao = new dConexão();

        SqlDataReader ler;
        DataTable tabela = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "select * from [dbo].[PedidosDoDia]";
            ler = comando.ExecuteReader();
            tabela.Load(ler);
            conexao.FecharConexao();
            return tabela;
        }
        public DataTable SelectCliente(string telefone)
        {
            comando.Connection = conexao.AbrirConexao();
            comando.CommandText = "SELECT cli.nome FROM clientes cli " 
                +"JOIN telefones tel ON cli.telefone_id = tel.id_telefone "
                +"WHERE tel.telefone = "
                +"'" + Regex.Replace(telefone, @"[^\d]","") + "'";
            ler = comando.ExecuteReader();
            tabela.Load(ler);
            conexao.FecharConexao();
            return tabela;
        }
    }
}
