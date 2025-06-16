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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(334, 124);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(454, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(334, 124);
            listBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(353, 164);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Cozinha";
            Text = "Cozinha";
            Load += Cozinha_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
    }
}