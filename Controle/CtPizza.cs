using Dados;
using System.Data;

namespace Controle
{
    public class CtPizza
    {
        private ConPizza objetocDados = new ConPizza();

        public DataTable MostraPizza()
        {
            DataTable tabela = new DataTable();
            tabela = objetocDados.Mostrar();
            return tabela;
        }
    }
}
