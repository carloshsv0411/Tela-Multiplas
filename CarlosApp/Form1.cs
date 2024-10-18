using Microsoft.VisualBasic.Logging;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace CarlosApp
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Compra> Compras { get; set; }
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
            this.dataGridView1.DataSource = clientes;
            this.dataGridView1.DataSource = fornecedores;
            this.dataGridView1.DataSource = Compras;
            this.dataGridView1.DataSource = Vendas;
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

                produto.produto = fcp.Produto;
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

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            CadastrarClientes clt = new CadastrarClientes();
            var resultado = clt.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                if (clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = clientes.Max(x => x.Id) + 1;

                cliente.nome = clt.Cliente;
                cliente.fone = clt.Telefone;
                cliente.endereco = clt.Endereço;
                cliente.email = clt.Email;
                clientes.Add(cliente);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonCompra_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Compras;
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Vendas;
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clientes;
        }

        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = fornecedores;
        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clientes.RemoveAt(dataGridView1.SelectedRows.Count - 1);
            }
        }

        private void buttonAdicionarF_Click(object sender, EventArgs e)
        {
            FormCadastrarFornecedores fnc = new FormCadastrarFornecedores();
            var resultado = fnc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = fornecedores.Max(x => x.Id) + 1;

                fornecedor.nomeDaEmpresa = fnc.NomeEmpresa;
                fornecedor.nomeDaEmpresa = fnc.NomeparaContato;
                fornecedor.fone = fnc.Telefone;
                fornecedor.CNPJ = fnc.CNPJ;
                fornecedor.endereço = fnc.Endereco;
                fornecedor.emaill = fnc.emaill;
                fornecedores.Add(fornecedor);
            }
        }

        private void buttonRemoverF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                fornecedores.RemoveAt(dataGridView1.SelectedRows.Count - 1);
            }
        }

        private void buttonAdicionarC_Click(object sender, EventArgs e)
        {
            if (fornecedores.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar um Fornecedor antes de efetuar a compra.");
                return;
            }

            if (produtos.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar um Produto  antes efetuar uma compra");
                return;
            }
            FromCriarCompra fcc = new FromCriarCompra(fornecedores, produtos);
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (Compras.Count == 0) compra.idProduto = 1;
                else compra.idProduto = Compras.Max(x => x.idProduto) + 1;

                compra.idProduto = fcc.IdProdutos;
                compra.idFornecedor = fcc.IdFornecedor;
                compra.quantidade = (int)fcc.Quantidade;
                compra.desconto = fcc.Desconto;
                compra.dataCompra = DateTime.Now;
            }
        }

        private void buttonRemoverC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Compras.RemoveAt(dataGridView1.SelectedRows.Count - 1);
            }
        }
    }
}
