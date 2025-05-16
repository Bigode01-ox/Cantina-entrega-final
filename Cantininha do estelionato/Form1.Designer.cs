namespace Cantininha_do_estelionato
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnAdicionar = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Total = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.SaddleBrown;
            listBox1.ForeColor = Color.Silver;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Pão de quijo - R$3,50", "Coxinha         -R$5,00", "Pastel" });
            listBox1.Location = new Point(27, 148);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(207, 109);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.SaddleBrown;
            listBox2.ForeColor = Color.Silver;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(557, 148);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(212, 109);
            listBox2.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SaddleBrown;
            btnAdicionar.ForeColor = Color.Silver;
            btnAdicionar.Location = new Point(303, 148);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(82, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(423, 148);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 3;
            button2.Text = "REMOVER";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SaddleBrown;
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(27, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "PRODUTOS DA CANTINA BIGODE:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SaddleBrown;
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(557, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "CARRINHO:";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.BackColor = Color.SaddleBrown;
            Total.ForeColor = Color.Silver;
            Total.Location = new Point(365, 331);
            Total.Name = "Total";
            Total.Size = new Size(81, 15);
            Total.TabIndex = 6;
            Total.Text = "TOTAL: R$0,00";
            Total.Click += PreçoTotal_click;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(303, 366);
            button1.Name = "button1";
            button1.Size = new Size(202, 34);
            button1.TabIndex = 7;
            button1.Text = "FECHAR PEDIDO";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Total);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(btnAdicionar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAdicionar;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Total;
        private Button button1;
    }
}
