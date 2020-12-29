namespace Kütüphane_Otomosyonu
{
    partial class EmanetKitapİadefrm
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
            this.teslimAlButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.barkodNoTextBox = new System.Windows.Forms.TextBox();
            this.kimlikNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // teslimAlButton
            // 
            this.teslimAlButton.Location = new System.Drawing.Point(563, 391);
            this.teslimAlButton.Name = "teslimAlButton";
            this.teslimAlButton.Size = new System.Drawing.Size(106, 37);
            this.teslimAlButton.TabIndex = 1;
            this.teslimAlButton.Text = "Teslim Al";
            this.teslimAlButton.UseVisualStyleBackColor = true;
            this.teslimAlButton.Click += new System.EventHandler(this.teslimAlButton_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.Location = new System.Drawing.Point(675, 391);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(106, 37);
            this.iptalButton.TabIndex = 2;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // barkodNoTextBox
            // 
            this.barkodNoTextBox.Location = new System.Drawing.Point(660, 26);
            this.barkodNoTextBox.Name = "barkodNoTextBox";
            this.barkodNoTextBox.Size = new System.Drawing.Size(128, 22);
            this.barkodNoTextBox.TabIndex = 3;
            this.barkodNoTextBox.TextChanged += new System.EventHandler(this.barkodNoTextBox_TextChanged);
            // 
            // kimlikNoTextBox
            // 
            this.kimlikNoTextBox.Location = new System.Drawing.Point(388, 28);
            this.kimlikNoTextBox.Name = "kimlikNoTextBox";
            this.kimlikNoTextBox.Size = new System.Drawing.Size(128, 22);
            this.kimlikNoTextBox.TabIndex = 4;
            this.kimlikNoTextBox.TextChanged += new System.EventHandler(this.kimlikNoTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kimlik numarasına gore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "barkodnosuna gore";
            // 
            // EmanetKitapİadefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kimlikNoTextBox);
            this.Controls.Add(this.barkodNoTextBox);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.teslimAlButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetKitapİadefrm";
            this.Text = "Emanet Kitap İade Sayfasi";
            this.Load += new System.EventHandler(this.EmanetKitapİadefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button teslimAlButton;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.TextBox barkodNoTextBox;
        private System.Windows.Forms.TextBox kimlikNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}