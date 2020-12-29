namespace Kütüphane_Otomosyonu
{
    partial class UyeEkleForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.uyeİslemleriGroupBox = new System.Windows.Forms.GroupBox();
            this.uyeListelemeButton = new System.Windows.Forms.Button();
            this.UyeEklemeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitapListelemeButton = new System.Windows.Forms.Button();
            this.kitapEklemeButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.emanetKitapListelemeButton = new System.Windows.Forms.Button();
            this.EmanetKitapVermeButtton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grafikButton = new System.Windows.Forms.Button();
            this.siralamaButton = new System.Windows.Forms.Button();
            this.uyeİslemleriGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uyeİslemleriGroupBox
            // 
            this.uyeİslemleriGroupBox.Controls.Add(this.uyeListelemeButton);
            this.uyeİslemleriGroupBox.Controls.Add(this.UyeEklemeButton);
            this.uyeİslemleriGroupBox.Location = new System.Drawing.Point(65, 31);
            this.uyeİslemleriGroupBox.Name = "uyeİslemleriGroupBox";
            this.uyeİslemleriGroupBox.Size = new System.Drawing.Size(303, 149);
            this.uyeİslemleriGroupBox.TabIndex = 0;
            this.uyeİslemleriGroupBox.TabStop = false;
            this.uyeİslemleriGroupBox.Text = "Üye İşlemleri";
            // 
            // uyeListelemeButton
            // 
            this.uyeListelemeButton.Location = new System.Drawing.Point(36, 86);
            this.uyeListelemeButton.Name = "uyeListelemeButton";
            this.uyeListelemeButton.Size = new System.Drawing.Size(238, 41);
            this.uyeListelemeButton.TabIndex = 1;
            this.uyeListelemeButton.Text = "Üye Listeleme İşlemleri";
            this.uyeListelemeButton.UseVisualStyleBackColor = true;
            this.uyeListelemeButton.Click += new System.EventHandler(this.uyeListelemeButton_Click);
            // 
            // UyeEklemeButton
            // 
            this.UyeEklemeButton.Location = new System.Drawing.Point(36, 21);
            this.UyeEklemeButton.Name = "UyeEklemeButton";
            this.UyeEklemeButton.Size = new System.Drawing.Size(238, 41);
            this.UyeEklemeButton.TabIndex = 0;
            this.UyeEklemeButton.Text = "Üye Ekleme İşlemleri";
            this.UyeEklemeButton.UseVisualStyleBackColor = true;
            this.UyeEklemeButton.Click += new System.EventHandler(this.UyeEklemeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kitapListelemeButton);
            this.groupBox2.Controls.Add(this.kitapEklemeButton);
            this.groupBox2.Location = new System.Drawing.Point(430, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // kitapListelemeButton
            // 
            this.kitapListelemeButton.Location = new System.Drawing.Point(36, 86);
            this.kitapListelemeButton.Name = "kitapListelemeButton";
            this.kitapListelemeButton.Size = new System.Drawing.Size(238, 41);
            this.kitapListelemeButton.TabIndex = 1;
            this.kitapListelemeButton.Text = "Kitap Listeleme İşlemleri";
            this.kitapListelemeButton.UseVisualStyleBackColor = true;
            this.kitapListelemeButton.Click += new System.EventHandler(this.kitapListelemeButton_Click);
            // 
            // kitapEklemeButton
            // 
            this.kitapEklemeButton.Location = new System.Drawing.Point(36, 21);
            this.kitapEklemeButton.Name = "kitapEklemeButton";
            this.kitapEklemeButton.Size = new System.Drawing.Size(238, 41);
            this.kitapEklemeButton.TabIndex = 0;
            this.kitapEklemeButton.Text = "Kitap Ekleme İşlemleri";
            this.kitapEklemeButton.UseVisualStyleBackColor = true;
            this.kitapEklemeButton.Click += new System.EventHandler(this.kitapEklemeButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.emanetKitapListelemeButton);
            this.groupBox3.Controls.Add(this.EmanetKitapVermeButtton);
            this.groupBox3.Location = new System.Drawing.Point(65, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Emanet Kitap İade İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emanetKitapListelemeButton
            // 
            this.emanetKitapListelemeButton.Location = new System.Drawing.Point(15, 68);
            this.emanetKitapListelemeButton.Name = "emanetKitapListelemeButton";
            this.emanetKitapListelemeButton.Size = new System.Drawing.Size(260, 41);
            this.emanetKitapListelemeButton.TabIndex = 1;
            this.emanetKitapListelemeButton.Text = "Emanet Kitap Listeleme İşlemleri";
            this.emanetKitapListelemeButton.UseVisualStyleBackColor = true;
            this.emanetKitapListelemeButton.Click += new System.EventHandler(this.emanetKitapListelemeButton_Click);
            // 
            // EmanetKitapVermeButtton
            // 
            this.EmanetKitapVermeButtton.Location = new System.Drawing.Point(15, 21);
            this.EmanetKitapVermeButtton.Name = "EmanetKitapVermeButtton";
            this.EmanetKitapVermeButtton.Size = new System.Drawing.Size(260, 41);
            this.EmanetKitapVermeButtton.TabIndex = 0;
            this.EmanetKitapVermeButtton.Text = "Emanet Kitap Verme İşlemleri";
            this.EmanetKitapVermeButtton.UseVisualStyleBackColor = true;
            this.EmanetKitapVermeButtton.Click += new System.EventHandler(this.EmanetKitapVermeButtton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grafikButton);
            this.groupBox4.Controls.Add(this.siralamaButton);
            this.groupBox4.Location = new System.Drawing.Point(430, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 149);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafikler";
            // 
            // grafikButton
            // 
            this.grafikButton.Location = new System.Drawing.Point(36, 86);
            this.grafikButton.Name = "grafikButton";
            this.grafikButton.Size = new System.Drawing.Size(238, 41);
            this.grafikButton.TabIndex = 1;
            this.grafikButton.Text = "Grafikler";
            this.grafikButton.UseVisualStyleBackColor = true;
            this.grafikButton.Click += new System.EventHandler(this.grafikButton_Click);
            // 
            // siralamaButton
            // 
            this.siralamaButton.Location = new System.Drawing.Point(36, 21);
            this.siralamaButton.Name = "siralamaButton";
            this.siralamaButton.Size = new System.Drawing.Size(238, 41);
            this.siralamaButton.TabIndex = 0;
            this.siralamaButton.Text = "Sıralama";
            this.siralamaButton.UseVisualStyleBackColor = true;
            this.siralamaButton.Click += new System.EventHandler(this.siralamaButton_Click);
            // 
            // UyeEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.uyeİslemleriGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UyeEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KütüphaneOtomosyonu";
            this.Load += new System.EventHandler(this.UyeEkleForm_Load);
            this.uyeİslemleriGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox uyeİslemleriGroupBox;
        private System.Windows.Forms.Button uyeListelemeButton;
        private System.Windows.Forms.Button UyeEklemeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kitapListelemeButton;
        private System.Windows.Forms.Button kitapEklemeButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button emanetKitapListelemeButton;
        private System.Windows.Forms.Button EmanetKitapVermeButtton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button grafikButton;
        private System.Windows.Forms.Button siralamaButton;
        private System.Windows.Forms.Button button1;
    }
}

