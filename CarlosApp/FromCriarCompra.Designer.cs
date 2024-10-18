namespace CarlosApp
{
    partial class FromCriarCompra
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
            buttonComprar = new Button();
            buttonCancelarCompra = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxPrecoU = new TextBox();
            textBoxValorTT = new TextBox();
            textBoxTotalDesconto = new TextBox();
            comboBoxProdC = new ComboBox();
            comboBoxForC = new ComboBox();
            numericUpDownQC = new NumericUpDown();
            numericUpDownDC = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDC).BeginInit();
            SuspendLayout();
            // 
            // buttonComprar
            // 
            buttonComprar.Location = new Point(34, 316);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(75, 23);
            buttonComprar.TabIndex = 0;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // buttonCancelarCompra
            // 
            buttonCancelarCompra.Location = new Point(199, 316);
            buttonCancelarCompra.Name = "buttonCancelarCompra";
            buttonCancelarCompra.Size = new Size(75, 23);
            buttonCancelarCompra.TabIndex = 1;
            buttonCancelarCompra.Text = "Cancelar ";
            buttonCancelarCompra.UseVisualStyleBackColor = true;
            buttonCancelarCompra.Click += buttonCancelarCompra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 61);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 94);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 127);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 5;
            label4.Text = "Desconto(%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 174);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 6;
            label5.Text = "Preço Unitário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 212);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 7;
            label6.Text = "Valor Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 261);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 8;
            label7.Text = "Total Com Desconto:";
            // 
            // textBoxPrecoU
            // 
            textBoxPrecoU.BackColor = Color.DimGray;
            textBoxPrecoU.Location = new Point(153, 171);
            textBoxPrecoU.Name = "textBoxPrecoU";
            textBoxPrecoU.ReadOnly = true;
            textBoxPrecoU.Size = new Size(120, 23);
            textBoxPrecoU.TabIndex = 9;
            // 
            // textBoxValorTT
            // 
            textBoxValorTT.BackColor = Color.DimGray;
            textBoxValorTT.Location = new Point(153, 212);
            textBoxValorTT.Name = "textBoxValorTT";
            textBoxValorTT.ReadOnly = true;
            textBoxValorTT.Size = new Size(121, 23);
            textBoxValorTT.TabIndex = 10;
            // 
            // textBoxTotalDesconto
            // 
            textBoxTotalDesconto.BackColor = Color.DimGray;
            textBoxTotalDesconto.Location = new Point(154, 258);
            textBoxTotalDesconto.Name = "textBoxTotalDesconto";
            textBoxTotalDesconto.ReadOnly = true;
            textBoxTotalDesconto.Size = new Size(119, 23);
            textBoxTotalDesconto.TabIndex = 11;
            // 
            // comboBoxProdC
            // 
            comboBoxProdC.FormattingEnabled = true;
            comboBoxProdC.Location = new Point(153, 16);
            comboBoxProdC.Name = "comboBoxProdC";
            comboBoxProdC.Size = new Size(121, 23);
            comboBoxProdC.TabIndex = 16;
            comboBoxProdC.SelectedIndexChanged += comboBoxProdC_SelectedIndexChanged;
            // 
            // comboBoxForC
            // 
            comboBoxForC.FormattingEnabled = true;
            comboBoxForC.Location = new Point(153, 53);
            comboBoxForC.Name = "comboBoxForC";
            comboBoxForC.Size = new Size(121, 23);
            comboBoxForC.TabIndex = 17;
            // 
            // numericUpDownQC
            // 
            numericUpDownQC.Location = new Point(154, 92);
            numericUpDownQC.Name = "numericUpDownQC";
            numericUpDownQC.Size = new Size(120, 23);
            numericUpDownQC.TabIndex = 18;
            numericUpDownQC.ValueChanged += numericUpDownQC_ValueChanged;
            // 
            // numericUpDownDC
            // 
            numericUpDownDC.Location = new Point(153, 127);
            numericUpDownDC.Name = "numericUpDownDC";
            numericUpDownDC.Size = new Size(120, 23);
            numericUpDownDC.TabIndex = 19;
            numericUpDownDC.ValueChanged += numericUpDownDC_ValueChanged;
            // 
            // FromCriarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownDC);
            Controls.Add(numericUpDownQC);
            Controls.Add(comboBoxForC);
            Controls.Add(comboBoxProdC);
            Controls.Add(textBoxTotalDesconto);
            Controls.Add(textBoxValorTT);
            Controls.Add(textBoxPrecoU);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelarCompra);
            Controls.Add(buttonComprar);
            Name = "FromCriarCompra";
            Text = "FromCriarCompra";
            Load += FromCriarCompra_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQC).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonComprar;
        private Button buttonCancelarCompra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxPrecoU;
        private TextBox textBoxValorTT;
        private TextBox textBoxTotalDesconto;
        private ComboBox comboBoxProdC;
        private ComboBox comboBoxForC;
        private NumericUpDown numericUpDownQC;
        private NumericUpDown numericUpDownDC;
    }
}