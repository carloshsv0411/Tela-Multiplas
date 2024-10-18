using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosApp
{
    public partial class FromCriarCompra : Form
    {
        private BindingList<Fornecedor> Fornecedores { get; set; }
        private Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBoxForC.SelectedValue); } }
        public int IdFornecedor { get { return (int)comboBoxForC.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBoxProdC.SelectedValue); } }
        public int IdProdutos { get { return (int)comboBoxProdC.SelectedValue; } }

        public decimal Quantidade { get { return numericUpDownQC.Value; } }
        public decimal Desconto { get { return numericUpDownDC.Value; } }

        public decimal PrecoUnitario { get { return Produto.PrecoCompra; } }
        public decimal ValorTotal { get { return PrecoUnitario * Quantidade; } }
        public decimal ValorComDesconto { get { return ValorTotal * (1 - (Desconto / 100)); } }



        public FromCriarCompra(BindingList<Fornecedor> fornecedors, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedors;
            comboBoxForC.DataSource = Fornecedores;
            comboBoxForC.ValueMember = "Id";
            comboBoxForC.DisplayMember = "NomeEmpresa";

            Produtos = produtos;
            comboBoxProdC.DataSource = produtos;
            comboBoxProdC.ValueMember = "Id";
            comboBoxProdC.DisplayMember = "Nome";

        }

        private void FromCriarCompra_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxProdC_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownQC_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownDC_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void AtualizarValores()
        {
            if (Produto != null)
            {
                textBoxPrecoU.Text = PrecoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBoxValorTT.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBoxTotalDesconto.Text = ValorComDesconto.ToString("C", CultureInfo.CurrentCulture);

            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
