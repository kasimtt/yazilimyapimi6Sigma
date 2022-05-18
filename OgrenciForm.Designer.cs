namespace _6SigmaSoruProgrami
{
    partial class OgrenciForm
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
            this.button_giris = new System.Windows.Forms.Button();
            this.textBox_şifre = new System.Windows.Forms.TextBox();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_sifreGizle = new System.Windows.Forms.CheckBox();
            this.button_şifremiUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.Location = new System.Drawing.Point(284, 205);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(96, 35);
            this.button_giris.TabIndex = 17;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // textBox_şifre
            // 
            this.textBox_şifre.Location = new System.Drawing.Point(213, 168);
            this.textBox_şifre.Name = "textBox_şifre";
            this.textBox_şifre.Size = new System.Drawing.Size(167, 22);
            this.textBox_şifre.TabIndex = 15;
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(213, 122);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(167, 22);
            this.textBox_kullaniciAdi.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kullanıcı Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // checkBox_sifreGizle
            // 
            this.checkBox_sifreGizle.AutoSize = true;
            this.checkBox_sifreGizle.Location = new System.Drawing.Point(155, 215);
            this.checkBox_sifreGizle.Name = "checkBox_sifreGizle";
            this.checkBox_sifreGizle.Size = new System.Drawing.Size(99, 20);
            this.checkBox_sifreGizle.TabIndex = 18;
            this.checkBox_sifreGizle.Text = "Şifreyi Gizle";
            this.checkBox_sifreGizle.UseVisualStyleBackColor = true;
            this.checkBox_sifreGizle.CheckedChanged += new System.EventHandler(this.checkBox_sifreGizle_CheckedChanged);
            // 
            // button_şifremiUnuttum
            // 
            this.button_şifremiUnuttum.Location = new System.Drawing.Point(217, 246);
            this.button_şifremiUnuttum.Name = "button_şifremiUnuttum";
            this.button_şifremiUnuttum.Size = new System.Drawing.Size(163, 23);
            this.button_şifremiUnuttum.TabIndex = 19;
            this.button_şifremiUnuttum.Text = "Şifremi Unuttum";
            this.button_şifremiUnuttum.UseVisualStyleBackColor = true;
            this.button_şifremiUnuttum.Click += new System.EventHandler(this.button_şifremiUnuttum_Click);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.button_şifremiUnuttum);
            this.Controls.Add(this.checkBox_sifreGizle);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.textBox_şifre);
            this.Controls.Add(this.textBox_kullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button_giris;
        public System.Windows.Forms.TextBox textBox_şifre;
        public System.Windows.Forms.TextBox textBox_kullaniciAdi;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkBox_sifreGizle;
        private System.Windows.Forms.Button button_şifremiUnuttum;
    }
}