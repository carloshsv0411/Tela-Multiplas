using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosApp
{
    public partial class CadastrarClientes : Form
    {
        public string Cliente { get { return this.textBoxNomeCliente.Text; } }
        public string Endereço {
            get 
            {
                string endereco = "";
                return this.textBoxEndreco.Text; } }
        public string Telefone { get{  return this.textBoxTelefone.Text; }
        }
        public string Email { get { return this.textBoxEmail.Text; } }

        public CadastrarClientes()
        {
            InitializeComponent();
        }


        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CadastrarClientes_Load(object sender, EventArgs e)
        {

        }

    }
