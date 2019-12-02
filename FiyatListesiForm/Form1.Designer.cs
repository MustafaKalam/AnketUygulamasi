namespace FiyatListesiForm
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
            this.components = new System.ComponentModel.Container();
            this.dgwMalzemeler = new System.Windows.Forms.DataGridView();
            this.gbxInsert = new System.Windows.Forms.GroupBox();
            this.cmbListeAdi = new System.Windows.Forms.ComboBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblMalzemeAdi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.chkYuzde = new System.Windows.Forms.CheckBox();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.TxtMalzemeKodu = new System.Windows.Forms.TextBox();
            this.lblMAalzemeKodu = new System.Windows.Forms.Label();
            this.lblListeAdi = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cmbListeAdiU = new System.Windows.Forms.ComboBox();
            this.txtBirimU = new System.Windows.Forms.TextBox();
            this.lblBirimU = new System.Windows.Forms.Label();
            this.txtMalzemeAdiU = new System.Windows.Forms.TextBox();
            this.lblMalzemeAdiU = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.chkYuzdeU = new System.Windows.Forms.CheckBox();
            this.txtIndirimU = new System.Windows.Forms.TextBox();
            this.lblIndirimU = new System.Windows.Forms.Label();
            this.TxtMalzemeKoduU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblListeAdiU = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.txtMalzemeSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbMalzemeSinifi = new System.Windows.Forms.ComboBox();
            this.malzemeSinifiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMalzemeSinifi = new System.Windows.Forms.Label();
            this.gridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMalzemeler)).BeginInit();
            this.gbxInsert.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeSinifiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMalzemeler
            // 
            this.dgwMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMalzemeler.Location = new System.Drawing.Point(12, 83);
            this.dgwMalzemeler.Name = "dgwMalzemeler";
            this.dgwMalzemeler.Size = new System.Drawing.Size(847, 348);
            this.dgwMalzemeler.TabIndex = 0;
            this.dgwMalzemeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMalzemeler_CellClick);
            // 
            // gbxInsert
            // 
            this.gbxInsert.Controls.Add(this.cmbListeAdi);
            this.gbxInsert.Controls.Add(this.txtBirim);
            this.gbxInsert.Controls.Add(this.txtMalzemeAdi);
            this.gbxInsert.Controls.Add(this.lblBirim);
            this.gbxInsert.Controls.Add(this.lblMalzemeAdi);
            this.gbxInsert.Controls.Add(this.btnEkle);
            this.gbxInsert.Controls.Add(this.chkYuzde);
            this.gbxInsert.Controls.Add(this.txtIndirim);
            this.gbxInsert.Controls.Add(this.lblIndirim);
            this.gbxInsert.Controls.Add(this.TxtMalzemeKodu);
            this.gbxInsert.Controls.Add(this.lblMAalzemeKodu);
            this.gbxInsert.Controls.Add(this.lblListeAdi);
            this.gbxInsert.Location = new System.Drawing.Point(35, 453);
            this.gbxInsert.Name = "gbxInsert";
            this.gbxInsert.Size = new System.Drawing.Size(349, 221);
            this.gbxInsert.TabIndex = 1;
            this.gbxInsert.TabStop = false;
            this.gbxInsert.Text = "Ekeleme İşlemi";
            // 
            // cmbListeAdi
            // 
            this.cmbListeAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListeAdi.FormattingEnabled = true;
            this.cmbListeAdi.Location = new System.Drawing.Point(109, 25);
            this.cmbListeAdi.Name = "cmbListeAdi";
            this.cmbListeAdi.Size = new System.Drawing.Size(234, 21);
            this.cmbListeAdi.TabIndex = 4;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(109, 103);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.ReadOnly = true;
            this.txtBirim.Size = new System.Drawing.Size(100, 20);
            this.txtBirim.TabIndex = 10;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(109, 77);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.ReadOnly = true;
            this.txtMalzemeAdi.Size = new System.Drawing.Size(234, 20);
            this.txtMalzemeAdi.TabIndex = 9;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(25, 106);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(31, 13);
            this.lblBirim.TabIndex = 4;
            this.lblBirim.Text = "Birimi";
            // 
            // lblMalzemeAdi
            // 
            this.lblMalzemeAdi.AutoSize = true;
            this.lblMalzemeAdi.Location = new System.Drawing.Point(25, 80);
            this.lblMalzemeAdi.Name = "lblMalzemeAdi";
            this.lblMalzemeAdi.Size = new System.Drawing.Size(67, 13);
            this.lblMalzemeAdi.TabIndex = 8;
            this.lblMalzemeAdi.Text = "Malzeme Adı";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(28, 167);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 34);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chkYuzde
            // 
            this.chkYuzde.AutoSize = true;
            this.chkYuzde.Location = new System.Drawing.Point(215, 132);
            this.chkYuzde.Name = "chkYuzde";
            this.chkYuzde.Size = new System.Drawing.Size(56, 17);
            this.chkYuzde.TabIndex = 6;
            this.chkYuzde.Text = "Yüzde";
            this.chkYuzde.UseVisualStyleBackColor = true;
            // 
            // txtIndirim
            // 
            this.txtIndirim.Location = new System.Drawing.Point(109, 130);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(100, 20);
            this.txtIndirim.TabIndex = 5;
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(25, 133);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(37, 13);
            this.lblIndirim.TabIndex = 4;
            this.lblIndirim.Text = "İndirim";
            // 
            // TxtMalzemeKodu
            // 
            this.TxtMalzemeKodu.Location = new System.Drawing.Point(109, 50);
            this.TxtMalzemeKodu.Name = "TxtMalzemeKodu";
            this.TxtMalzemeKodu.Size = new System.Drawing.Size(100, 20);
            this.TxtMalzemeKodu.TabIndex = 3;
            this.TxtMalzemeKodu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtMalzemeKodu_PreviewKeyDown);
            // 
            // lblMAalzemeKodu
            // 
            this.lblMAalzemeKodu.AutoSize = true;
            this.lblMAalzemeKodu.Location = new System.Drawing.Point(25, 53);
            this.lblMAalzemeKodu.Name = "lblMAalzemeKodu";
            this.lblMAalzemeKodu.Size = new System.Drawing.Size(77, 13);
            this.lblMAalzemeKodu.TabIndex = 2;
            this.lblMAalzemeKodu.Text = "Malzeme Kodu";
            // 
            // lblListeAdi
            // 
            this.lblListeAdi.AutoSize = true;
            this.lblListeAdi.Location = new System.Drawing.Point(25, 28);
            this.lblListeAdi.Name = "lblListeAdi";
            this.lblListeAdi.Size = new System.Drawing.Size(79, 13);
            this.lblListeAdi.TabIndex = 0;
            this.lblListeAdi.Text = "Fiyat Listesi Adı";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.cmbListeAdiU);
            this.gbxUpdate.Controls.Add(this.txtBirimU);
            this.gbxUpdate.Controls.Add(this.lblBirimU);
            this.gbxUpdate.Controls.Add(this.txtMalzemeAdiU);
            this.gbxUpdate.Controls.Add(this.lblMalzemeAdiU);
            this.gbxUpdate.Controls.Add(this.btnGuncelle);
            this.gbxUpdate.Controls.Add(this.chkYuzdeU);
            this.gbxUpdate.Controls.Add(this.txtIndirimU);
            this.gbxUpdate.Controls.Add(this.lblIndirimU);
            this.gbxUpdate.Controls.Add(this.TxtMalzemeKoduU);
            this.gbxUpdate.Controls.Add(this.label2);
            this.gbxUpdate.Controls.Add(this.lblListeAdiU);
            this.gbxUpdate.Location = new System.Drawing.Point(460, 453);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(349, 221);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Güncelleme İşlemi";
            // 
            // cmbListeAdiU
            // 
            this.cmbListeAdiU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListeAdiU.FormattingEnabled = true;
            this.cmbListeAdiU.Location = new System.Drawing.Point(109, 23);
            this.cmbListeAdiU.Name = "cmbListeAdiU";
            this.cmbListeAdiU.Size = new System.Drawing.Size(234, 21);
            this.cmbListeAdiU.TabIndex = 11;
            // 
            // txtBirimU
            // 
            this.txtBirimU.Location = new System.Drawing.Point(109, 103);
            this.txtBirimU.Name = "txtBirimU";
            this.txtBirimU.ReadOnly = true;
            this.txtBirimU.Size = new System.Drawing.Size(100, 20);
            this.txtBirimU.TabIndex = 12;
            // 
            // lblBirimU
            // 
            this.lblBirimU.AutoSize = true;
            this.lblBirimU.Location = new System.Drawing.Point(25, 106);
            this.lblBirimU.Name = "lblBirimU";
            this.lblBirimU.Size = new System.Drawing.Size(31, 13);
            this.lblBirimU.TabIndex = 11;
            this.lblBirimU.Text = "Birimi";
            // 
            // txtMalzemeAdiU
            // 
            this.txtMalzemeAdiU.Location = new System.Drawing.Point(109, 77);
            this.txtMalzemeAdiU.Name = "txtMalzemeAdiU";
            this.txtMalzemeAdiU.ReadOnly = true;
            this.txtMalzemeAdiU.Size = new System.Drawing.Size(234, 20);
            this.txtMalzemeAdiU.TabIndex = 12;
            // 
            // lblMalzemeAdiU
            // 
            this.lblMalzemeAdiU.AutoSize = true;
            this.lblMalzemeAdiU.Location = new System.Drawing.Point(25, 80);
            this.lblMalzemeAdiU.Name = "lblMalzemeAdiU";
            this.lblMalzemeAdiU.Size = new System.Drawing.Size(67, 13);
            this.lblMalzemeAdiU.TabIndex = 11;
            this.lblMalzemeAdiU.Text = "Malzeme Adı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(28, 166);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 34);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // chkYuzdeU
            // 
            this.chkYuzdeU.AutoSize = true;
            this.chkYuzdeU.Location = new System.Drawing.Point(215, 132);
            this.chkYuzdeU.Name = "chkYuzdeU";
            this.chkYuzdeU.Size = new System.Drawing.Size(56, 17);
            this.chkYuzdeU.TabIndex = 6;
            this.chkYuzdeU.Text = "Yüzde";
            this.chkYuzdeU.UseVisualStyleBackColor = true;
            // 
            // txtIndirimU
            // 
            this.txtIndirimU.Location = new System.Drawing.Point(109, 129);
            this.txtIndirimU.Name = "txtIndirimU";
            this.txtIndirimU.Size = new System.Drawing.Size(100, 20);
            this.txtIndirimU.TabIndex = 5;
            // 
            // lblIndirimU
            // 
            this.lblIndirimU.AutoSize = true;
            this.lblIndirimU.Location = new System.Drawing.Point(25, 132);
            this.lblIndirimU.Name = "lblIndirimU";
            this.lblIndirimU.Size = new System.Drawing.Size(37, 13);
            this.lblIndirimU.TabIndex = 4;
            this.lblIndirimU.Text = "İndirim";
            // 
            // TxtMalzemeKoduU
            // 
            this.TxtMalzemeKoduU.Location = new System.Drawing.Point(109, 50);
            this.TxtMalzemeKoduU.Name = "TxtMalzemeKoduU";
            this.TxtMalzemeKoduU.Size = new System.Drawing.Size(100, 20);
            this.TxtMalzemeKoduU.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Malzeme Kodu";
            // 
            // lblListeAdiU
            // 
            this.lblListeAdiU.AutoSize = true;
            this.lblListeAdiU.Location = new System.Drawing.Point(25, 28);
            this.lblListeAdiU.Name = "lblListeAdiU";
            this.lblListeAdiU.Size = new System.Drawing.Size(79, 13);
            this.lblListeAdiU.TabIndex = 0;
            this.lblListeAdiU.Text = "Fiyat Listesi Adı";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.txtMalzemeSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Controls.Add(this.cmbMalzemeSinifi);
            this.gbxSearch.Controls.Add(this.lblMalzemeSinifi);
            this.gbxSearch.Location = new System.Drawing.Point(12, 13);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(847, 64);
            this.gbxSearch.TabIndex = 9;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Arama İşlemleri";
            // 
            // txtMalzemeSearch
            // 
            this.txtMalzemeSearch.Location = new System.Drawing.Point(497, 27);
            this.txtMalzemeSearch.Name = "txtMalzemeSearch";
            this.txtMalzemeSearch.Size = new System.Drawing.Size(160, 20);
            this.txtMalzemeSearch.TabIndex = 3;
            this.txtMalzemeSearch.TextChanged += new System.EventHandler(this.txtMalzemeSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(414, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(77, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Malzeme Kodu";
            // 
            // cmbMalzemeSinifi
            // 
            this.cmbMalzemeSinifi.DataSource = this.malzemeSinifiBindingSource;
            this.cmbMalzemeSinifi.DisplayMember = "malzeme_sinifi_adi";
            this.cmbMalzemeSinifi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMalzemeSinifi.FormattingEnabled = true;
            this.cmbMalzemeSinifi.Location = new System.Drawing.Point(110, 27);
            this.cmbMalzemeSinifi.Name = "cmbMalzemeSinifi";
            this.cmbMalzemeSinifi.Size = new System.Drawing.Size(145, 21);
            this.cmbMalzemeSinifi.TabIndex = 1;
            this.cmbMalzemeSinifi.ValueMember = "malzeme_sinifi_id";
            this.cmbMalzemeSinifi.SelectedIndexChanged += new System.EventHandler(this.cmbMalzemeSinifi_SelectedIndexChanged);
            // 
            // malzemeSinifiBindingSource
            // 
            this.malzemeSinifiBindingSource.DataSource = typeof(FiyatListesiAdoNET.DataAccess.Concreate.MalzemeSinifi);
            // 
            // lblMalzemeSinifi
            // 
            this.lblMalzemeSinifi.AutoSize = true;
            this.lblMalzemeSinifi.Location = new System.Drawing.Point(20, 30);
            this.lblMalzemeSinifi.Name = "lblMalzemeSinifi";
            this.lblMalzemeSinifi.Size = new System.Drawing.Size(74, 13);
            this.lblMalzemeSinifi.TabIndex = 0;
            this.lblMalzemeSinifi.Text = "Malzeme Sınıfı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 686);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxInsert);
            this.Controls.Add(this.dgwMalzemeler);
            this.Name = "Form1";
            this.Text = "Fiyat Listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMalzemeler)).EndInit();
            this.gbxInsert.ResumeLayout(false);
            this.gbxInsert.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeSinifiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMalzemeler;
        private System.Windows.Forms.GroupBox gbxInsert;
        private System.Windows.Forms.Label lblListeAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkYuzde;
        private System.Windows.Forms.TextBox txtIndirim;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.TextBox TxtMalzemeKodu;
        private System.Windows.Forms.Label lblMAalzemeKodu;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.CheckBox chkYuzdeU;
        private System.Windows.Forms.TextBox txtIndirimU;
        private System.Windows.Forms.Label lblIndirimU;
        private System.Windows.Forms.TextBox TxtMalzemeKoduU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblListeAdiU;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox txtMalzemeSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbMalzemeSinifi;
        private System.Windows.Forms.Label lblMalzemeSinifi;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Label lblMalzemeAdi;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.ComboBox cmbListeAdi;
        private System.Windows.Forms.TextBox txtBirimU;
        private System.Windows.Forms.Label lblBirimU;
        private System.Windows.Forms.TextBox txtMalzemeAdiU;
        private System.Windows.Forms.Label lblMalzemeAdiU;
        private System.Windows.Forms.ComboBox cmbListeAdiU;
        private System.Windows.Forms.BindingSource malzemeSinifiBindingSource;
        private System.Windows.Forms.BindingSource gridBindingSource;
    }
}

