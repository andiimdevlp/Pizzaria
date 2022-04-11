using Controle;
using System.Data;


namespace Views
{
    public partial class frmPedidos : Form
    {
        CtPedidos objetoCtPedidos = new CtPedidos();
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void MostrarPedidos()
        {
            dtgPedidos.DataSource = objetoCtPedidos.MostraPedidos();
        }
        private void frmPedidos_Load(object sender, EventArgs e)
        {
            MostrarPedidos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objetoCtPedidos.SelectClienteCt(txtTelefone.Text);
        }
    }
}
