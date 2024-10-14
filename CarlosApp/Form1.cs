using System.ComponentModel;

namespace CarlosApp
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            this.dataGridView1.DataSource = produtos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCriarProduto fcp = new formCriarProduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();

                if(produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id)+ 1;

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
    }
}
