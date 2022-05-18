namespace _6SigmaSoruProgrami
{
    partial class OgrenciEkranSecmeForm
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
            this.button_SinavYap = new System.Windows.Forms.Button();
            this.button_EksersizYap = new System.Windows.Forms.Button();
            this.button_anaMenu = new System.Windows.Forms.Button();
            this.label_KullaniciAdi = new System.Windows.Forms.Label();
            this.button_Rapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SinavYap
            // 
            this.button_SinavYap.BackColor = System.Drawing.Color.IndianRed;
            this.button_SinavYap.Location = new System.Drawing.Point(72, 165);
            this.button_SinavYap.Name = "button_SinavYap";
            this.button_SinavYap.Size = new System.Drawing.Size(147, 62);
            this.button_SinavYap.TabIndex = 0;
            this.button_SinavYap.Text = "Sınav Yap";
            this.button_SinavYap.UseVisualStyleBackColor = false;
            this.button_SinavYap.Click += new System.EventHandler(this.button_SinavYap_Click);
            // 
            // button_EksersizYap
            // 
            this.button_EksersizYap.BackColor = System.Drawing.Color.Firebrick;
            this.button_EksersizYap.Location = new System.Drawing.Point(462, 165);
            this.button_EksersizYap.Name = "button_EksersizYap";
            this.button_EksersizYap.Size = new System.Drawing.Size(152, 67);
            this.button_EksersizYap.TabIndex = 1;
            this.button_EksersizYap.Text = "Egzersiz Yap";
            this.button_EksersizYap.UseVisualStyleBackColor = false;
            this.button_EksersizYap.Click += new System.EventHandler(this.button_EksersizYap_Click);
            // 
            // button_anaMenu
            // 
            this.button_anaMenu.BackColor = System.Drawing.Color.IndianRed;
            this.button_anaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_anaMenu.Location = new System.Drawing.Point(262, 267);
            this.button_anaMenu.Name = "button_anaMenu";
            this.button_anaMenu.Size = new System.Drawing.Size(152, 72);
            this.button_anaMenu.TabIndex = 2;
            this.button_anaMenu.Text = "Ana Menü";
            this.button_anaMenu.UseVisualStyleBackColor = false;
            this.button_anaMenu.Click += new System.EventHandler(this.button_anaMenu_Click);
            // 
            // label_KullaniciAdi
            // 
            this.label_KullaniciAdi.AutoSize = true;
            this.label_KullaniciAdi.Location = new System.Drawing.Point(734, 414);
            this.label_KullaniciAdi.Name = "label_KullaniciAdi";
            this.label_KullaniciAdi.Size = new System.Drawing.Size(44, 16);
            this.label_KullaniciAdi.TabIndex = 3;
            this.label_KullaniciAdi.Text = "label1";
            this.label_KullaniciAdi.Visible = false;
            // 
            // button_Rapor
            // 
            this.button_Rapor.BackColor = System.Drawing.Color.IndianRed;
            this.button_Rapor.Location = new System.Drawing.Point(262, 165);
            this.button_Rapor.Name = "button_Rapor";
            this.button_Rapor.Size = new System.Drawing.Size(152, 67);
            this.button_Rapor.TabIndex = 4;
            this.button_Rapor.Text = "Rapor";
            this.button_Rapor.UseVisualStyleBackColor = false;
            this.button_Rapor.Click += new System.EventHandler(this.button_Rapor_Click);
            // 
            // OgrenciEkranSecmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.button_Rapor);
            this.Controls.Add(this.label_KullaniciAdi);
            this.Controls.Add(this.button_anaMenu);
            this.Controls.Add(this.button_EksersizYap);
            this.Controls.Add(this.button_SinavYap);
            this.Name = "OgrenciEkranSecmeForm";
            this.Text = "OgrenciEkranSecmeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_KullaniciAdi;
        public System.Windows.Forms.Button button_SinavYap;
        public System.Windows.Forms.Button button_EksersizYap;
        public System.Windows.Forms.Button button_anaMenu;
        public System.Windows.Forms.Button button_Rapor;
    }
}