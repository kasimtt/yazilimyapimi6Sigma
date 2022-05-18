namespace _6SigmaSoruProgrami
{
    partial class Form1
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
            this.button_Admin = new System.Windows.Forms.Button();
            this.button_SinavSorumlusu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_YeniKayit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Admin
            // 
            this.button_Admin.Location = new System.Drawing.Point(118, 254);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(115, 62);
            this.button_Admin.TabIndex = 0;
            this.button_Admin.Text = "Admin";
            this.button_Admin.UseVisualStyleBackColor = true;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // button_SinavSorumlusu
            // 
            this.button_SinavSorumlusu.Location = new System.Drawing.Point(301, 254);
            this.button_SinavSorumlusu.Name = "button_SinavSorumlusu";
            this.button_SinavSorumlusu.Size = new System.Drawing.Size(123, 62);
            this.button_SinavSorumlusu.TabIndex = 1;
            this.button_SinavSorumlusu.Text = "Sınav Sorumlusu";
            this.button_SinavSorumlusu.UseVisualStyleBackColor = true;
            this.button_SinavSorumlusu.Click += new System.EventHandler(this.button_SinavSorumlusu_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ögrenci";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 133);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "6 Sigma Öğreten Quiz Sistemimize Hoşgeldiniz. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seçiminizi Yapınız.";
            // 
            // button_YeniKayit
            // 
            this.button_YeniKayit.Location = new System.Drawing.Point(301, 367);
            this.button_YeniKayit.Name = "button_YeniKayit";
            this.button_YeniKayit.Size = new System.Drawing.Size(123, 62);
            this.button_YeniKayit.TabIndex = 4;
            this.button_YeniKayit.Text = "Yeni Kayit";
            this.button_YeniKayit.UseVisualStyleBackColor = true;
            this.button_YeniKayit.Click += new System.EventHandler(this.button_YeniKayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 507);
            this.Controls.Add(this.button_YeniKayit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_SinavSorumlusu);
            this.Controls.Add(this.button_Admin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Admin;
        private System.Windows.Forms.Button button_SinavSorumlusu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_YeniKayit;
    }
}

