﻿namespace Cantininha_do_estelionato
{
    partial class Balcão
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcão));
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnentregar = new Button();
            btncozinha = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Silver;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 2);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(403, 222);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Silver;
            listBox2.ForeColor = Color.Black;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(499, 303);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(403, 224);
            listBox2.TabIndex = 1;
            // 
            // btnentregar
            // 
            btnentregar.BackColor = Color.GreenYellow;
            btnentregar.ForeColor = Color.Black;
            btnentregar.Location = new Point(443, 28);
            btnentregar.Margin = new Padding(3, 4, 3, 4);
            btnentregar.Name = "btnentregar";
            btnentregar.Size = new Size(115, 64);
            btnentregar.TabIndex = 2;
            btnentregar.Text = "Entregar";
            btnentregar.UseVisualStyleBackColor = false;
            btnentregar.Click += btnentregar_Click;
            // 
            // btncozinha
            // 
            btncozinha.BackColor = Color.GreenYellow;
            btncozinha.ForeColor = Color.Black;
            btncozinha.Location = new Point(333, 453);
            btncozinha.Name = "btncozinha";
            btncozinha.Size = new Size(116, 64);
            btncozinha.TabIndex = 3;
            btncozinha.Text = "Cozinha";
            btncozinha.UseVisualStyleBackColor = false;
            btncozinha.Click += btncozinha_Click;
            // 
            // Balcão
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(btncozinha);
            Controls.Add(btnentregar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            ForeColor = Color.Coral;
            ImeMode = ImeMode.Hiragana;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Balcão";
            Text = "Balcão";
            Load += Balcão_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnentregar;
        private Button btncozinha;
    }
}