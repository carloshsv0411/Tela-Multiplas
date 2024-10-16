

using System.Windows.Forms;

namespace CarlosApp
{
    public partial class formCriarProduto : Form
    {
        public string Produto { get { return this.nomeProduto.Text; } }
        public string Fabricante { get { return this.buttonFabricante.Text; } }
        public decimal PrecoCompra { get { return this.precoCompra.Value; } }
        public decimal PrecoVenda { get { return this.precoVenda.Value; } }


        public formCriarProduto()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPrecodeVenda_Click(object sender, EventArgs e)
        {

        }

        private void labelPrecoDeCompra_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void formCriarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
