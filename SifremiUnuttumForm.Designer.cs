namespace _6SigmaSoruProgrami
{
    partial class SifremiUnuttumForm
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
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_YeniSifre = new System.Windows.Forms.Button();
            this.label_yenisifre = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.button_SifreyiKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(157, 89);
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(164, 22);
            this.textBox_KullaniciAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı  : ";
            // 
            // button_YeniSifre
            // 
            this.button_YeniSifre.Location = new System.Drawing.Point(157, 133);
            this.button_YeniSifre.Name = "button_YeniSifre";
            this.button_YeniSifre.Size = new System.Drawing.Size(164, 34);
            this.button_YeniSifre.TabIndex = 2;
            this.button_YeniSifre.Text = "Yeni Şifrenizi Giriniz ";
            this.button_YeniSifre.UseVisualStyleBackColor = true;
            this.button_YeniSifre.Click += new System.EventHandler(this.button_YeniSifre_Click);
            // 
            // label_yenisifre
            // 
            this.label_yenisifre.AutoSize = true;
            this.label_yenisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_yenisifre.Location = new System.Drawing.Point(55, 243);
            this.label_yenisifre.Name = "label_yenisifre";
            this.label_yenisifre.Size = new System.Drawing.Size(86, 16);
            this.label_yenisifre.TabIndex = 4;
            this.label_yenisifre.Text = "Yeni Şifre : ";
            this.label_yenisifre.Visible = false;
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(157, 240);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(164, 22);
            this.textBox_Sifre.TabIndex = 3;
            this.textBox_Sifre.Visible = false;
            // 
            // button_SifreyiKaydet
            // 
            this.button_SifreyiKaydet.Location = new System.Drawing.Point(157, 284);
            this.button_SifreyiKaydet.Name = "button_SifreyiKaydet";
            this.button_SifreyiKaydet.Size = new System.Drawing.Size(164, 28);
            this.button_SifreyiKaydet.TabIndex = 5;
            this.button_SifreyiKaydet.Text = "Kaydet";
            this.button_SifreyiKaydet.UseVisualStyleBackColor = true;
            this.button_SifreyiKaydet.Visible = false;
            this.button_SifreyiKaydet.Click += new System.EventHandler(this.button_SifreyiKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre almak yapmak için kullanıcı adınızı giriniz...";
            // 
            // SifremiUnuttumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_SifreyiKaydet);
            this.Controls.Add(this.label_yenisifre);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.button_YeniSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_KullaniciAdi);
            this.Name = "SifremiUnuttumForm";
            this.Text = "SifremiUnuttumForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_YeniSifre;
        private System.Windows.Forms.Label label_yenisifre;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Button button_SifreyiKaydet;
        private System.Windows.Forms.Label label2;
    }
}