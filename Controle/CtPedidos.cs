using Dados;
using System.Data;

namespace Controle
{
    public class CtPedidos
    {
        private ConPedido objetocDados = new ConPedido();

        public DataTable MostraPedidos()
        {
            DataTable tabela = new DataTable();
            tabela = objetocDados.Mostrar();
            return tabela;
        }

        public void SelectClienteCt(string telefone)
        {
            objetocDados.SelectCliente(telefone);
        }
    }
}
