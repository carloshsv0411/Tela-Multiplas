namespace CarlosApp
{
    partial class ABAProject
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
            panelMenu = new Panel();
            panelLogo = new Panel();
            buttonProduto = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(buttonProduto);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 512);
            panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.ControlDarkDark;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.ForeColor = Color.Transparent;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 88);
            panelLogo.TabIndex = 1;
            // 
            // buttonProduto
            // 
            buttonProduto.BackColor = Color.FromArgb(64, 64, 64);
            buttonProduto.FlatAppearance.BorderSize = 0;
            buttonProduto.FlatStyle = FlatStyle.Flat;
            buttonProduto.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonProduto.ForeColor = Color.White;
            buttonProduto.Image = Properties.Resources.caixa;
            buttonProduto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProduto.Location = new Point(0, 87);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Padding = new Padding(12, 0, 0, 0);
            buttonProduto.Size = new Size(217, 73);
            buttonProduto.TabIndex = 2;
            buttonProduto.Text = "Produto";
            buttonProduto.UseCompatibleTextRendering = true;
            buttonProduto.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 166);
            button1.Name = "button1";
            button1.Size = new Size(220, 73);
            button1.TabIndex = 3;
            button1.Text = "Fornecedor";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 245);
            button2.Name = "button2";
            button2.Size = new Size(220, 73);
            button2.TabIndex = 4;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 324);
            button3.Name = "button3";
            button3.Size = new Size(220, 73);
            button3.TabIndex = 5;
            button3.Text = "Compras";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-3, 403);
            button4.Name = "button4";
            button4.Size = new Size(220, 73);
            button4.TabIndex = 6;
            button4.Text = "Vendas";
            button4.UseVisualStyleBackColor = false;
            // 
            // ABAProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 512);
            Controls.Add(panelMenu);
            Name = "ABAProject";
            Text = "ABAProject";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button buttonProduto;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}