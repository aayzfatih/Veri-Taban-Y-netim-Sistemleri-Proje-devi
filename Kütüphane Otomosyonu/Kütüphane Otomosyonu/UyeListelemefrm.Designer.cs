namespace Kütüphane_Otomosyonu
{
    partial class UyeListelemefrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cinsiyetComboBox = new System.Windows.Forms.ComboBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.yasTextBox = new System.Windows.Forms.TextBox();
            this.adSoyadTextBox = new System.Windows.Forms.TextBox();
            this.okuduguKitapTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cinsiyetlabel = new System.Windows.Forms.Label();
            this.yaslabel = new System.Windows.Forms.Label();
            this.adSoyadlabel = new System.Windows.Forms.Label();
            this.tclabel = new System.Windows.Forms.Label();
            this.iptalButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.arananTcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.silButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(663, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cinsiyetComboBox
            // 
            this.cinsiyetComboBox.FormattingEnabled = true;
            this.cinsiyetComboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.cinsiyetComboBox.Location = new System.Drawing.Point(170, 207);
            this.cinsiyetComboBox.Name = "cinsiyetComboBox";
            this.cinsiyetComboBox.Size = new System.Drawing.Size(121, 24);
            this.cinsiyetComboBox.TabIndex = 33;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(170, 243);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(121, 22);
            this.telefonTextBox.TabIndex = 32;
            // 
            // yasTextBox
            // 
            this.yasTextBox.Location = new System.Drawing.Point(170, 176);
            this.yasTextBox.Name = "yasTextBox";
            this.yasTextBox.Size = new System.Drawing.Size(121, 22);
            this.yasTextBox.TabIndex = 31;
            // 
            // adSoyadTextBox
            // 
            this.adSoyadTextBox.Location = new System.Drawing.Point(170, 148);
            this.adSoyadTextBox.Name = "adSoyadTextBox";
            this.adSoyadTextBox.Size = new System.Drawing.Size(121, 22);
            this.adSoyadTextBox.TabIndex = 30;
            // 
            // okuduguKitapTextBox
            // 
            this.okuduguKitapTextBox.Location = new System.Drawing.Point(170, 335);
            this.okuduguKitapTextBox.Name = "okuduguKitapTextBox";
            this.okuduguKitapTextBox.Size = new System.Drawing.Size(121, 22);
            this.okuduguKitapTextBox.TabIndex = 29;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(170, 302);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(121, 22);
            this.mailTextBox.TabIndex = 28;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(170, 274);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(121, 22);
            this.adresTextBox.TabIndex = 27;
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(170, 119);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(121, 22);
            this.tcTextBox.TabIndex = 26;
            this.tcTextBox.TextChanged += new System.EventHandler(this.tcTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Okuduğu Kitap Sayisi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "E-mail";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Adres";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telefon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cinsiyetlabel
            // 
            this.cinsiyetlabel.AutoSize = true;
            this.cinsiyetlabel.Location = new System.Drawing.Point(95, 210);
            this.cinsiyetlabel.Name = "cinsiyetlabel";
            this.cinsiyetlabel.Size = new System.Drawing.Size(57, 17);
            this.cinsiyetlabel.TabIndex = 21;
            this.cinsiyetlabel.Text = "Cinsiyet";
            this.cinsiyetlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yaslabel
            // 
            this.yaslabel.AutoSize = true;
            this.yaslabel.Location = new System.Drawing.Point(120, 181);
            this.yaslabel.Name = "yaslabel";
            this.yaslabel.Size = new System.Drawing.Size(32, 17);
            this.yaslabel.TabIndex = 20;
            this.yaslabel.Text = "Yaş";
            this.yaslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adSoyadlabel
            // 
            this.adSoyadlabel.AutoSize = true;
            this.adSoyadlabel.Location = new System.Drawing.Point(83, 151);
            this.adSoyadlabel.Name = "adSoyadlabel";
            this.adSoyadlabel.Size = new System.Drawing.Size(69, 17);
            this.adSoyadlabel.TabIndex = 19;
            this.adSoyadlabel.Text = "Ad Soyad";
            this.adSoyadlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tclabel
            // 
            this.tclabel.AutoSize = true;
            this.tclabel.Location = new System.Drawing.Point(126, 124);
            this.tclabel.Name = "tclabel";
            this.tclabel.Size = new System.Drawing.Size(26, 17);
            this.tclabel.TabIndex = 18;
            this.tclabel.Text = "TC";
            this.tclabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iptalButton
            // 
            this.iptalButton.Location = new System.Drawing.Point(208, 384);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(93, 33);
            this.iptalButton.TabIndex = 35;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(86, 384);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(104, 33);
            this.guncelleButton.TabIndex = 34;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // arananTcTextBox
            // 
            this.arananTcTextBox.Location = new System.Drawing.Point(554, 46);
            this.arananTcTextBox.Name = "arananTcTextBox";
            this.arananTcTextBox.Size = new System.Drawing.Size(133, 22);
            this.arananTcTextBox.TabIndex = 36;
            this.arananTcTextBox.TextChanged += new System.EventHandler(this.arananTcTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Aranan TC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(739, 41);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(104, 33);
            this.silButton.TabIndex = 38;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // UyeListelemefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 490);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arananTcTextBox);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.cinsiyetComboBox);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.yasTextBox);
            this.Controls.Add(this.adSoyadTextBox);
            this.Controls.Add(this.okuduguKitapTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cinsiyetlabel);
            this.Controls.Add(this.yaslabel);
            this.Controls.Add(this.adSoyadlabel);
            this.Controls.Add(this.tclabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeListelemefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeListelemefrm";
            this.Load += new System.EventHandler(this.UyeListelemefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cinsiyetComboBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox yasTextBox;
        private System.Windows.Forms.TextBox adSoyadTextBox;
        private System.Windows.Forms.TextBox okuduguKitapTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cinsiyetlabel;
        private System.Windows.Forms.Label yaslabel;
        private System.Windows.Forms.Label adSoyadlabel;
        private System.Windows.Forms.Label tclabel;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.TextBox arananTcTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button silButton;
    }
}