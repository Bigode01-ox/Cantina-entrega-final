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
            btnRemover = new Button();
            Total = new Label();
            btnFecharpedido = new Button();
            nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pagamento = new ComboBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            numero = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.Off;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(27, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(207, 229);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.ForeColor = Color.Black;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(557, 124);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(212, 229);
            listBox2.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(128, 255, 128);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(303, 124);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(178, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "ADICIONAR PRODUTO";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(128, 255, 128);
            btnRemover.ForeColor = Color.Black;
            btnRemover.Location = new Point(303, 153);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(178, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "REMOVER PRODUTO";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.BackColor = Color.FromArgb(128, 255, 128);
            Total.ForeColor = Color.Black;
            Total.Location = new Point(321, 327);
            Total.Name = "Total";
            Total.Size = new Size(86, 15);
            Total.TabIndex = 6;
            Total.Text = " VALOR TOTAL:";
            Total.Click += PreçoTotal_click;
            // 
            // btnFecharpedido
            // 
            btnFecharpedido.BackColor = Color.FromArgb(128, 255, 128);
            btnFecharpedido.ForeColor = Color.Black;
            btnFecharpedido.Location = new Point(288, 368);
            btnFecharpedido.Name = "btnFecharpedido";
            btnFecharpedido.Size = new Size(202, 34);
            btnFecharpedido.TabIndex = 7;
            btnFecharpedido.Text = "FECHAR PEDIDO";
            btnFecharpedido.UseVisualStyleBackColor = false;
            btnFecharpedido.Click += btnFecharpedido_Click;
            // 
            // nome
            // 
            nome.ForeColor = Color.Black;
            nome.Location = new Point(303, 207);
            nome.Multiline = true;
            nome.Name = "nome";
            nome.Size = new Size(178, 23);
            nome.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 93);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 9;
            label1.Text = "PRODUTOS DISPONIVEIS PARA VENDA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 128);
            label2.Location = new Point(560, 93);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 10;
            label2.Text = "COMANDA                                             ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 255, 128);
            label3.Location = new Point(367, 189);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "Nome";
            // 
            // pagamento
            // 
            pagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            pagamento.FormattingEnabled = true;
            pagamento.Items.AddRange(new object[] { "Dinheiro", "Cartão", "Pix" });
            pagamento.Location = new Point(303, 258);
            pagamento.Name = "pagamento";
            pagamento.Size = new Size(178, 23);
            pagamento.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(335, 240);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 13;
            label4.Text = "Forma de Pagamento";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(30, 368);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(204, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(128, 255, 128);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(418, 338);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 15;
            // 
            // numero
            // 
            numero.AutoSize = true;
            numero.BackColor = Color.FromArgb(128, 255, 128);
            numero.Location = new Point(404, 327);
            numero.Name = "numero";
            numero.Size = new Size(28, 15);
            numero.TabIndex = 16;
            numero.Text = "0,00";
            numero.Click += numero_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numero);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(pagamento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nome);
            Controls.Add(btnFecharpedido);
            Controls.Add(Total);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAdicionar;
        private Button btnRemover;
        private Label Total;
        private Button btnFecharpedido;
        private TextBox nome;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox pagamento;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label numero;
    }
}
