namespace _6SigmaSoruProgrami
{
    partial class RaporFormucs
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
            this.button_Listele = new System.Windows.Forms.Button();
            this.button_anaMenu = new System.Windows.Forms.Button();
            this.label_kullaniciAdiRapor = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_Listele
            // 
            this.button_Listele.BackColor = System.Drawing.Color.LightCoral;
            this.button_Listele.Location = new System.Drawing.Point(684, 445);
            this.button_Listele.Name = "button_Listele";
            this.button_Listele.Size = new System.Drawing.Size(91, 43);
            this.button_Listele.TabIndex = 2;
            this.button_Listele.Text = "Listele";
            this.button_Listele.UseVisualStyleBackColor = false;
            this.button_Listele.Click += new System.EventHandler(this.button_Listele_Click);
            // 
            // button_anaMenu
            // 
            this.button_anaMenu.BackColor = System.Drawing.Color.Red;
            this.button_anaMenu.Location = new System.Drawing.Point(804, 12);
            this.button_anaMenu.Name = "button_anaMenu";
            this.button_anaMenu.Size = new System.Drawing.Size(91, 63);
            this.button_anaMenu.TabIndex = 3;
            this.button_anaMenu.Text = "Ana Menu";
            this.button_anaMenu.UseVisualStyleBackColor = false;
            this.button_anaMenu.Click += new System.EventHandler(this.button_anaMenu_Click);
            // 
            // label_kullaniciAdiRapor
            // 
            this.label_kullaniciAdiRapor.AutoSize = true;
            this.label_kullaniciAdiRapor.Location = new System.Drawing.Point(821, 106);
            this.label_kullaniciAdiRapor.Name = "label_kullaniciAdiRapor";
            this.label_kullaniciAdiRapor.Size = new System.Drawing.Size(151, 16);
            this.label_kullaniciAdiRapor.TabIndex = 4;
            this.label_kullaniciAdiRapor.Text = "label_KullaniciAdiRapor";
            this.label_kullaniciAdiRapor.Visible = false;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.Color.LightCoral;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(773, 409);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı Adı";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dogru Sayısı";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yanlış Sayısı";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sınav Tarihi";
            this.columnHeader4.Width = 180;
            // 
            // RaporFormucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1015, 603);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_kullaniciAdiRapor);
            this.Controls.Add(this.button_anaMenu);
            this.Controls.Add(this.button_Listele);
            this.Name = "RaporFormucs";
            this.Text = "RaporFormucs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Listele;
        private System.Windows.Forms.Button button_anaMenu;
        public System.Windows.Forms.Label label_kullaniciAdiRapor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}