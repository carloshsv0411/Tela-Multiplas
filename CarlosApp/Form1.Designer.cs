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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            buttonCompra = new Button();
            buttonVendas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackgroundImage = Properties.Resources.tecnologia_moderna;
            buttonAdicionar.BackgroundImageLayout = ImageLayout.Center;
            buttonAdicionar.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdicionar.ForeColor = SystemColors.ControlText;
            buttonAdicionar.Location = new Point(15, 61);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(98, 23);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += button1_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackgroundImage = Properties.Resources.tecnologia_moderna;
            buttonRemover.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRemover.Location = new Point(15, 90);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(98, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 402);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonProdutos
            // 
            buttonProdutos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonProdutos.Location = new Point(15, 7);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(98, 44);
            buttonProdutos.TabIndex = 3;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += button1_Click_1;
            // 
            // buttonClientes
            // 
            buttonClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonClientes.Location = new Point(130, 8);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(106, 47);
            buttonClientes.TabIndex = 4;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseMnemonic = false;
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonFornecedores
            // 
            buttonFornecedores.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonFornecedores.Location = new Point(242, 7);
            buttonFornecedores.Name = "buttonFornecedores";
            buttonFornecedores.Size = new Size(121, 48);
            buttonFornecedores.TabIndex = 5;
            buttonFornecedores.Text = "Fornecedores";
            buttonFornecedores.UseVisualStyleBackColor = true;
            buttonFornecedores.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.tecnologia_moderna;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(130, 61);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 6;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.tecnologia_moderna;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(257, 61);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 7;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.tecnologia_moderna;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(369, 61);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 8;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.tecnologia_moderna;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(495, 61);
            button4.Name = "button4";
            button4.Size = new Size(102, 23);
            button4.TabIndex = 9;
            button4.Text = "Adicionar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.tecnologia_moderna;
            button5.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(130, 90);
            button5.Name = "button5";
            button5.Size = new Size(106, 23);
            button5.TabIndex = 10;
            button5.Text = "Remover";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.tecnologia_moderna;
            button6.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.Location = new Point(257, 90);
            button6.Name = "button6";
            button6.Size = new Size(106, 23);
            button6.TabIndex = 11;
            button6.Text = "Remover";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.tecnologia_moderna;
            button7.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button7.Location = new Point(369, 90);
            button7.Name = "button7";
            button7.Size = new Size(106, 23);
            button7.TabIndex = 12;
            button7.Text = "Remover";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources.tecnologia_moderna;
            button8.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button8.Location = new Point(495, 86);
            button8.Name = "button8";
            button8.Size = new Size(102, 23);
            button8.TabIndex = 13;
            button8.Text = "Remover";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // buttonCompra
            // 
            buttonCompra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonCompra.Location = new Point(369, 7);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(106, 48);
            buttonCompra.TabIndex = 14;
            buttonCompra.Text = "Compras";
            buttonCompra.UseVisualStyleBackColor = true;
            buttonCompra.Click += buttonCompra_Click;
            // 
            // buttonVendas
            // 
            buttonVendas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonVendas.Location = new Point(495, 7);
            buttonVendas.Name = "buttonVendas";
            buttonVendas.Size = new Size(102, 52);
            buttonVendas.TabIndex = 15;
            buttonVendas.Text = "Vendas";
            buttonVendas.UseVisualStyleBackColor = true;
            buttonVendas.Click += buttonVendas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(947, 529);
            Controls.Add(buttonVendas);
            Controls.Add(buttonCompra);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonFornecedores);
            Controls.Add(buttonClientes);
            Controls.Add(buttonProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button buttonCompra;
        private Button buttonVendas;
    }
}
