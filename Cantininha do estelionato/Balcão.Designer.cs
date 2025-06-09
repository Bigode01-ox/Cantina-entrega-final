namespace Cantininha_do_estelionato
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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Gray;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.ForeColor = Color.GreenYellow;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, -1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(343, 167);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Gray;
            listBox2.ForeColor = Color.GreenYellow;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(459, -3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(343, 169);
            listBox2.TabIndex = 1;
            // 
            // btnentregar
            // 
            btnentregar.BackColor = Color.Gray;
            btnentregar.ForeColor = Color.GreenYellow;
            btnentregar.Location = new Point(122, 172);
            btnentregar.Name = "btnentregar";
            btnentregar.Size = new Size(101, 27);
            btnentregar.TabIndex = 2;
            btnentregar.Text = "Entregar";
            btnentregar.UseVisualStyleBackColor = false;
            btnentregar.Click += btnentregar_Click;
            // 
            // Balcão
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnentregar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            ForeColor = Color.Coral;
            ImeMode = ImeMode.Hiragana;
            Name = "Balcão";
            Text = "Balcão";
            Load += Balcão_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnentregar;
    }
}