namespace Cantininha_do_estelionato
{
    partial class Cozinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cozinha));
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnpreparar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Silver;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(334, 144);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Silver;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(465, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(334, 144);
            listBox2.TabIndex = 1;
            // 
            // btnpreparar
            // 
            btnpreparar.BackColor = Color.Silver;
            btnpreparar.Location = new Point(353, 164);
            btnpreparar.Name = "btnpreparar";
            btnpreparar.Size = new Size(94, 39);
            btnpreparar.TabIndex = 2;
            btnpreparar.Text = "Preparar";
            btnpreparar.UseVisualStyleBackColor = false;
            btnpreparar.Click += btnpreparar_Click;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnpreparar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Cozinha";
            Text = "Cozinha";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnpreparar;
    }
}