namespace CarlosApp
{
    partial class CadastrarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarClientes));
            textBoxNomeCliente = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxEmail = new TextBox();
            labelNome = new Label();
            labelTelefone = new Label();
            labelEmail = new Label();
            buttonAdicionar = new Button();
            buttonCancel = new Button();
            groupBoxEndereco = new GroupBox();
            textBoxUF = new TextBox();
            textBoxCidade = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxCEP = new TextBox();
            textBoxNumeroRua = new TextBox();
            labelCEP = new Label();
            labelNumero = new Label();
            labelEstado = new Label();
            labelCidade = new Label();
            labelComplemento = new Label();
            textBoxLogadouro = new TextBox();
            labelLogadouro = new Label();
            groupBoxEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(208, 35);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(135, 23);
            textBoxNomeCliente.TabIndex = 0;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(208, 64);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(135, 23);
            textBoxTelefone.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(208, 96);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(135, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(137, 43);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(137, 72);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(54, 15);
            labelTelefone.TabIndex = 5;
            labelTelefone.Text = "Telefone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(137, 99);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 15);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "E-mail:";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(137, 414);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(85, 24);
            buttonAdicionar.TabIndex = 8;
            buttonAdicionar.Text = "Cadastrar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(340, 414);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 24);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // groupBoxEndereco
            // 
            groupBoxEndereco.BackColor = SystemColors.ActiveCaption;
            groupBoxEndereco.Controls.Add(textBoxUF);
            groupBoxEndereco.Controls.Add(textBoxCidade);
            groupBoxEndereco.Controls.Add(textBoxComplemento);
            groupBoxEndereco.Controls.Add(textBoxCEP);
            groupBoxEndereco.Controls.Add(textBoxNumeroRua);
            groupBoxEndereco.Controls.Add(labelCEP);
            groupBoxEndereco.Controls.Add(labelNumero);
            groupBoxEndereco.Controls.Add(labelEstado);
            groupBoxEndereco.Controls.Add(labelCidade);
            groupBoxEndereco.Controls.Add(labelComplemento);
            groupBoxEndereco.Controls.Add(textBoxLogadouro);
            groupBoxEndereco.Controls.Add(labelLogadouro);
            groupBoxEndereco.Location = new Point(137, 166);
            groupBoxEndereco.Name = "groupBoxEndereco";
            groupBoxEndereco.Size = new Size(293, 242);
            groupBoxEndereco.TabIndex = 10;
            groupBoxEndereco.TabStop = false;
            groupBoxEndereco.Text = "Endereço:";
            // 
            // textBoxUF
            // 
            textBoxUF.Location = new Point(124, 199);
            textBoxUF.Name = "textBoxUF";
            textBoxUF.Size = new Size(113, 23);
            textBoxUF.TabIndex = 11;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(124, 160);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(113, 23);
            textBoxCidade.TabIndex = 10;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(124, 120);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(114, 23);
            textBoxComplemento.TabIndex = 9;
            // 
            // textBoxCEP
            // 
            textBoxCEP.Location = new Point(124, 83);
            textBoxCEP.Name = "textBoxCEP";
            textBoxCEP.Size = new Size(114, 23);
            textBoxCEP.TabIndex = 8;
            // 
            // textBoxNumeroRua
            // 
            textBoxNumeroRua.Location = new Point(123, 48);
            textBoxNumeroRua.Name = "textBoxNumeroRua";
            textBoxNumeroRua.Size = new Size(115, 23);
            textBoxNumeroRua.TabIndex = 7;
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Location = new Point(16, 83);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(31, 15);
            labelCEP.TabIndex = 6;
            labelCEP.Text = "CEP:";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(15, 48);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(54, 15);
            labelNumero.TabIndex = 5;
            labelNumero.Text = "Numero:";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(15, 205);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(70, 15);
            labelEstado.TabIndex = 4;
            labelEstado.Text = "(UF) Estado:";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(16, 157);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(47, 15);
            labelCidade.TabIndex = 3;
            labelCidade.Text = "Cidade:";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(16, 120);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(87, 15);
            labelComplemento.TabIndex = 2;
            labelComplemento.Text = "Complemento:";
            // 
            // textBoxLogadouro
            // 
            textBoxLogadouro.HideSelection = false;
            textBoxLogadouro.Location = new Point(123, 19);
            textBoxLogadouro.Name = "textBoxLogadouro";
            textBoxLogadouro.Size = new Size(115, 23);
            textBoxLogadouro.TabIndex = 1;
            // 
            // labelLogadouro
            // 
            labelLogadouro.AutoSize = true;
            labelLogadouro.Location = new Point(15, 19);
            labelLogadouro.Name = "labelLogadouro";
            labelLogadouro.Size = new Size(99, 15);
            labelLogadouro.TabIndex = 0;
            labelLogadouro.Text = "Logadouro (Rua):";
            // 
            // CadastrarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(453, 450);
            Controls.Add(groupBoxEndereco);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdicionar);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefone);
            Controls.Add(labelNome);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxNomeCliente);
            Name = "CadastrarClientes";
            Text = "FormCadastrarClientes";
            Load += CadastrarClientes_Load;
            groupBoxEndereco.ResumeLayout(false);
            groupBoxEndereco.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNomeCliente;
        private TextBox textBoxTelefone;
        private TextBox textBoxEndreco;
        private TextBox textBoxEmail;
        private Label labelNome;
        private Label labelTelefone;
        private Label labelEmail;
        private Button buttonAdicionar;
        private Button buttonCancel;
        private GroupBox groupBoxEndereco;
        private Label labelLogadouro;
        private TextBox textBoxLogadouro;
        private Label labelNumero;
        private Label labelEstado;
        private Label labelCidade;
        private Label labelComplemento;
        private TextBox textBoxComplemento;
        private TextBox textBoxCEP;
        private TextBox textBoxNumeroRua;
        private Label labelCEP;
        private TextBox textBoxUF;
        private TextBox textBoxCidade;
    }
}