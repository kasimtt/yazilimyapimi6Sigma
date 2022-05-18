namespace _6SigmaSoruProgrami
{
    partial class SoruEklemeFormu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ASikki = new System.Windows.Forms.TextBox();
            this.textBox_BSikki = new System.Windows.Forms.TextBox();
            this.textBox_CSikki = new System.Windows.Forms.TextBox();
            this.textBox_DogruSik = new System.Windows.Forms.TextBox();
            this.textBox_Soru = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_ResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.konuAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimYolu1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSetBitti = new _6SigmaSoruProgrami.QuizDataSetBitti();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox_Konu = new System.Windows.Forms.ComboBox();
            this.comboBox_unite = new System.Windows.Forms.ComboBox();
            this.button_listele = new System.Windows.Forms.Button();
            this.quizViewTableAdapter = new _6SigmaSoruProgrami.QuizDataSetBittiTableAdapters.QuizViewTableAdapter();
            this.textBox_DSikki = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSetBitti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ünite : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "A Şıkkı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "B  Şıkkı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(78, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "C Şıkkı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(55, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dogru Sık : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(65, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Soru Seç : ";
            // 
            // textBox_ASikki
            // 
            this.textBox_ASikki.Location = new System.Drawing.Point(163, 88);
            this.textBox_ASikki.Name = "textBox_ASikki";
            this.textBox_ASikki.Size = new System.Drawing.Size(119, 22);
            this.textBox_ASikki.TabIndex = 9;
            // 
            // textBox_BSikki
            // 
            this.textBox_BSikki.Location = new System.Drawing.Point(163, 122);
            this.textBox_BSikki.Name = "textBox_BSikki";
            this.textBox_BSikki.Size = new System.Drawing.Size(119, 22);
            this.textBox_BSikki.TabIndex = 10;
            // 
            // textBox_CSikki
            // 
            this.textBox_CSikki.Location = new System.Drawing.Point(164, 157);
            this.textBox_CSikki.Name = "textBox_CSikki";
            this.textBox_CSikki.Size = new System.Drawing.Size(118, 22);
            this.textBox_CSikki.TabIndex = 11;
            // 
            // textBox_DogruSik
            // 
            this.textBox_DogruSik.Location = new System.Drawing.Point(164, 223);
            this.textBox_DogruSik.Name = "textBox_DogruSik";
            this.textBox_DogruSik.Size = new System.Drawing.Size(118, 22);
            this.textBox_DogruSik.TabIndex = 12;
            // 
            // textBox_Soru
            // 
            this.textBox_Soru.Location = new System.Drawing.Point(164, 255);
            this.textBox_Soru.Name = "textBox_Soru";
            this.textBox_Soru.Size = new System.Drawing.Size(118, 22);
            this.textBox_Soru.TabIndex = 13;
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kaydet.Location = new System.Drawing.Point(139, 284);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(64, 33);
            this.button_kaydet.TabIndex = 14;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_guncelle.Location = new System.Drawing.Point(225, 284);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(82, 33);
            this.button_guncelle.TabIndex = 15;
            this.button_guncelle.Text = "Guncelle";
            this.button_guncelle.UseVisualStyleBackColor = false;
            // 
            // button_ResimSec
            // 
            this.button_ResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ResimSec.Location = new System.Drawing.Point(290, 245);
            this.button_ResimSec.Name = "button_ResimSec";
            this.button_ResimSec.Size = new System.Drawing.Size(43, 32);
            this.button_ResimSec.TabIndex = 16;
            this.button_ResimSec.Text = "...";
            this.button_ResimSec.UseVisualStyleBackColor = true;
            this.button_ResimSec.Click += new System.EventHandler(this.button_ResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(406, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1166, 273);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.konuAdiDataGridViewTextBoxColumn,
            this.uniteAdiDataGridViewTextBoxColumn,
            this.resimYolu1DataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.dogruDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quizViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // konuAdiDataGridViewTextBoxColumn
            // 
            this.konuAdiDataGridViewTextBoxColumn.DataPropertyName = "KonuAdi";
            this.konuAdiDataGridViewTextBoxColumn.HeaderText = "KonuAdi";
            this.konuAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konuAdiDataGridViewTextBoxColumn.Name = "konuAdiDataGridViewTextBoxColumn";
            this.konuAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // uniteAdiDataGridViewTextBoxColumn
            // 
            this.uniteAdiDataGridViewTextBoxColumn.DataPropertyName = "UniteAdi";
            this.uniteAdiDataGridViewTextBoxColumn.HeaderText = "UniteAdi";
            this.uniteAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uniteAdiDataGridViewTextBoxColumn.Name = "uniteAdiDataGridViewTextBoxColumn";
            this.uniteAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // resimYolu1DataGridViewTextBoxColumn
            // 
            this.resimYolu1DataGridViewTextBoxColumn.DataPropertyName = "ResimYolu1";
            this.resimYolu1DataGridViewTextBoxColumn.HeaderText = "ResimYolu1";
            this.resimYolu1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resimYolu1DataGridViewTextBoxColumn.Name = "resimYolu1DataGridViewTextBoxColumn";
            this.resimYolu1DataGridViewTextBoxColumn.Width = 125;
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "A";
            this.aDataGridViewTextBoxColumn.HeaderText = "A";
            this.aDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            this.aDataGridViewTextBoxColumn.Width = 125;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.Width = 125;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.Width = 125;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "D";
            this.dDataGridViewTextBoxColumn.HeaderText = "D";
            this.dDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogruDataGridViewTextBoxColumn
            // 
            this.dogruDataGridViewTextBoxColumn.DataPropertyName = "Dogru";
            this.dogruDataGridViewTextBoxColumn.HeaderText = "Dogru";
            this.dogruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogruDataGridViewTextBoxColumn.Name = "dogruDataGridViewTextBoxColumn";
            this.dogruDataGridViewTextBoxColumn.Width = 125;
            // 
            // quizViewBindingSource
            // 
            this.quizViewBindingSource.DataMember = "QuizView";
            this.quizViewBindingSource.DataSource = this.quizDataSetBitti;
            // 
            // quizDataSetBitti
            // 
            this.quizDataSetBitti.DataSetName = "QuizDataSetBitti";
            this.quizDataSetBitti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox_Konu
            // 
            this.comboBox_Konu.FormattingEnabled = true;
            this.comboBox_Konu.Items.AddRange(new object[] {
            "Mevsimlerin Oluşumu",
            "İklim ve Hava Hareketleri",
            "DNA ve Genetik Kod",
            "Kalıtım",
            "Mutasyon ve Modifikasyon",
            "Adaptasyon",
            "Biyoteknoloji",
            "Basınç",
            "Periyotik Sistem",
            "Fiziksel ve Kimyasal Değişimler",
            "Soygazların Özellikleri",
            "Asitler ve Bazlar",
            "Maddenin Isı ve Etkilişimi",
            "Türkiye\'de Kimya Endistrisi",
            "Basit Makineler",
            "Enerji Dönüşümleri",
            "Madde Döngüleri ve Çevre Sorunları",
            "Sürdürülebilir Kalkınma",
            "Elektrik Yükleri ve Elektriklenme",
            "Elektrik Yüklü Cisimler",
            "Elektrik Enerjisinin Dönüşümü"});
            this.comboBox_Konu.Location = new System.Drawing.Point(161, 54);
            this.comboBox_Konu.Name = "comboBox_Konu";
            this.comboBox_Konu.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Konu.TabIndex = 20;
            // 
            // comboBox_unite
            // 
            this.comboBox_unite.FormattingEnabled = true;
            this.comboBox_unite.Items.AddRange(new object[] {
            "Mevsimler ve İklim",
            "DNA ve Genetik Kod",
            "Basınç",
            "Madde ve Endüstri",
            "Basit Makineler",
            "Enerji Dönüşümleri ve Çevre Bilimi",
            "Elektrik Yükleri ve Elektrik Enerjisi"});
            this.comboBox_unite.Location = new System.Drawing.Point(161, 20);
            this.comboBox_unite.Name = "comboBox_unite";
            this.comboBox_unite.Size = new System.Drawing.Size(121, 24);
            this.comboBox_unite.TabIndex = 21;
            // 
            // button_listele
            // 
            this.button_listele.BackColor = System.Drawing.Color.OrangeRed;
            this.button_listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_listele.Location = new System.Drawing.Point(1106, 312);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(69, 37);
            this.button_listele.TabIndex = 22;
            this.button_listele.Text = "listele";
            this.button_listele.UseVisualStyleBackColor = false;
            this.button_listele.Click += new System.EventHandler(this.button_listele_Click_1);
            // 
            // quizViewTableAdapter
            // 
            this.quizViewTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_DSikki
            // 
            this.textBox_DSikki.Location = new System.Drawing.Point(164, 192);
            this.textBox_DSikki.Name = "textBox_DSikki";
            this.textBox_DSikki.Size = new System.Drawing.Size(118, 22);
            this.textBox_DSikki.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(77, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "D Şıkkı : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(1203, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 54);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SoruEklemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1347, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_DSikki);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_listele);
            this.Controls.Add(this.comboBox_unite);
            this.Controls.Add(this.comboBox_Konu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_ResimSec);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_Soru);
            this.Controls.Add(this.textBox_DogruSik);
            this.Controls.Add(this.textBox_CSikki);
            this.Controls.Add(this.textBox_BSikki);
            this.Controls.Add(this.textBox_ASikki);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SoruEklemeFormu";
            this.Text = "Soru Ekleme Modulu";
            this.Load += new System.EventHandler(this.SoruEklemeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSetBitti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ASikki;
        private System.Windows.Forms.TextBox textBox_BSikki;
        private System.Windows.Forms.TextBox textBox_CSikki;
        private System.Windows.Forms.TextBox textBox_DogruSik;
        private System.Windows.Forms.TextBox textBox_Soru;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_ResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox_Konu;
        private System.Windows.Forms.ComboBox comboBox_unite;
        private System.Windows.Forms.Button button_listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuizDataSetBitti quizDataSetBitti;
        private System.Windows.Forms.BindingSource quizViewBindingSource;
        private QuizDataSetBittiTableAdapters.QuizViewTableAdapter quizViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimYolu1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogruDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_DSikki;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}