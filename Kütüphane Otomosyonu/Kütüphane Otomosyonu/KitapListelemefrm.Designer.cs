namespace Kütüphane_Otomosyonu
{
    partial class KitapListelemefrm
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
            this.turuComboBox = new System.Windows.Forms.ComboBox();
            this.iptalButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aciklamaTextBox = new System.Windows.Forms.TextBox();
            this.rafNoTExtBox = new System.Windows.Forms.TextBox();
            this.stokSayisiTextBox = new System.Windows.Forms.TextBox();
            this.sayfaSayisiTextBox = new System.Windows.Forms.TextBox();
            this.yayıneviTextBox = new System.Windows.Forms.TextBox();
            this.yazariTextBox = new System.Windows.Forms.TextBox();
            this.kitapadiTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.silButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aranacakBarkodNoTextBox = new System.Windows.Forms.TextBox();
            this.barkodNoTextBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // turuComboBox
            // 
            this.turuComboBox.FormattingEnabled = true;
            this.turuComboBox.Items.AddRange(new object[] {
            "Çocuk Kitapları",
            "Hikaye",
            "Roman"});
            this.turuComboBox.Location = new System.Drawing.Point(112, 190);
            this.turuComboBox.Name = "turuComboBox";
            this.turuComboBox.Size = new System.Drawing.Size(167, 24);
            this.turuComboBox.TabIndex = 40;
            // 
            // iptalButton
            // 
            this.iptalButton.Location = new System.Drawing.Point(180, 335);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(99, 42);
            this.iptalButton.TabIndex = 39;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(61, 335);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(99, 42);
            this.guncelleButton.TabIndex = 38;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Raf No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Stok Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kitap Adi";
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.Location = new System.Drawing.Point(112, 276);
            this.aciklamaTextBox.Multiline = true;
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(167, 53);
            this.aciklamaTextBox.TabIndex = 28;
            // 
            // rafNoTExtBox
            // 
            this.rafNoTExtBox.Location = new System.Drawing.Point(112, 248);
            this.rafNoTExtBox.Name = "rafNoTExtBox";
            this.rafNoTExtBox.Size = new System.Drawing.Size(167, 22);
            this.rafNoTExtBox.TabIndex = 27;
            // 
            // stokSayisiTextBox
            // 
            this.stokSayisiTextBox.Location = new System.Drawing.Point(112, 220);
            this.stokSayisiTextBox.Name = "stokSayisiTextBox";
            this.stokSayisiTextBox.Size = new System.Drawing.Size(167, 22);
            this.stokSayisiTextBox.TabIndex = 26;
            // 
            // sayfaSayisiTextBox
            // 
            this.sayfaSayisiTextBox.Location = new System.Drawing.Point(112, 164);
            this.sayfaSayisiTextBox.Name = "sayfaSayisiTextBox";
            this.sayfaSayisiTextBox.Size = new System.Drawing.Size(167, 22);
            this.sayfaSayisiTextBox.TabIndex = 25;
            // 
            // yayıneviTextBox
            // 
            this.yayıneviTextBox.Location = new System.Drawing.Point(112, 136);
            this.yayıneviTextBox.Name = "yayıneviTextBox";
            this.yayıneviTextBox.Size = new System.Drawing.Size(167, 22);
            this.yayıneviTextBox.TabIndex = 24;
            // 
            // yazariTextBox
            // 
            this.yazariTextBox.Location = new System.Drawing.Point(112, 108);
            this.yazariTextBox.Name = "yazariTextBox";
            this.yazariTextBox.Size = new System.Drawing.Size(167, 22);
            this.yazariTextBox.TabIndex = 23;
            // 
            // kitapadiTextBox
            // 
            this.kitapadiTextBox.Location = new System.Drawing.Point(112, 80);
            this.kitapadiTextBox.Name = "kitapadiTextBox";
            this.kitapadiTextBox.Size = new System.Drawing.Size(167, 22);
            this.kitapadiTextBox.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 322);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(673, 383);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(144, 42);
            this.silButton.TabIndex = 42;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Aranacak Kitap BarkodNo";
            // 
            // aranacakBarkodNoTextBox
            // 
            this.aranacakBarkodNoTextBox.Location = new System.Drawing.Point(596, 12);
            this.aranacakBarkodNoTextBox.Name = "aranacakBarkodNoTextBox";
            this.aranacakBarkodNoTextBox.Size = new System.Drawing.Size(167, 22);
            this.aranacakBarkodNoTextBox.TabIndex = 43;
            this.aranacakBarkodNoTextBox.TextChanged += new System.EventHandler(this.aranacakBarkodNoTextBox_TextChanged);
            // 
            // barkodNoTextBox
            // 
            this.barkodNoTextBox.AutoSize = true;
            this.barkodNoTextBox.Location = new System.Drawing.Point(29, 55);
            this.barkodNoTextBox.Name = "barkodNoTextBox";
            this.barkodNoTextBox.Size = new System.Drawing.Size(75, 17);
            this.barkodNoTextBox.TabIndex = 46;
            this.barkodNoTextBox.Text = "Barkod No";
            this.barkodNoTextBox.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KitapListelemefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.barkodNoTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aranacakBarkodNoTextBox);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.turuComboBox);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aciklamaTextBox);
            this.Controls.Add(this.rafNoTExtBox);
            this.Controls.Add(this.stokSayisiTextBox);
            this.Controls.Add(this.sayfaSayisiTextBox);
            this.Controls.Add(this.yayıneviTextBox);
            this.Controls.Add(this.yazariTextBox);
            this.Controls.Add(this.kitapadiTextBox);
            this.Name = "KitapListelemefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapListelemeSayfası";
            this.Load += new System.EventHandler(this.KitapListelemefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox turuComboBox;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aciklamaTextBox;
        private System.Windows.Forms.TextBox rafNoTExtBox;
        private System.Windows.Forms.TextBox stokSayisiTextBox;
        private System.Windows.Forms.TextBox sayfaSayisiTextBox;
        private System.Windows.Forms.TextBox yayıneviTextBox;
        private System.Windows.Forms.TextBox yazariTextBox;
        private System.Windows.Forms.TextBox kitapadiTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aranacakBarkodNoTextBox;
        private System.Windows.Forms.Label barkodNoTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}