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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackgroundImage = Properties.Resources.tecnologia_moderna;
            buttonAdicionar.BackgroundImageLayout = ImageLayout.Center;
            buttonAdicionar.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdicionar.ForeColor = SystemColors.ControlText;
            buttonAdicionar.Location = new Point(15, 39);
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
            buttonRemover.Location = new Point(119, 39);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(85, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(565, 402);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(947, 529);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            Text = "Projeto1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private DataGridView dataGridView1;
    }
}
