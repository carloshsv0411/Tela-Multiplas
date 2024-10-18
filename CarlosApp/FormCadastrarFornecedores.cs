using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarlosApp
{
    public partial class FormCadastrarFornecedores : Form
    {
        public string NomeEmpresa { get { return this.textBoxEmpresaFornece.Text; } }
        public string Endereco
        {
            get
            {
                string endereco = $"";
                endereco += $"({textBoxLogradouroFornece.Text}), ";
                endereco += $"({textBoxNumeroFornece.Text}), ";
                endereco += $"({textBoxEstadoF.Text}), ";
                endereco += $"({textBoxCidadeF.Text}), ";
                endereco += $"({textBoxComplementoF.Text}), ";
                endereco += $"({textBoxCEPf.Text}), ";
                return endereco;
            }
        }

        public string Telefone
        {
            get { return this.textBoxTelefoneFornece.Text; }
        }

        public string emaill
        {
            get
            {
                return this.textBoxEmailF.Text;
            }

        }

        public string CNPJ
        {
            get { return this.textBoxCNPJFornece.Text; }
        }

        public string NomeparaContato
        {
            get { return this.textBoxContatoFornece.Text; }
        }



        public FormCadastrarFornecedores()
        {
            InitializeComponent();
        }

        private void FormCadastrarFornecedores_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
