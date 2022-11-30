namespace WebFormsUI
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
            this.dgwKitap = new System.Windows.Forms.DataGridView();
            this.gbxUye = new System.Windows.Forms.GroupBox();
            this.cbxUye = new System.Windows.Forms.ComboBox();
            this.lblUye = new System.Windows.Forms.Label();
            this.gbxKitap = new System.Windows.Forms.GroupBox();
            this.tbxKitap = new System.Windows.Forms.TextBox();
            this.lblKitap = new System.Windows.Forms.Label();
            this.gbxKitapEkle = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxSayfaEkle = new System.Windows.Forms.TextBox();
            this.lblSayfaEkle = new System.Windows.Forms.Label();
            this.tbxUygunlukEkle = new System.Windows.Forms.TextBox();
            this.tbxYazarEkle = new System.Windows.Forms.TextBox();
            this.tbxKitapAdiEkle = new System.Windows.Forms.TextBox();
            this.lblYazarEkle = new System.Windows.Forms.Label();
            this.lblUygunlukEkle = new System.Windows.Forms.Label();
            this.lblTurEkle = new System.Windows.Forms.Label();
            this.lblKitapAdiEkle = new System.Windows.Forms.Label();
            this.gbxKitapGüncelle = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxTurGüncelle = new System.Windows.Forms.ComboBox();
            this.tbxSayfaGüncelle = new System.Windows.Forms.TextBox();
            this.lblSayfaGüncelle = new System.Windows.Forms.Label();
            this.tbxUygunlukGüncelle = new System.Windows.Forms.TextBox();
            this.tbxYazarGüncelle = new System.Windows.Forms.TextBox();
            this.tbxKitapAdiGüncelle = new System.Windows.Forms.TextBox();
            this.lblYazarGüncelle = new System.Windows.Forms.Label();
            this.lblUygunlukGüncelle = new System.Windows.Forms.Label();
            this.lblTürGüncelle = new System.Windows.Forms.Label();
            this.lblKitapAdiGüncelle = new System.Windows.Forms.Label();
            this.gbxKitapSil = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxTurSil = new System.Windows.Forms.ComboBox();
            this.tbxSayfaSil = new System.Windows.Forms.TextBox();
            this.lblSayfaSil = new System.Windows.Forms.Label();
            this.tbxUygunlukSil = new System.Windows.Forms.TextBox();
            this.tbxYazarSil = new System.Windows.Forms.TextBox();
            this.tbxKitapAdiSil = new System.Windows.Forms.TextBox();
            this.lblYazarSil = new System.Windows.Forms.Label();
            this.lblUygunlukSil = new System.Windows.Forms.Label();
            this.lblTürSil = new System.Windows.Forms.Label();
            this.lblKitapAdıSil = new System.Windows.Forms.Label();
            this.tbxTurEkle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitap)).BeginInit();
            this.gbxUye.SuspendLayout();
            this.gbxKitap.SuspendLayout();
            this.gbxKitapEkle.SuspendLayout();
            this.gbxKitapGüncelle.SuspendLayout();
            this.gbxKitapSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwKitap
            // 
            this.dgwKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitap.Location = new System.Drawing.Point(12, 481);
            this.dgwKitap.Name = "dgwKitap";
            this.dgwKitap.Size = new System.Drawing.Size(765, 150);
            this.dgwKitap.TabIndex = 0;
            this.dgwKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxUye
            // 
            this.gbxUye.Controls.Add(this.cbxUye);
            this.gbxUye.Controls.Add(this.lblUye);
            this.gbxUye.Location = new System.Drawing.Point(307, 15);
            this.gbxUye.Name = "gbxUye";
            this.gbxUye.Size = new System.Drawing.Size(276, 102);
            this.gbxUye.TabIndex = 1;
            this.gbxUye.TabStop = false;
            this.gbxUye.Text = "Uye";
            // 
            // cbxUye
            // 
            this.cbxUye.FormattingEnabled = true;
            this.cbxUye.Location = new System.Drawing.Point(84, 34);
            this.cbxUye.Name = "cbxUye";
            this.cbxUye.Size = new System.Drawing.Size(176, 21);
            this.cbxUye.TabIndex = 1;
            this.cbxUye.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblUye
            // 
            this.lblUye.AutoSize = true;
            this.lblUye.Location = new System.Drawing.Point(6, 37);
            this.lblUye.Name = "lblUye";
            this.lblUye.Size = new System.Drawing.Size(29, 13);
            this.lblUye.TabIndex = 0;
            this.lblUye.Text = "Uye:";
            // 
            // gbxKitap
            // 
            this.gbxKitap.Controls.Add(this.tbxKitap);
            this.gbxKitap.Controls.Add(this.lblKitap);
            this.gbxKitap.Location = new System.Drawing.Point(25, 15);
            this.gbxKitap.Name = "gbxKitap";
            this.gbxKitap.Size = new System.Drawing.Size(276, 100);
            this.gbxKitap.TabIndex = 2;
            this.gbxKitap.TabStop = false;
            this.gbxKitap.Text = "Kitap";
            // 
            // tbxKitap
            // 
            this.tbxKitap.Location = new System.Drawing.Point(84, 33);
            this.tbxKitap.Name = "tbxKitap";
            this.tbxKitap.Size = new System.Drawing.Size(176, 20);
            this.tbxKitap.TabIndex = 1;
            this.tbxKitap.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Location = new System.Drawing.Point(6, 36);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(31, 13);
            this.lblKitap.TabIndex = 0;
            this.lblKitap.Text = "Kitap";
            // 
            // gbxKitapEkle
            // 
            this.gbxKitapEkle.Controls.Add(this.tbxTurEkle);
            this.gbxKitapEkle.Controls.Add(this.btnAdd);
            this.gbxKitapEkle.Controls.Add(this.tbxSayfaEkle);
            this.gbxKitapEkle.Controls.Add(this.lblSayfaEkle);
            this.gbxKitapEkle.Controls.Add(this.tbxUygunlukEkle);
            this.gbxKitapEkle.Controls.Add(this.tbxYazarEkle);
            this.gbxKitapEkle.Controls.Add(this.tbxKitapAdiEkle);
            this.gbxKitapEkle.Controls.Add(this.lblYazarEkle);
            this.gbxKitapEkle.Controls.Add(this.lblUygunlukEkle);
            this.gbxKitapEkle.Controls.Add(this.lblTurEkle);
            this.gbxKitapEkle.Controls.Add(this.lblKitapAdiEkle);
            this.gbxKitapEkle.Location = new System.Drawing.Point(25, 121);
            this.gbxKitapEkle.Name = "gbxKitapEkle";
            this.gbxKitapEkle.Size = new System.Drawing.Size(558, 112);
            this.gbxKitapEkle.TabIndex = 3;
            this.gbxKitapEkle.TabStop = false;
            this.gbxKitapEkle.Text = "Kitap Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(359, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxSayfaEkle
            // 
            this.tbxSayfaEkle.Location = new System.Drawing.Point(359, 53);
            this.tbxSayfaEkle.Name = "tbxSayfaEkle";
            this.tbxSayfaEkle.Size = new System.Drawing.Size(176, 20);
            this.tbxSayfaEkle.TabIndex = 8;
            // 
            // lblSayfaEkle
            // 
            this.lblSayfaEkle.AutoSize = true;
            this.lblSayfaEkle.Location = new System.Drawing.Point(266, 55);
            this.lblSayfaEkle.Name = "lblSayfaEkle";
            this.lblSayfaEkle.Size = new System.Drawing.Size(34, 13);
            this.lblSayfaEkle.TabIndex = 7;
            this.lblSayfaEkle.Text = "Sayfa";
            // 
            // tbxUygunlukEkle
            // 
            this.tbxUygunlukEkle.Location = new System.Drawing.Point(84, 78);
            this.tbxUygunlukEkle.Name = "tbxUygunlukEkle";
            this.tbxUygunlukEkle.Size = new System.Drawing.Size(176, 20);
            this.tbxUygunlukEkle.TabIndex = 6;
            // 
            // tbxYazarEkle
            // 
            this.tbxYazarEkle.Location = new System.Drawing.Point(359, 27);
            this.tbxYazarEkle.Name = "tbxYazarEkle";
            this.tbxYazarEkle.Size = new System.Drawing.Size(176, 20);
            this.tbxYazarEkle.TabIndex = 4;
            // 
            // tbxKitapAdiEkle
            // 
            this.tbxKitapAdiEkle.Location = new System.Drawing.Point(84, 30);
            this.tbxKitapAdiEkle.Name = "tbxKitapAdiEkle";
            this.tbxKitapAdiEkle.Size = new System.Drawing.Size(176, 20);
            this.tbxKitapAdiEkle.TabIndex = 2;
            // 
            // lblYazarEkle
            // 
            this.lblYazarEkle.AutoSize = true;
            this.lblYazarEkle.Location = new System.Drawing.Point(266, 30);
            this.lblYazarEkle.Name = "lblYazarEkle";
            this.lblYazarEkle.Size = new System.Drawing.Size(34, 13);
            this.lblYazarEkle.TabIndex = 3;
            this.lblYazarEkle.Text = "Yazar";
            // 
            // lblUygunlukEkle
            // 
            this.lblUygunlukEkle.AutoSize = true;
            this.lblUygunlukEkle.Location = new System.Drawing.Point(6, 81);
            this.lblUygunlukEkle.Name = "lblUygunlukEkle";
            this.lblUygunlukEkle.Size = new System.Drawing.Size(52, 13);
            this.lblUygunlukEkle.TabIndex = 2;
            this.lblUygunlukEkle.Text = "Uygunluk";
            // 
            // lblTurEkle
            // 
            this.lblTurEkle.AutoSize = true;
            this.lblTurEkle.Location = new System.Drawing.Point(6, 55);
            this.lblTurEkle.Name = "lblTurEkle";
            this.lblTurEkle.Size = new System.Drawing.Size(23, 13);
            this.lblTurEkle.TabIndex = 1;
            this.lblTurEkle.Text = "Tür";
            // 
            // lblKitapAdiEkle
            // 
            this.lblKitapAdiEkle.AutoSize = true;
            this.lblKitapAdiEkle.Location = new System.Drawing.Point(6, 30);
            this.lblKitapAdiEkle.Name = "lblKitapAdiEkle";
            this.lblKitapAdiEkle.Size = new System.Drawing.Size(49, 13);
            this.lblKitapAdiEkle.TabIndex = 0;
            this.lblKitapAdiEkle.Text = "Kitap Adı";
            // 
            // gbxKitapGüncelle
            // 
            this.gbxKitapGüncelle.Controls.Add(this.btnUpdate);
            this.gbxKitapGüncelle.Controls.Add(this.cbxTurGüncelle);
            this.gbxKitapGüncelle.Controls.Add(this.tbxSayfaGüncelle);
            this.gbxKitapGüncelle.Controls.Add(this.lblSayfaGüncelle);
            this.gbxKitapGüncelle.Controls.Add(this.tbxUygunlukGüncelle);
            this.gbxKitapGüncelle.Controls.Add(this.tbxYazarGüncelle);
            this.gbxKitapGüncelle.Controls.Add(this.tbxKitapAdiGüncelle);
            this.gbxKitapGüncelle.Controls.Add(this.lblYazarGüncelle);
            this.gbxKitapGüncelle.Controls.Add(this.lblUygunlukGüncelle);
            this.gbxKitapGüncelle.Controls.Add(this.lblTürGüncelle);
            this.gbxKitapGüncelle.Controls.Add(this.lblKitapAdiGüncelle);
            this.gbxKitapGüncelle.Location = new System.Drawing.Point(25, 239);
            this.gbxKitapGüncelle.Name = "gbxKitapGüncelle";
            this.gbxKitapGüncelle.Size = new System.Drawing.Size(558, 112);
            this.gbxKitapGüncelle.TabIndex = 10;
            this.gbxKitapGüncelle.TabStop = false;
            this.gbxKitapGüncelle.Text = "Kitap Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(359, 81);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxTurGüncelle
            // 
            this.cbxTurGüncelle.FormattingEnabled = true;
            this.cbxTurGüncelle.Location = new System.Drawing.Point(84, 53);
            this.cbxTurGüncelle.Name = "cbxTurGüncelle";
            this.cbxTurGüncelle.Size = new System.Drawing.Size(176, 21);
            this.cbxTurGüncelle.TabIndex = 2;
            // 
            // tbxSayfaGüncelle
            // 
            this.tbxSayfaGüncelle.Location = new System.Drawing.Point(359, 53);
            this.tbxSayfaGüncelle.Name = "tbxSayfaGüncelle";
            this.tbxSayfaGüncelle.Size = new System.Drawing.Size(176, 20);
            this.tbxSayfaGüncelle.TabIndex = 8;
            // 
            // lblSayfaGüncelle
            // 
            this.lblSayfaGüncelle.AutoSize = true;
            this.lblSayfaGüncelle.Location = new System.Drawing.Point(266, 55);
            this.lblSayfaGüncelle.Name = "lblSayfaGüncelle";
            this.lblSayfaGüncelle.Size = new System.Drawing.Size(34, 13);
            this.lblSayfaGüncelle.TabIndex = 7;
            this.lblSayfaGüncelle.Text = "Sayfa";
            // 
            // tbxUygunlukGüncelle
            // 
            this.tbxUygunlukGüncelle.Location = new System.Drawing.Point(84, 78);
            this.tbxUygunlukGüncelle.Name = "tbxUygunlukGüncelle";
            this.tbxUygunlukGüncelle.Size = new System.Drawing.Size(176, 20);
            this.tbxUygunlukGüncelle.TabIndex = 6;
            // 
            // tbxYazarGüncelle
            // 
            this.tbxYazarGüncelle.Location = new System.Drawing.Point(359, 27);
            this.tbxYazarGüncelle.Name = "tbxYazarGüncelle";
            this.tbxYazarGüncelle.Size = new System.Drawing.Size(176, 20);
            this.tbxYazarGüncelle.TabIndex = 4;
            // 
            // tbxKitapAdiGüncelle
            // 
            this.tbxKitapAdiGüncelle.Location = new System.Drawing.Point(84, 27);
            this.tbxKitapAdiGüncelle.Name = "tbxKitapAdiGüncelle";
            this.tbxKitapAdiGüncelle.Size = new System.Drawing.Size(176, 20);
            this.tbxKitapAdiGüncelle.TabIndex = 2;
            // 
            // lblYazarGüncelle
            // 
            this.lblYazarGüncelle.AutoSize = true;
            this.lblYazarGüncelle.Location = new System.Drawing.Point(266, 30);
            this.lblYazarGüncelle.Name = "lblYazarGüncelle";
            this.lblYazarGüncelle.Size = new System.Drawing.Size(34, 13);
            this.lblYazarGüncelle.TabIndex = 3;
            this.lblYazarGüncelle.Text = "Yazar";
            // 
            // lblUygunlukGüncelle
            // 
            this.lblUygunlukGüncelle.AutoSize = true;
            this.lblUygunlukGüncelle.Location = new System.Drawing.Point(6, 81);
            this.lblUygunlukGüncelle.Name = "lblUygunlukGüncelle";
            this.lblUygunlukGüncelle.Size = new System.Drawing.Size(52, 13);
            this.lblUygunlukGüncelle.TabIndex = 2;
            this.lblUygunlukGüncelle.Text = "Uygunluk";
            // 
            // lblTürGüncelle
            // 
            this.lblTürGüncelle.AutoSize = true;
            this.lblTürGüncelle.Location = new System.Drawing.Point(6, 55);
            this.lblTürGüncelle.Name = "lblTürGüncelle";
            this.lblTürGüncelle.Size = new System.Drawing.Size(23, 13);
            this.lblTürGüncelle.TabIndex = 1;
            this.lblTürGüncelle.Text = "Tür";
            // 
            // lblKitapAdiGüncelle
            // 
            this.lblKitapAdiGüncelle.AutoSize = true;
            this.lblKitapAdiGüncelle.Location = new System.Drawing.Point(6, 30);
            this.lblKitapAdiGüncelle.Name = "lblKitapAdiGüncelle";
            this.lblKitapAdiGüncelle.Size = new System.Drawing.Size(49, 13);
            this.lblKitapAdiGüncelle.TabIndex = 0;
            this.lblKitapAdiGüncelle.Text = "Kitap Adı";
            // 
            // gbxKitapSil
            // 
            this.gbxKitapSil.Controls.Add(this.btnDelete);
            this.gbxKitapSil.Controls.Add(this.cbxTurSil);
            this.gbxKitapSil.Controls.Add(this.tbxSayfaSil);
            this.gbxKitapSil.Controls.Add(this.lblSayfaSil);
            this.gbxKitapSil.Controls.Add(this.tbxUygunlukSil);
            this.gbxKitapSil.Controls.Add(this.tbxYazarSil);
            this.gbxKitapSil.Controls.Add(this.tbxKitapAdiSil);
            this.gbxKitapSil.Controls.Add(this.lblYazarSil);
            this.gbxKitapSil.Controls.Add(this.lblUygunlukSil);
            this.gbxKitapSil.Controls.Add(this.lblTürSil);
            this.gbxKitapSil.Controls.Add(this.lblKitapAdıSil);
            this.gbxKitapSil.Location = new System.Drawing.Point(25, 357);
            this.gbxKitapSil.Name = "gbxKitapSil";
            this.gbxKitapSil.Size = new System.Drawing.Size(558, 112);
            this.gbxKitapSil.TabIndex = 11;
            this.gbxKitapSil.TabStop = false;
            this.gbxKitapSil.Text = "Kitap Sil";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(359, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxTurSil
            // 
            this.cbxTurSil.FormattingEnabled = true;
            this.cbxTurSil.Location = new System.Drawing.Point(84, 53);
            this.cbxTurSil.Name = "cbxTurSil";
            this.cbxTurSil.Size = new System.Drawing.Size(176, 21);
            this.cbxTurSil.TabIndex = 2;
            // 
            // tbxSayfaSil
            // 
            this.tbxSayfaSil.Location = new System.Drawing.Point(359, 53);
            this.tbxSayfaSil.Name = "tbxSayfaSil";
            this.tbxSayfaSil.Size = new System.Drawing.Size(176, 20);
            this.tbxSayfaSil.TabIndex = 8;
            // 
            // lblSayfaSil
            // 
            this.lblSayfaSil.AutoSize = true;
            this.lblSayfaSil.Location = new System.Drawing.Point(266, 55);
            this.lblSayfaSil.Name = "lblSayfaSil";
            this.lblSayfaSil.Size = new System.Drawing.Size(34, 13);
            this.lblSayfaSil.TabIndex = 7;
            this.lblSayfaSil.Text = "Sayfa";
            // 
            // tbxUygunlukSil
            // 
            this.tbxUygunlukSil.Location = new System.Drawing.Point(84, 78);
            this.tbxUygunlukSil.Name = "tbxUygunlukSil";
            this.tbxUygunlukSil.Size = new System.Drawing.Size(176, 20);
            this.tbxUygunlukSil.TabIndex = 6;
            // 
            // tbxYazarSil
            // 
            this.tbxYazarSil.Location = new System.Drawing.Point(359, 27);
            this.tbxYazarSil.Name = "tbxYazarSil";
            this.tbxYazarSil.Size = new System.Drawing.Size(176, 20);
            this.tbxYazarSil.TabIndex = 4;
            // 
            // tbxKitapAdiSil
            // 
            this.tbxKitapAdiSil.Location = new System.Drawing.Point(84, 27);
            this.tbxKitapAdiSil.Name = "tbxKitapAdiSil";
            this.tbxKitapAdiSil.Size = new System.Drawing.Size(176, 20);
            this.tbxKitapAdiSil.TabIndex = 2;
            // 
            // lblYazarSil
            // 
            this.lblYazarSil.AutoSize = true;
            this.lblYazarSil.Location = new System.Drawing.Point(266, 30);
            this.lblYazarSil.Name = "lblYazarSil";
            this.lblYazarSil.Size = new System.Drawing.Size(34, 13);
            this.lblYazarSil.TabIndex = 3;
            this.lblYazarSil.Text = "Yazar";
            // 
            // lblUygunlukSil
            // 
            this.lblUygunlukSil.AutoSize = true;
            this.lblUygunlukSil.Location = new System.Drawing.Point(6, 81);
            this.lblUygunlukSil.Name = "lblUygunlukSil";
            this.lblUygunlukSil.Size = new System.Drawing.Size(52, 13);
            this.lblUygunlukSil.TabIndex = 2;
            this.lblUygunlukSil.Text = "Uygunluk";
            // 
            // lblTürSil
            // 
            this.lblTürSil.AutoSize = true;
            this.lblTürSil.Location = new System.Drawing.Point(6, 55);
            this.lblTürSil.Name = "lblTürSil";
            this.lblTürSil.Size = new System.Drawing.Size(23, 13);
            this.lblTürSil.TabIndex = 1;
            this.lblTürSil.Text = "Tür";
            // 
            // lblKitapAdıSil
            // 
            this.lblKitapAdıSil.AutoSize = true;
            this.lblKitapAdıSil.Location = new System.Drawing.Point(6, 30);
            this.lblKitapAdıSil.Name = "lblKitapAdıSil";
            this.lblKitapAdıSil.Size = new System.Drawing.Size(49, 13);
            this.lblKitapAdıSil.TabIndex = 0;
            this.lblKitapAdıSil.Text = "Kitap Adı";
            // 
            // tbxTurEkle
            // 
            this.tbxTurEkle.Location = new System.Drawing.Point(84, 56);
            this.tbxTurEkle.Name = "tbxTurEkle";
            this.tbxTurEkle.Size = new System.Drawing.Size(176, 20);
            this.tbxTurEkle.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 643);
            this.Controls.Add(this.gbxKitapSil);
            this.Controls.Add(this.gbxKitapGüncelle);
            this.Controls.Add(this.gbxKitapEkle);
            this.Controls.Add(this.gbxKitap);
            this.Controls.Add(this.gbxUye);
            this.Controls.Add(this.dgwKitap);
            this.Name = "Form1";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitap)).EndInit();
            this.gbxUye.ResumeLayout(false);
            this.gbxUye.PerformLayout();
            this.gbxKitap.ResumeLayout(false);
            this.gbxKitap.PerformLayout();
            this.gbxKitapEkle.ResumeLayout(false);
            this.gbxKitapEkle.PerformLayout();
            this.gbxKitapGüncelle.ResumeLayout(false);
            this.gbxKitapGüncelle.PerformLayout();
            this.gbxKitapSil.ResumeLayout(false);
            this.gbxKitapSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKitap;
        private System.Windows.Forms.GroupBox gbxUye;
        private System.Windows.Forms.ComboBox cbxUye;
        private System.Windows.Forms.Label lblUye;
        private System.Windows.Forms.GroupBox gbxKitap;
        private System.Windows.Forms.TextBox tbxKitap;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.GroupBox gbxKitapEkle;
        private System.Windows.Forms.TextBox tbxSayfaEkle;
        private System.Windows.Forms.Label lblSayfaEkle;
        private System.Windows.Forms.TextBox tbxUygunlukEkle;
        private System.Windows.Forms.TextBox tbxYazarEkle;
        private System.Windows.Forms.TextBox tbxKitapAdiEkle;
        private System.Windows.Forms.Label lblYazarEkle;
        private System.Windows.Forms.Label lblUygunlukEkle;
        private System.Windows.Forms.Label lblTurEkle;
        private System.Windows.Forms.Label lblKitapAdiEkle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxKitapGüncelle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxTurGüncelle;
        private System.Windows.Forms.TextBox tbxSayfaGüncelle;
        private System.Windows.Forms.Label lblSayfaGüncelle;
        private System.Windows.Forms.TextBox tbxUygunlukGüncelle;
        private System.Windows.Forms.TextBox tbxYazarGüncelle;
        private System.Windows.Forms.TextBox tbxKitapAdiGüncelle;
        private System.Windows.Forms.Label lblYazarGüncelle;
        private System.Windows.Forms.Label lblUygunlukGüncelle;
        private System.Windows.Forms.Label lblTürGüncelle;
        private System.Windows.Forms.Label lblKitapAdiGüncelle;
        private System.Windows.Forms.GroupBox gbxKitapSil;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxTurSil;
        private System.Windows.Forms.TextBox tbxSayfaSil;
        private System.Windows.Forms.Label lblSayfaSil;
        private System.Windows.Forms.TextBox tbxUygunlukSil;
        private System.Windows.Forms.TextBox tbxYazarSil;
        private System.Windows.Forms.TextBox tbxKitapAdiSil;
        private System.Windows.Forms.Label lblYazarSil;
        private System.Windows.Forms.Label lblUygunlukSil;
        private System.Windows.Forms.Label lblTürSil;
        private System.Windows.Forms.Label lblKitapAdıSil;
        private System.Windows.Forms.TextBox tbxTurEkle;
    }
}

