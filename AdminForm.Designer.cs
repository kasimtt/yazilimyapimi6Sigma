namespace _6SigmaSoruProgrami
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBox_KullaniciSifre = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBox_SifreGizle = new System.Windows.Forms.CheckBox();
            this.button_şifremiUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Şifre : ";
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(209, 125);
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(167, 22);
            this.textBox_KullaniciAdi.TabIndex = 2;
            // 
            // textBox_KullaniciSifre
            // 
            this.textBox_KullaniciSifre.Location = new System.Drawing.Point(209, 171);
            this.textBox_KullaniciSifre.Name = "textBox_KullaniciSifre";
            this.textBox_KullaniciSifre.Size = new System.Drawing.Size(167, 22);
            this.textBox_KullaniciSifre.TabIndex = 3;
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.Location = new System.Drawing.Point(280, 208);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(96, 35);
            this.button_giris.TabIndex = 5;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // checkBox_SifreGizle
            // 
            this.checkBox_SifreGizle.AutoSize = true;
            this.checkBox_SifreGizle.Location = new System.Drawing.Point(158, 208);
            this.checkBox_SifreGizle.Name = "checkBox_SifreGizle";
            this.checkBox_SifreGizle.Size = new System.Drawing.Size(99, 20);
            this.checkBox_SifreGizle.TabIndex = 6;
            this.checkBox_SifreGizle.Text = "Şifreyi Gizle";
            this.checkBox_SifreGizle.UseVisualStyleBackColor = true;
            this.checkBox_SifreGizle.CheckedChanged += new System.EventHandler(this.checkBox_SifreGizle_CheckedChanged);
            // 
            // button_şifremiUnuttum
            // 
            this.button_şifremiUnuttum.Location = new System.Drawing.Point(240, 270);
            this.button_şifremiUnuttum.Name = "button_şifremiUnuttum";
            this.button_şifremiUnuttum.Size = new System.Drawing.Size(136, 23);
            this.button_şifremiUnuttum.TabIndex = 7;
            this.button_şifremiUnuttum.Text = "Şifremi unuttum.";
            this.button_şifremiUnuttum.UseVisualStyleBackColor = true;
            this.button_şifremiUnuttum.Click += new System.EventHandler(this.button_şifremiUnuttum_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 454);
            this.Controls.Add(this.button_şifremiUnuttum);
            this.Controls.Add(this.checkBox_SifreGizle);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.textBox_KullaniciSifre);
            this.Controls.Add(this.textBox_KullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.TextBox textBox_KullaniciSifre;
        private System.Windows.Forms.Button button_giris;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBox_SifreGizle;
        private System.Windows.Forms.Button button_şifremiUnuttum;
    }
}