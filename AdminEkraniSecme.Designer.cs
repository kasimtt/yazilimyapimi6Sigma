namespace _6SigmaSoruProgrami
{
    partial class AdminEkraniSecme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.quizDataSet1 = new _6SigmaSoruProgrami.QuizDataSet1();
            this.tblKullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KullaniciTableAdapter = new _6SigmaSoruProgrami.QuizDataSet1TableAdapters.Tbl_KullaniciTableAdapter();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTipiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizDataSet2 = new _6SigmaSoruProgrami.QuizDataSet2();
            this.tblSorularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SorularTableAdapter = new _6SigmaSoruProgrami.QuizDataSet2TableAdapters.tbl_SorularTableAdapter();
            this.soruIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimYolu1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_kullaniciListelebutton_kullaniciListele = new System.Windows.Forms.Button();
            this.button_SorulariGüncelle = new System.Windows.Forms.Button();
            this.label_KullaniciID = new System.Windows.Forms.Label();
            this.label_soruID = new System.Windows.Forms.Label();
            this.button_KullaniciSil = new System.Windows.Forms.Button();
            this.button_soruSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSorularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(62, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlı Kullanıcılar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(815, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Sorular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kullaniciTipiIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKullaniciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soruIDDataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.dogruDataGridViewTextBoxColumn,
            this.uniteIDDataGridViewTextBoxColumn,
            this.konuIDDataGridViewTextBoxColumn,
            this.resimYolu1DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblSorularBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(667, 248);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(733, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quizDataSet1
            // 
            this.quizDataSet1.DataSetName = "QuizDataSet1";
            this.quizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKullaniciBindingSource
            // 
            this.tblKullaniciBindingSource.DataMember = "Tbl_Kullanici";
            this.tblKullaniciBindingSource.DataSource = this.quizDataSet1;
            // 
            // tbl_KullaniciTableAdapter
            // 
            this.tbl_KullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            this.kullaniciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciTipiIDDataGridViewTextBoxColumn
            // 
            this.kullaniciTipiIDDataGridViewTextBoxColumn.DataPropertyName = "KullaniciTipiID";
            this.kullaniciTipiIDDataGridViewTextBoxColumn.HeaderText = "KullaniciTipiID";
            this.kullaniciTipiIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciTipiIDDataGridViewTextBoxColumn.Name = "kullaniciTipiIDDataGridViewTextBoxColumn";
            this.kullaniciTipiIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // quizDataSet2
            // 
            this.quizDataSet2.DataSetName = "QuizDataSet2";
            this.quizDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSorularBindingSource
            // 
            this.tblSorularBindingSource.DataMember = "tbl_Sorular";
            this.tblSorularBindingSource.DataSource = this.quizDataSet2;
            // 
            // tbl_SorularTableAdapter
            // 
            this.tbl_SorularTableAdapter.ClearBeforeFill = true;
            // 
            // soruIDDataGridViewTextBoxColumn
            // 
            this.soruIDDataGridViewTextBoxColumn.DataPropertyName = "SoruID";
            this.soruIDDataGridViewTextBoxColumn.HeaderText = "SoruID";
            this.soruIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soruIDDataGridViewTextBoxColumn.Name = "soruIDDataGridViewTextBoxColumn";
            this.soruIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.soruIDDataGridViewTextBoxColumn.Width = 125;
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
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "D";
            this.dDataGridViewTextBoxColumn.HeaderText = "D";
            this.dDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.Width = 125;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogruDataGridViewTextBoxColumn
            // 
            this.dogruDataGridViewTextBoxColumn.DataPropertyName = "Dogru";
            this.dogruDataGridViewTextBoxColumn.HeaderText = "Dogru";
            this.dogruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogruDataGridViewTextBoxColumn.Name = "dogruDataGridViewTextBoxColumn";
            this.dogruDataGridViewTextBoxColumn.Width = 125;
            // 
            // uniteIDDataGridViewTextBoxColumn
            // 
            this.uniteIDDataGridViewTextBoxColumn.DataPropertyName = "UniteID";
            this.uniteIDDataGridViewTextBoxColumn.HeaderText = "UniteID";
            this.uniteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uniteIDDataGridViewTextBoxColumn.Name = "uniteIDDataGridViewTextBoxColumn";
            this.uniteIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // konuIDDataGridViewTextBoxColumn
            // 
            this.konuIDDataGridViewTextBoxColumn.DataPropertyName = "KonuID";
            this.konuIDDataGridViewTextBoxColumn.HeaderText = "KonuID";
            this.konuIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konuIDDataGridViewTextBoxColumn.Name = "konuIDDataGridViewTextBoxColumn";
            this.konuIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // resimYolu1DataGridViewTextBoxColumn
            // 
            this.resimYolu1DataGridViewTextBoxColumn.DataPropertyName = "ResimYolu1";
            this.resimYolu1DataGridViewTextBoxColumn.HeaderText = "ResimYolu1";
            this.resimYolu1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resimYolu1DataGridViewTextBoxColumn.Name = "resimYolu1DataGridViewTextBoxColumn";
            this.resimYolu1DataGridViewTextBoxColumn.Width = 125;
            // 
            // button_kullaniciListelebutton_kullaniciListele
            // 
            this.button_kullaniciListelebutton_kullaniciListele.Location = new System.Drawing.Point(170, 340);
            this.button_kullaniciListelebutton_kullaniciListele.Name = "button_kullaniciListelebutton_kullaniciListele";
            this.button_kullaniciListelebutton_kullaniciListele.Size = new System.Drawing.Size(240, 23);
            this.button_kullaniciListelebutton_kullaniciListele.TabIndex = 3;
            this.button_kullaniciListelebutton_kullaniciListele.Text = "Kullanıcıları Listesini Güncelle";
            this.button_kullaniciListelebutton_kullaniciListele.UseVisualStyleBackColor = true;
            this.button_kullaniciListelebutton_kullaniciListele.Click += new System.EventHandler(this.button_kullaniciListelebutton_kullaniciListele_Click);
            // 
            // button_SorulariGüncelle
            // 
            this.button_SorulariGüncelle.Location = new System.Drawing.Point(1047, 358);
            this.button_SorulariGüncelle.Name = "button_SorulariGüncelle";
            this.button_SorulariGüncelle.Size = new System.Drawing.Size(192, 23);
            this.button_SorulariGüncelle.TabIndex = 4;
            this.button_SorulariGüncelle.Text = "Soru Listesini Güncelle";
            this.button_SorulariGüncelle.UseVisualStyleBackColor = true;
            this.button_SorulariGüncelle.Click += new System.EventHandler(this.button_SorulariGüncelle_Click);
            // 
            // label_KullaniciID
            // 
            this.label_KullaniciID.AutoSize = true;
            this.label_KullaniciID.Location = new System.Drawing.Point(228, 416);
            this.label_KullaniciID.Name = "label_KullaniciID";
            this.label_KullaniciID.Size = new System.Drawing.Size(0, 16);
            this.label_KullaniciID.TabIndex = 5;
            // 
            // label_soruID
            // 
            this.label_soruID.AutoSize = true;
            this.label_soruID.Location = new System.Drawing.Point(1088, 434);
            this.label_soruID.Name = "label_soruID";
            this.label_soruID.Size = new System.Drawing.Size(0, 16);
            this.label_soruID.TabIndex = 6;
            // 
            // button_KullaniciSil
            // 
            this.button_KullaniciSil.Location = new System.Drawing.Point(170, 369);
            this.button_KullaniciSil.Name = "button_KullaniciSil";
            this.button_KullaniciSil.Size = new System.Drawing.Size(240, 23);
            this.button_KullaniciSil.TabIndex = 7;
            this.button_KullaniciSil.Text = "Kullanıcı Sil";
            this.button_KullaniciSil.UseVisualStyleBackColor = true;
            this.button_KullaniciSil.Click += new System.EventHandler(this.button_KullaniciSil_Click);
            // 
            // button_soruSil
            // 
            this.button_soruSil.Location = new System.Drawing.Point(1047, 387);
            this.button_soruSil.Name = "button_soruSil";
            this.button_soruSil.Size = new System.Drawing.Size(192, 23);
            this.button_soruSil.TabIndex = 8;
            this.button_soruSil.Text = "Soru Sil";
            this.button_soruSil.UseVisualStyleBackColor = true;
            this.button_soruSil.Click += new System.EventHandler(this.button_soruSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Silinecek Kullanıcı ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Silinecek Kullanıcı ID : ";
            // 
            // AdminEkraniSecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1540, 711);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_soruSil);
            this.Controls.Add(this.button_KullaniciSil);
            this.Controls.Add(this.label_soruID);
            this.Controls.Add(this.label_KullaniciID);
            this.Controls.Add(this.button_SorulariGüncelle);
            this.Controls.Add(this.button_kullaniciListelebutton_kullaniciListele);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AdminEkraniSecme";
            this.Text = "AdminEkraniSecme";
            this.Load += new System.EventHandler(this.AdminEkraniSecme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSorularBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private QuizDataSet1 quizDataSet1;
        private System.Windows.Forms.BindingSource tblKullaniciBindingSource;
        private QuizDataSet1TableAdapters.Tbl_KullaniciTableAdapter tbl_KullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTipiIDDataGridViewTextBoxColumn;
        private QuizDataSet2 quizDataSet2;
        private System.Windows.Forms.BindingSource tblSorularBindingSource;
        private QuizDataSet2TableAdapters.tbl_SorularTableAdapter tbl_SorularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimYolu1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_kullaniciListelebutton_kullaniciListele;
        private System.Windows.Forms.Button button_SorulariGüncelle;
        private System.Windows.Forms.Label label_KullaniciID;
        private System.Windows.Forms.Label label_soruID;
        private System.Windows.Forms.Button button_KullaniciSil;
        private System.Windows.Forms.Button button_soruSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}