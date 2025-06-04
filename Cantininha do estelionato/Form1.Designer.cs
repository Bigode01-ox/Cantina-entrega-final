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
            btnviagem = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(120, 118, 100);
            listBox1.ForeColor = Color.GreenYellow;
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.Off;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(27, 151);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(210, 229);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(120, 118, 100);
            listBox2.ForeColor = Color.GreenYellow;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(560, 151);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(212, 229);
            listBox2.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Gray;
            btnAdicionar.ForeColor = Color.GreenYellow;
            btnAdicionar.Location = new Point(303, 113);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(178, 30);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "ADICIONAR PRODUTO";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Gray;
            btnRemover.ForeColor = Color.GreenYellow;
            btnRemover.Location = new Point(303, 153);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(178, 33);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "REMOVER PRODUTO";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.BackColor = Color.Gray;
            Total.ForeColor = Color.GreenYellow;
            Total.Location = new Point(321, 338);
            Total.Name = "Total";
            Total.Size = new Size(86, 15);
            Total.TabIndex = 6;
            Total.Text = " VALOR TOTAL:";
            Total.Click += PreçoTotal_click;
            // 
            // btnFecharpedido
            // 
            btnFecharpedido.BackColor = Color.Gray;
            btnFecharpedido.ForeColor = Color.GreenYellow;
            btnFecharpedido.Location = new Point(293, 356);
            btnFecharpedido.Name = "btnFecharpedido";
            btnFecharpedido.Size = new Size(202, 43);
            btnFecharpedido.TabIndex = 7;
            btnFecharpedido.Text = "FECHAR PEDIDO";
            btnFecharpedido.UseVisualStyleBackColor = false;
            btnFecharpedido.Click += btnFecharpedido_Click;
            // 
            // nome
            // 
            nome.BackColor = Color.Gray;
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
            label1.BackColor = Color.Gray;
            label1.ForeColor = Color.GreenYellow;
            label1.Location = new Point(27, 128);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 9;
            label1.Text = "PRODUTOS DISPONIVEIS PARA VENDA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.ForeColor = Color.GreenYellow;
            label2.Location = new Point(560, 128);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 10;
            label2.Text = "COMANDA                                             ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.ForeColor = Color.GreenYellow;
            label3.Location = new Point(367, 189);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "Nome";
            // 
            // pagamento
            // 
            pagamento.BackColor = Color.Gray;
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
            label4.BackColor = Color.Gray;
            label4.ForeColor = Color.GreenYellow;
            label4.Location = new Point(335, 240);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 13;
            label4.Text = "Forma de Pagamento";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.Gray;
            txtQuantidade.ForeColor = Color.GreenYellow;
            txtQuantidade.Location = new Point(27, 397);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(210, 23);
            txtQuantidade.TabIndex = 14;
            txtQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantidade.ValueChanged += txtQuantidade_ValueChanged;
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
            numero.BackColor = Color.Gray;
            numero.ForeColor = Color.GreenYellow;
            numero.Location = new Point(413, 338);
            numero.Name = "numero";
            numero.Size = new Size(28, 15);
            numero.TabIndex = 16;
            numero.Text = "0,00";
            numero.Click += numero_Click;
            // 
            // txtdinheiro
            // 
            txtdinheiro.BackColor = Color.Gray;
            txtdinheiro.Location = new Point(303, 287);
            txtdinheiro.Name = "txtdinheiro";
            txtdinheiro.Size = new Size(178, 23);
            txtdinheiro.TabIndex = 17;
            txtdinheiro.TextChanged += txtdinheiro_TextChanged;
            // 
            // txttroco
            // 
            txttroco.AutoSize = true;
            txttroco.BackColor = Color.Gray;
            txttroco.ForeColor = Color.GreenYellow;
            txttroco.Location = new Point(370, 313);
            txttroco.Name = "txttroco";
            txttroco.Size = new Size(37, 15);
            txttroco.TabIndex = 18;
            txttroco.Text = "Troco";
            // 
            // btnviagem
            // 
            btnviagem.BackColor = Color.Gray;
            btnviagem.ForeColor = Color.GreenYellow;
            btnviagem.Location = new Point(303, 405);
            btnviagem.Name = "btnviagem";
            btnviagem.Size = new Size(178, 23);
            btnviagem.TabIndex = 19;
            btnviagem.Text = "Para viagem";
            btnviagem.UseVisualStyleBackColor = false;
            btnviagem.Click += btnviagem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(356, 84);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnviagem);
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
        private Button btnviagem;
        private Button button1;
    }
}
