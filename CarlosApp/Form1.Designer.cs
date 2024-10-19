namespace CarlosApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            dataGridView1 = new DataGridView();
            buttonProdutos = new Button();
            buttonClientes = new Button();
            buttonFornecedores = new Button();
            buttonAdicionarCliente = new Button();
            buttonAdicionarF = new Button();
            buttonAdicionarC = new Button();
            buttonAdicionarV = new Button();
            buttonRemoverClientes = new Button();
            buttonRemoverF = new Button();
            buttonRemoverC = new Button();
            buttonRemoverV = new Button();
            buttonCompra = new Button();
            buttonVendas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.White;
            buttonAdicionar.BackgroundImageLayout = ImageLayout.Center;
            buttonAdicionar.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdicionar.ForeColor = SystemColors.ControlText;
            buttonAdicionar.Location = new Point(15, 61);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(98, 23);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += button1_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackColor = Color.FromArgb(64, 0, 0);
            buttonRemover.FlatStyle = FlatStyle.Flat;
            buttonRemover.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRemover.ForeColor = SystemColors.ButtonFace;
            buttonRemover.Location = new Point(15, 90);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(98, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = false;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(12, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(848, 416);
            dataGridView1.TabIndex = 2;
            // 
            // buttonProdutos
            // 
            buttonProdutos.BackColor = Color.DimGray;
            buttonProdutos.BackgroundImageLayout = ImageLayout.None;
            buttonProdutos.FlatStyle = FlatStyle.Popup;
            buttonProdutos.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonProdutos.Image = (Image)resources.GetObject("buttonProdutos.Image");
            buttonProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProdutos.Location = new Point(15, 7);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(98, 48);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.TextAlign = ContentAlignment.MiddleRight;
            buttonProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProdutos.UseVisualStyleBackColor = false;
            buttonProdutos.Click += button1_Click_1;
            // 
            // buttonClientes
            // 
            buttonClientes.BackColor = Color.Gray;
            buttonClientes.FlatStyle = FlatStyle.Popup;
            buttonClientes.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonClientes.Image = (Image)resources.GetObject("buttonClientes.Image");
            buttonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClientes.Location = new Point(130, 6);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(105, 48);
            buttonClientes.TabIndex = 4;
            buttonClientes.Text = "Clientes";
            buttonClientes.TextAlign = ContentAlignment.MiddleRight;
            buttonClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClientes.UseMnemonic = false;
            buttonClientes.UseVisualStyleBackColor = false;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.BackColor = Color.Gray;
            buttonFornecedores.BackgroundImageLayout = ImageLayout.None;
            buttonFornecedores.FlatStyle = FlatStyle.Popup;
            buttonFornecedores.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonFornecedores.Image = (Image)resources.GetObject("buttonFornecedores.Image");
            buttonFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFornecedores.Location = new Point(242, 7);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(121, 48);
            buttonFornecedores.TabIndex = 5;
            buttonFornecedores.Text = "Fornecedores";
            buttonFornecedores.TextAlign = ContentAlignment.MiddleRight;
            buttonFornecedores.UseVisualStyleBackColor = false;
            buttonFornecedores.Click += buttonFornecedores_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.BackColor = Color.White;
            buttonAdicionarCliente.BackgroundImageLayout = ImageLayout.Center;
            buttonAdicionarCliente.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdicionarCliente.ForeColor = SystemColors.ControlText;
            buttonAdicionarCliente.Location = new Point(130, 61);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(106, 23);
            buttonAdicionarCliente.TabIndex = 6;
            buttonAdicionarCliente.Text = "Adicionar";
            buttonAdicionarCliente.UseVisualStyleBackColor = false;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonAdicionarF
            // 
            buttonAdicionarF.BackColor = Color.White;
            buttonAdicionarF.BackgroundImageLayout = ImageLayout.Center;
            buttonAdicionarF.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdicionarF.ForeColor = SystemColors.ControlText;
            buttonAdicionarF.Location = new Point(242, 61);
            buttonAdicionarF.Name = "buttonAdicionarF";
            buttonAdicionarF.Size = new Size(121, 23);
            buttonAdicionarF.TabIndex = 7;
            buttonAdicionarF.Text = "Adicionar";
            buttonAdicionarF.UseVisualStyleBackColor = false;
            buttonAdicionarF.Click += buttonAdicionarF_Click;
            // 
            // buttonAdicionarC
            // 
            buttonAdicionarC.BackColor = Color.White;
            buttonAdicionarC.BackgroundImageLayout = ImageLayout.Center;
            buttonAdicionarC.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdicionarC.ForeColor = SystemColors.ControlText;
            buttonAdicionarC.Location = new Point(369, 61);
            buttonAdicionarC.Name = "buttonAdicionarC";
            buttonAdicionarC.Size = new Size(106, 23);
            buttonAdicionarC.TabIndex = 8;
            buttonAdicionarC.Text = "Adicionar";
            buttonAdicionarC.UseVisualStyleBackColor = false;
            buttonAdicionarC.Click += buttonAdicionarC_Click;
            // 
            // buttonAdicionarV
            // 
            buttonAdicionarV.BackColor = Color.White;
            buttonAdicionarV.BackgroundImageLayout = ImageLayout.Center;
            buttonAdicionarV.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdicionarV.ForeColor = SystemColors.ControlText;
            buttonAdicionarV.Location = new Point(495, 61);
            buttonAdicionarV.Name = "buttonAdicionarV";
            buttonAdicionarV.Size = new Size(102, 23);
            buttonAdicionarV.TabIndex = 9;
            buttonAdicionarV.Text = "Adicionar";
            buttonAdicionarV.UseVisualStyleBackColor = false;
            // 
            // buttonRemoverClientes
            // 
            buttonRemoverClientes.BackColor = Color.FromArgb(64, 0, 0);
            buttonRemoverClientes.FlatStyle = FlatStyle.Flat;
            buttonRemoverClientes.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRemoverClientes.ForeColor = SystemColors.ButtonFace;
            buttonRemoverClientes.Location = new Point(130, 90);
            buttonRemoverClientes.Name = "buttonRemoverClientes";
            buttonRemoverClientes.Size = new Size(106, 23);
            buttonRemoverClientes.TabIndex = 10;
            buttonRemoverClientes.Text = "Remover";
            buttonRemoverClientes.UseVisualStyleBackColor = false;
            buttonRemoverClientes.Click += buttonRemoverClientes_Click;
            // 
            // buttonRemoverF
            // 
            buttonRemoverF.BackColor = Color.FromArgb(64, 0, 0);
            buttonRemoverF.FlatStyle = FlatStyle.Flat;
            buttonRemoverF.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRemoverF.ForeColor = SystemColors.ButtonHighlight;
            buttonRemoverF.Location = new Point(242, 90);
            buttonRemoverF.Name = "buttonRemoverF";
            buttonRemoverF.Size = new Size(121, 23);
            buttonRemoverF.TabIndex = 11;
            buttonRemoverF.Text = "Remover";
            buttonRemoverF.UseVisualStyleBackColor = false;
            buttonRemoverF.Click += buttonRemoverF_Click;
            // 
            // buttonRemoverC
            // 
            buttonRemoverC.BackColor = Color.FromArgb(64, 0, 0);
            buttonRemoverC.FlatStyle = FlatStyle.Flat;
            buttonRemoverC.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRemoverC.ForeColor = SystemColors.ButtonHighlight;
            buttonRemoverC.Location = new Point(369, 90);
            buttonRemoverC.Name = "buttonRemoverC";
            buttonRemoverC.Size = new Size(106, 23);
            buttonRemoverC.TabIndex = 12;
            buttonRemoverC.Text = "Remover";
            buttonRemoverC.UseVisualStyleBackColor = false;
            buttonRemoverC.Click += buttonRemoverC_Click;
            // 
            // buttonRemoverV
            // 
            buttonRemoverV.BackColor = Color.FromArgb(64, 0, 0);
            buttonRemoverV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRemoverV.FlatStyle = FlatStyle.Flat;
            buttonRemoverV.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRemoverV.ForeColor = SystemColors.ButtonHighlight;
            buttonRemoverV.Location = new Point(495, 90);
            buttonRemoverV.Name = "buttonRemoverV";
            buttonRemoverV.Size = new Size(102, 23);
            buttonRemoverV.TabIndex = 13;
            buttonRemoverV.Text = "Remover";
            buttonRemoverV.UseVisualStyleBackColor = false;
            // 
            // buttonCompra
            // 
            buttonCompra.BackColor = Color.Gray;
            buttonCompra.FlatStyle = FlatStyle.Popup;
            buttonCompra.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonCompra.Image = (Image)resources.GetObject("buttonCompra.Image");
            buttonCompra.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCompra.Location = new Point(369, 7);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(106, 48);
            buttonCompra.TabIndex = 14;
            buttonCompra.Text = "Compras";
            buttonCompra.TextAlign = ContentAlignment.MiddleRight;
            buttonCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCompra.UseVisualStyleBackColor = false;
            buttonCompra.Click += buttonCompra_Click_1;
            // 
            // buttonVendas
            // 
            buttonVendas.BackColor = Color.Gray;
            buttonVendas.FlatStyle = FlatStyle.Popup;
            buttonVendas.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonVendas.Image = (Image)resources.GetObject("buttonVendas.Image");
            buttonVendas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVendas.Location = new Point(495, 7);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(102, 48);
            buttonVendas.TabIndex = 15;
            buttonVendas.Text = "Vendas";
            buttonVendas.TextAlign = ContentAlignment.MiddleRight;
            buttonVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVendas.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImage = Properties.Resources.images__3_;
            ClientSize = new Size(947, 529);
            Controls.Add(buttonVendas);
            Controls.Add(buttonCompra);
            Controls.Add(buttonRemoverV);
            Controls.Add(buttonRemoverC);
            Controls.Add(buttonRemoverF);
            Controls.Add(buttonRemoverClientes);
            Controls.Add(buttonAdicionarV);
            Controls.Add(buttonAdicionarC);
            Controls.Add(buttonAdicionarF);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttonFornecedores);
            Controls.Add(buttonClientes);
            Controls.Add(buttonProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Projeto1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private DataGridView dataGridView1;
        private Button buttonProdutos;
        private Button buttonClientes;
        private Button buttonFornecedores;
        private Button buttonAdicionarCliente;
        private Button buttonAdicionarF;
        private Button buttonAdicionarC;
        private Button buttonAdicionarV;
        private Button buttonRemoverClientes;
        private Button buttonRemoverF;
        private Button buttonRemoverC;
        private Button buttonRemoverV;
        private Button buttonCompra;
        private Button buttonVendas;
    }
}
