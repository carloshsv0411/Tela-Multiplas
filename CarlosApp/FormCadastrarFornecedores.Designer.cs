namespace CarlosApp
{
    partial class FormCadastrarFornecedores
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
            buttonCancel = new Button();
            buttonOK = new Button();
            textBoxEmpresaFornece = new TextBox();
            textBoxCNPJFornece = new TextBox();
            textBoxContatoFornece = new TextBox();
            textBoxTelefoneFornece = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Nome = new Label();
            label4 = new Label();
            label5 = new Label();
            Endereço = new GroupBox();
            textBoxCEPf = new TextBox();
            textBoxNumeroFornece = new TextBox();
            textBoxEstadoF = new TextBox();
            textBoxLogradouroFornece = new TextBox();
            textBoxCidadeF = new TextBox();
            label11 = new Label();
            textBoxComplementoF = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxEmailF = new TextBox();
            Endereço.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(267, 438);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(74, 24);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(69, 435);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(46, 30);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // textBoxEmpresaFornece
            // 
            textBoxEmpresaFornece.Location = new Point(203, 19);
            textBoxEmpresaFornece.Name = "textBoxEmpresaFornece";
            textBoxEmpresaFornece.Size = new Size(109, 23);
            textBoxEmpresaFornece.TabIndex = 2;
            // 
            // textBoxCNPJFornece
            // 
            textBoxCNPJFornece.Location = new Point(203, 56);
            textBoxCNPJFornece.Name = "textBoxCNPJFornece";
            textBoxCNPJFornece.Size = new Size(109, 23);
            textBoxCNPJFornece.TabIndex = 3;
            // 
            // textBoxContatoFornece
            // 
            textBoxContatoFornece.Location = new Point(203, 91);
            textBoxContatoFornece.Name = "textBoxContatoFornece";
            textBoxContatoFornece.Size = new Size(109, 23);
            textBoxContatoFornece.TabIndex = 4;
            // 
            // textBoxTelefoneFornece
            // 
            textBoxTelefoneFornece.Location = new Point(203, 124);
            textBoxTelefoneFornece.Name = "textBoxTelefoneFornece";
            textBoxTelefoneFornece.Size = new Size(109, 23);
            textBoxTelefoneFornece.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome da Empresa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 59);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "CNPJ:";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(68, 94);
            Nome.Name = "Nome";
            Nome.Size = new Size(115, 15);
            Nome.TabIndex = 8;
            Nome.Text = "Nome para Contato:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 127);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 156);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "E-mail:";
            // 
            // Endereço
            // 
            Endereço.BackgroundImage = Properties.Resources.brasil;
            Endereço.BackgroundImageLayout = ImageLayout.None;
            Endereço.Controls.Add(textBoxCEPf);
            Endereço.Controls.Add(textBoxNumeroFornece);
            Endereço.Controls.Add(textBoxEstadoF);
            Endereço.Controls.Add(textBoxLogradouroFornece);
            Endereço.Controls.Add(textBoxCidadeF);
            Endereço.Controls.Add(label11);
            Endereço.Controls.Add(textBoxComplementoF);
            Endereço.Controls.Add(label10);
            Endereço.Controls.Add(label9);
            Endereço.Controls.Add(label6);
            Endereço.Controls.Add(label7);
            Endereço.Controls.Add(label8);
            Endereço.FlatStyle = FlatStyle.Popup;
            Endereço.Location = new Point(68, 195);
            Endereço.Name = "Endereço";
            Endereço.Size = new Size(273, 233);
            Endereço.TabIndex = 12;
            Endereço.TabStop = false;
            Endereço.Text = "Endereço:";
            // 
            // textBoxCEPf
            // 
            textBoxCEPf.Location = new Point(125, 158);
            textBoxCEPf.Name = "textBoxCEPf";
            textBoxCEPf.Size = new Size(100, 23);
            textBoxCEPf.TabIndex = 16;
            // 
            // textBoxNumeroFornece
            // 
            textBoxNumeroFornece.Location = new Point(125, 52);
            textBoxNumeroFornece.Name = "textBoxNumeroFornece";
            textBoxNumeroFornece.Size = new Size(100, 23);
            textBoxNumeroFornece.TabIndex = 17;
            // 
            // textBoxEstadoF
            // 
            textBoxEstadoF.Location = new Point(125, 129);
            textBoxEstadoF.Name = "textBoxEstadoF";
            textBoxEstadoF.Size = new Size(100, 23);
            textBoxEstadoF.TabIndex = 15;
            // 
            // textBoxLogradouroFornece
            // 
            textBoxLogradouroFornece.Location = new Point(125, 23);
            textBoxLogradouroFornece.Name = "textBoxLogradouroFornece";
            textBoxLogradouroFornece.Size = new Size(100, 23);
            textBoxLogradouroFornece.TabIndex = 18;
            // 
            // textBoxCidadeF
            // 
            textBoxCidadeF.Location = new Point(125, 102);
            textBoxCidadeF.Name = "textBoxCidadeF";
            textBoxCidadeF.Size = new Size(100, 23);
            textBoxCidadeF.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 137);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 18;
            label11.Text = "(UF) Estado:";
            // 
            // textBoxComplementoF
            // 
            textBoxComplementoF.Location = new Point(125, 78);
            textBoxComplementoF.Name = "textBoxComplementoF";
            textBoxComplementoF.Size = new Size(100, 23);
            textBoxComplementoF.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 166);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 17;
            label10.Text = "CEP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 110);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 16;
            label9.Text = "Cidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 31);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 13;
            label6.Text = "Logradouro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 86);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 14;
            label7.Text = "Complemento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 60);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 15;
            label8.Text = "Numero:";
            // 
            // textBoxEmailF
            // 
            textBoxEmailF.Location = new Point(203, 156);
            textBoxEmailF.Name = "textBoxEmailF";
            textBoxEmailF.Size = new Size(109, 23);
            textBoxEmailF.TabIndex = 13;
            // 
            // FormCadastrarFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.brasil;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(387, 477);
            Controls.Add(textBoxEmailF);
            Controls.Add(Endereço);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTelefoneFornece);
            Controls.Add(textBoxContatoFornece);
            Controls.Add(textBoxCNPJFornece);
            Controls.Add(textBoxEmpresaFornece);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Name = "FormCadastrarFornecedores";
            Text = "FormCadastrarFornecedores";
            Load += FormCadastrarFornecedores_Load;
            Endereço.ResumeLayout(false);
            Endereço.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonOK;
        private TextBox textBoxEmpresaFornece;
        private TextBox textBoxCNPJFornece;
        private TextBox textBoxContatoFornece;
        private TextBox textBoxTelefoneFornece;
        private Label label1;
        private Label label2;
        private Label Nome;
        private Label label4;
        private Label label5;
        private GroupBox Endereço;
        private TextBox textBoxCEPf;
        private TextBox textBoxNumeroFornece;
        private TextBox textBoxEstadoF;
        private TextBox textBoxLogradouroFornece;
        private TextBox textBoxCidadeF;
        private Label label11;
        private TextBox textBoxComplementoF;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxEmailF;
    }
}