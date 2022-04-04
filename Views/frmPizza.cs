using Controle;

namespace Views
{
    public partial class frmPizza : Form
    {
        CtPizza objetoCt = new CtPizza();
        public frmPizza()
        {
            InitializeComponent();
        }
        private void MostrarPizza()
        {
            dtgPizza.DataSource = objetoCt.MostraPizza();
        }
        private void frmPizza_Load(object sender, EventArgs e)
        {
            MostrarPizza();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objetoCt.InserirPizza(txtSabor.Text, txtIngredientes.Text, txtPreco.Text, txtTipo.Text);
        }
    }
}