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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            txtQuantidade = new NumericUpDown();
            label5 = new Label();
            numero = new Label();
            txtdinheiro = new TextBox();
            txttroco = new Label();
            button1 = new Button();
            btnparaviagem = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Silver;
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.Off;
            listBox1.Location = new Point(118, 4);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(239, 244);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Silver;
            listBox2.ForeColor = Color.Black;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(118, 363);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(239, 224);
            listBox2.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Silver;
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(363, 4);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(203, 40);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "ADICIONAR PRODUTO";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Silver;
            btnRemover.ForeColor = Color.Black;
            btnRemover.Location = new Point(367, 363);
            btnRemover.Margin = new Padding(3, 4, 3, 4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(203, 40);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "REMOVER PRODUTO";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.BackColor = Color.GreenYellow;
            Total.ForeColor = Color.Black;
            Total.Location = new Point(379, 478);
            Total.Name = "Total";
            Total.Size = new Size(105, 20);
            Total.TabIndex = 6;
            Total.Text = " VALOR TOTAL:";
            Total.Click += PreçoTotal_click;
            // 
            // btnFecharpedido
            // 
            btnFecharpedido.BackColor = Color.Silver;
            btnFecharpedido.ForeColor = Color.Black;
            btnFecharpedido.Location = new Point(760, 491);
            btnFecharpedido.Margin = new Padding(3, 4, 3, 4);
            btnFecharpedido.Name = "btnFecharpedido";
            btnFecharpedido.Size = new Size(142, 44);
            btnFecharpedido.TabIndex = 7;
            btnFecharpedido.Text = "FECHAR PEDIDO";
            btnFecharpedido.UseVisualStyleBackColor = false;
            btnFecharpedido.Click += btnFecharpedido_Click;
            // 
            // nome
            // 
            nome.BackColor = Color.Silver;
            nome.ForeColor = Color.Black;
            nome.Location = new Point(367, 196);
            nome.Margin = new Padding(3, 4, 3, 4);
            nome.Multiline = true;
            nome.Name = "nome";
            nome.Size = new Size(203, 29);
            nome.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GreenYellow;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 9;
            label1.Text = "PRODUTOS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.GreenYellow;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(10, 383);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 10;
            label2.Text = "COMANDA ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GreenYellow;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(438, 172);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "Nome";
            // 
            // pagamento
            // 
            pagamento.BackColor = Color.Silver;
            pagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            pagamento.ForeColor = Color.Black;
            pagamento.FormattingEnabled = true;
            pagamento.Items.AddRange(new object[] { "Dinheiro", "Cartão", "Pix" });
            pagamento.Location = new Point(643, 187);
            pagamento.Margin = new Padding(3, 4, 3, 4);
            pagamento.Name = "pagamento";
            pagamento.Size = new Size(203, 28);
            pagamento.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.GreenYellow;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(668, 163);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 13;
            label4.Text = "Forma de Pagamento";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.Silver;
            txtQuantidade.ForeColor = Color.Black;
            txtQuantidade.Location = new Point(367, 113);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(171, 27);
            txtQuantidade.TabIndex = 14;
            txtQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantidade.ValueChanged += txtQuantidade_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(128, 255, 128);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(478, 451);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 15;
            // 
            // numero
            // 
            numero.AutoSize = true;
            numero.BackColor = Color.GreenYellow;
            numero.ForeColor = Color.Black;
            numero.Location = new Point(478, 478);
            numero.Name = "numero";
            numero.Size = new Size(36, 20);
            numero.TabIndex = 16;
            numero.Text = "0,00";
            numero.Click += numero_Click;
            // 
            // txtdinheiro
            // 
            txtdinheiro.BackColor = Color.Silver;
            txtdinheiro.Location = new Point(363, 562);
            txtdinheiro.Margin = new Padding(3, 4, 3, 4);
            txtdinheiro.Name = "txtdinheiro";
            txtdinheiro.Size = new Size(203, 27);
            txtdinheiro.TabIndex = 17;
            txtdinheiro.TextChanged += txtdinheiro_TextChanged;
            // 
            // txttroco
            // 
            txttroco.AutoSize = true;
            txttroco.BackColor = Color.GreenYellow;
            txttroco.ForeColor = Color.Black;
            txttroco.Location = new Point(438, 543);
            txttroco.Name = "txttroco";
            txttroco.Size = new Size(46, 20);
            txttroco.TabIndex = 18;
            txttroco.Text = "Troco";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(760, 543);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 20;
            button1.Text = "IR PARA BALCÂO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnparaviagem
            // 
            btnparaviagem.AutoSize = true;
            btnparaviagem.BackColor = Color.Silver;
            btnparaviagem.ForeColor = Color.Black;
            btnparaviagem.Location = new Point(790, 447);
            btnparaviagem.Margin = new Padding(3, 4, 3, 4);
            btnparaviagem.Name = "btnparaviagem";
            btnparaviagem.Size = new Size(112, 24);
            btnparaviagem.TabIndex = 21;
            btnparaviagem.Text = "Para viagem";
            btnparaviagem.UseVisualStyleBackColor = false;
            btnparaviagem.CheckedChanged += btnparaviagem_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(btnparaviagem);
            Controls.Add(button1);
            Controls.Add(txttroco);
            Controls.Add(txtdinheiro);
            Controls.Add(numero);
            Controls.Add(label5);
            Controls.Add(txtQuantidade);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
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
        private NumericUpDown txtQuantidade;
        private Label label5;
        private Label numero;
        private TextBox txtdinheiro;
        private Label txttroco;
        private Button button1;
        private CheckBox btnparaviagem;
    }
}
