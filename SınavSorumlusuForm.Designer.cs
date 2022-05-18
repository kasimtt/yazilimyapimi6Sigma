namespace _6SigmaSoruProgrami
{
    partial class SınavSorumlusuForm
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
            this.checkBox_SifreGizle = new System.Windows.Forms.CheckBox();
            this.button_SifremiUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_giris
            // 
            this.button_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.Location = new System.Drawing.Point(257, 212);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(96, 35);
            this.button_giris.TabIndex = 11;
            this.button_giris.Text = "Giriş";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // textBox_şifre
            // 
            this.textBox_şifre.Location = new System.Drawing.Point(186, 175);
            this.textBox_şifre.Name = "textBox_şifre";
            this.textBox_şifre.Size = new System.Drawing.Size(167, 22);
            this.textBox_şifre.TabIndex = 9;
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(186, 129);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(167, 22);
            this.textBox_kullaniciAdi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // checkBox_SifreGizle
            // 
            this.checkBox_SifreGizle.AutoSize = true;
            this.checkBox_SifreGizle.Location = new System.Drawing.Point(122, 222);
            this.checkBox_SifreGizle.Name = "checkBox_SifreGizle";
            this.checkBox_SifreGizle.Size = new System.Drawing.Size(99, 20);
            this.checkBox_SifreGizle.TabIndex = 12;
            this.checkBox_SifreGizle.Text = "Şifreyi Gizle";
            this.checkBox_SifreGizle.UseVisualStyleBackColor = true;
            this.checkBox_SifreGizle.CheckedChanged += new System.EventHandler(this.checkBox_SifreGizle_CheckedChanged);
            // 
            // button_SifremiUnuttum
            // 
            this.button_SifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SifremiUnuttum.Location = new System.Drawing.Point(205, 263);
            this.button_SifremiUnuttum.Name = "button_SifremiUnuttum";
            this.button_SifremiUnuttum.Size = new System.Drawing.Size(148, 26);
            this.button_SifremiUnuttum.TabIndex = 13;
            this.button_SifremiUnuttum.Text = "Şifremi Unuttum";
            this.button_SifremiUnuttum.UseVisualStyleBackColor = true;
            this.button_SifremiUnuttum.Click += new System.EventHandler(this.button_SifremiUnuttum_Click);
            // 
            // SınavSorumlusuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 481);
            this.Controls.Add(this.button_SifremiUnuttum);
            this.Controls.Add(this.checkBox_SifreGizle);
            this.Controls.Add(this.button_giris);
            this.Controls.Add(this.textBox_şifre);
            this.Controls.Add(this.textBox_kullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SınavSorumlusuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Sorumlusu Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.TextBox textBox_şifre;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_SifreGizle;
        private System.Windows.Forms.Button button_SifremiUnuttum;
    }
}