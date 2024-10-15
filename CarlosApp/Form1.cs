using Microsoft.VisualBasic.Logging;
using System.ComponentModel;

namespace CarlosApp
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
|       public BindingList<Fornecedor> fornecedores { get; set; }
|       public BindingList<Compra> Compras { get; set; }
        public BindingList<Venda> Vendas { get; set; }
        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            clientes = new BindingList<Cliente>();
            fornecedores = new BindingList<Fornecedor>();
            Compras = new BindingList<Compra>();
            Vendas = new BindingList<Venda>();
            this.dataGridView1.DataSource = produtos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCriarProduto fcp = new formCriarProduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();

                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id) + 1;

                produto.Nome = fcp.NomeProduto;
                produto.Fabricante = fcp.Fabricante;
                produto.PrecoCompra = fcp.PrecoCompra;
                produto.PrecoVenda = fcp.PrecoVenda;
                produtos.Add(produto);
            }
        }
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows.Count - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = produtos;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clientes;
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {

        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
