namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            txtUrunAdi = new TextBox();
            label2 = new Label();
            txtUrunAdedi = new TextBox();
            txtBirimFiyati = new TextBox();
            label3 = new Label();
            lstListe = new ListBox();
            button3 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 200);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(153, 200);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "LİSTELE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "ÜRÜN ADI";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(30, 37);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(232, 23);
            txtUrunAdi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 72);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "ÜRÜN ADEDİ";
            // 
            // txtUrunAdedi
            // 
            txtUrunAdedi.Location = new Point(29, 90);
            txtUrunAdedi.Name = "txtUrunAdedi";
            txtUrunAdedi.Size = new Size(232, 23);
            txtUrunAdedi.TabIndex = 5;
            // 
            // txtBirimFiyati
            // 
            txtBirimFiyati.Location = new Point(30, 144);
            txtBirimFiyati.Name = "txtBirimFiyati";
            txtBirimFiyati.Size = new Size(232, 23);
            txtBirimFiyati.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 116);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 7;
            label3.Text = "BİRİM FİYATI(double)";
            label3.Click += label3_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(29, 280);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(165, 124);
            lstListe.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(392, 182);
            button3.Name = "button3";
            button3.Size = new Size(336, 23);
            button3.TabIndex = 9;
            button3.Text = "Diziye Aktar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(393, 381);
            button4.Name = "button4";
            button4.Size = new Size(335, 23);
            button4.TabIndex = 10;
            button4.Text = "Dizinin Elaman Sayısını Göster";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(393, 37);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(335, 130);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(393, 226);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(335, 124);
            textBox5.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(lstListe);
            Controls.Add(label3);
            Controls.Add(txtBirimFiyati);
            Controls.Add(txtUrunAdedi);
            Controls.Add(label2);
            Controls.Add(txtUrunAdi);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox txtUrunAdi;
        private Label label2;
        private TextBox txtUrunAdedi;
        private TextBox txtBirimFiyati;
        private Label label3;
        private ListBox lstListe;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
