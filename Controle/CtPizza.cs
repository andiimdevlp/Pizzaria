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

        public void InserirPizza(string sabor, string ingredientes, string valor)
        {
            objetocDados.Inserir(sabor, ingredientes, Convert.ToDouble(valor));
        }
    }
}
