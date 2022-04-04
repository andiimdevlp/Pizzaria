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
    }
}