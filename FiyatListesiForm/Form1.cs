using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiyatListesiAdoNET.DataAccess.Concreate;

namespace FiyatListesiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            MalzemeSinifiDoldur();
            FiyatListesiDoldur();
        }

        private void LoadSettings()
        {
            FiyatListesiDal fiyatListesiDal = new FiyatListesiDal();
            dgwMalzemeler.DataSource = fiyatListesiDal.DetayListeGetir();

            dgwMalzemeler.Columns[0].Visible = false;
            dgwMalzemeler.Columns[1].Visible = false;
            dgwMalzemeler.Columns[8].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int _chkYuzde;
            if (chkYuzde.Checked == true)
            {
                _chkYuzde = 1;
            }
            else
            {
                _chkYuzde = 0;
            }
            if (KayitKontrol())
            {
                Malzemeler malzemeler = new Malzemeler
                {
                    fiyat_liste_rsayac = Convert.ToInt32(cmbListeAdi.SelectedValue),
                    malzeme_kodu = TxtMalzemeKodu.Text,
                    indirim01_flag = _chkYuzde,
                    indirim01 = Convert.ToInt32(txtIndirim.Text),
                    birim = txtBirim.Text,
                    cid = "JOT"
                };

                FiyatListesiDal fiyatListesiDal = new FiyatListesiDal();
                fiyatListesiDal.Insert(malzemeler);
                MessageBox.Show("Kayıt İşlemi Başarılı.");

                LoadSettings();
            }
        }

        private void dgwMalzemeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ss = dgwMalzemeler.CurrentRow.Cells[2].Value.ToString();
            int aa = cmbListeAdiU.FindString(dgwMalzemeler.CurrentRow.Cells[2].Value.ToString());
            cmbListeAdiU.SelectedIndex = cmbListeAdiU.FindStringExact(dgwMalzemeler.CurrentRow.Cells[2].Value.ToString());
            TxtMalzemeKoduU.Text = dgwMalzemeler.CurrentRow.Cells[3].Value.ToString();
            txtMalzemeAdiU.Text = dgwMalzemeler.CurrentRow.Cells[4].Value.ToString();
            txtBirimU.Text = dgwMalzemeler.CurrentRow.Cells[5].Value.ToString();

            if (dgwMalzemeler.CurrentRow.Cells[6].Value.ToString() == "0")
            {
                chkYuzdeU.Checked = false;
            }
            else
            {
                chkYuzdeU.Checked = true;
            }
            txtIndirimU.Text = dgwMalzemeler.CurrentRow.Cells[7].Value.ToString();
            lblSearch.Text = dgwMalzemeler.Columns[dgwMalzemeler.CurrentCell.ColumnIndex].HeaderText.ToString(); //mk

            //string msg = String.Format("Row: {0}, Column: {1}", dgwMalzemeler.CurrentCell.RowIndex, dgwMalzemeler.CurrentCell.ColumnIndex);
            //MessageBox.Show(msg, "Current Cell");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int yuzde;
            if (chkYuzdeU.Checked == true)
            {
                yuzde = 1;
            }
            else
            {
                yuzde = 0;
            }
            Malzemeler malzemeler = new Malzemeler
            {
                r_sayac = Convert.ToInt32(dgwMalzemeler.CurrentRow.Cells[0].Value),
                malzeme_kodu = TxtMalzemeKoduU.Text,
                fiyat_liste_rsayac = Convert.ToInt32(cmbListeAdiU.SelectedValue),
                indirim01 = Convert.ToInt32(txtIndirimU.Text),
                indirim01_flag = yuzde
            };

            FiyatListesiDal fiyatListesiDal = new FiyatListesiDal();
            fiyatListesiDal.Update(malzemeler);
            MessageBox.Show("Güncelleme İşleme Başarılı!");

            LoadSettings();
        }

        public void MalzemeSinifiDoldur()
        {
            FiyatListesiDal fiyatListesiDal = new FiyatListesiDal();
            cmbMalzemeSinifi.DataSource = fiyatListesiDal.MalzemeSinifiLoad();
        }

        private void TxtMalzemeKodu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab || e.KeyData == Keys.Enter)
            {
                FiyatListesiDal fiyatListesiDal = new FiyatListesiDal();
                var malzemeBilgi = fiyatListesiDal.MalzemeKoduKontrol(TxtMalzemeKodu.Text);
                try
                {
                    if (!malzemeBilgi.Equals(null))
                    {
                        txtMalzemeAdi.Text = malzemeBilgi.malzeme_adi;
                        txtBirim.Text = malzemeBilgi.birim;
                    }
                }
                catch
                {
                    MessageBox.Show("Girilen Malzeme Kodu Sistemde Tanımlı Değil.");
                    TxtMalzemeKodu.Text = null;
                    txtMalzemeAdi.Text = null;
                    txtBirim.Text = null;
                }
            }
        }

        public void FiyatListesiDoldur()
        {
            FiyatListesiDal fiyatListesiDal = new FiyatListesiDal();

            //---- Insert Alanındaki Fiyat Liste Adını dolduruyorum. ---//
            cmbListeAdi.DataSource = fiyatListesiDal.FListesiDoldur();
            cmbListeAdi.DisplayMember = nameof(FiyatListesi.liste_adi);
            cmbListeAdi.ValueMember = nameof(FiyatListesi.r_sayac);

            //---- Update Alanındaki Fiyat Liste Adını dolduruyorum. ---//
            cmbListeAdiU.DataSource = fiyatListesiDal.FListesiDoldur();
            cmbListeAdiU.DisplayMember = nameof(FiyatListesi.liste_adi);
            cmbListeAdiU.ValueMember = nameof(FiyatListesi.r_sayac);
        }

        public void LoadSettingsByMlzSinifi(string mlzSinifi)
        {

        }

        private void cmbMalzemeSinifi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiyatListesiDal fiyatListesiDal = new FiyatListesiDal();
            var ss = cmbMalzemeSinifi.SelectedValue;

            try
            {
                dgwMalzemeler.DataSource = fiyatListesiDal.DetayListeGetirByMlzSinifi(cmbMalzemeSinifi.SelectedValue.ToString());
            }
            catch
            {

            }

            dgwMalzemeler.Columns[0].Visible = false;
            dgwMalzemeler.Columns[1].Visible = false;
            dgwMalzemeler.Columns[8].Visible = false;
        }

        private void txtMalzemeSearch_TextChanged(object sender, EventArgs e)
        {
            int columnindex = dgwMalzemeler.CurrentCell.ColumnIndex;

            if (!String.IsNullOrEmpty(txtMalzemeSearch.Text))
            {
                if (!String.IsNullOrEmpty(dgwMalzemeler.Columns[dgwMalzemeler.CurrentCell.ColumnIndex].HeaderText.ToString()))
                {
                    Search(dgwMalzemeler.Columns[dgwMalzemeler.CurrentCell.ColumnIndex].HeaderText.ToString());
                }
            }
            else
            {
                FiyatListesiDal fiyatListesiDal = new FiyatListesiDal();
                dgwMalzemeler.DataSource = fiyatListesiDal.DetayListeGetir();
            }

            try
            {
                dgwMalzemeler.CurrentCell = dgwMalzemeler.Rows[0].Cells[columnindex];
            }
            catch
            {
                MessageBox.Show("Tabloda veri yok!");
            }
        }

        public void Search(string columnName)
        {
            FiyatListesiDal fiyatListesiDal = new FiyatListesiDal();
            if (columnName == "liste_adi")
            {
                dgwMalzemeler.DataSource = fiyatListesiDal.DetayListeGetir().Where(p => p.liste_adi.ToLower().Contains(txtMalzemeSearch.Text.ToLower())).ToList();
            }
            else if (columnName == "malzeme_kodu")
            {
                dgwMalzemeler.DataSource = fiyatListesiDal.DetayListeGetir().Where(p => p.malzeme_kodu.ToLower().Contains(txtMalzemeSearch.Text.ToLower())).ToList();
            }
            else if (columnName == "malzeme_adi")
            {
                dgwMalzemeler.DataSource = fiyatListesiDal.DetayListeGetir().Where(p => p.malzeme_adi.ToLower().Contains(txtMalzemeSearch.Text.ToLower())).ToList();
            }
            else if (columnName == "birim")
            {
                dgwMalzemeler.DataSource = fiyatListesiDal.DetayListeGetir().Where(p => p.birim.ToLower().Contains(txtMalzemeSearch.Text.ToLower())).ToList();
            }
            else if (columnName == "indirim01_flag")
            {
                dgwMalzemeler.DataSource = fiyatListesiDal.DetayListeGetir().Where(p => p.indirim01_flag == Convert.ToInt32(txtMalzemeSearch.Text)).ToList();
            }
            else if (columnName == "indirim01")
            {
                dgwMalzemeler.DataSource = fiyatListesiDal.DetayListeGetir().Where(p => p.indirim01 == Convert.ToInt32(txtMalzemeSearch.Text)).ToList();
            }
        }

        public bool KayitKontrol()
        {
            if (String.IsNullOrEmpty(TxtMalzemeKodu.Text))
            {
                MessageBox.Show("Malzeme Kodu Boş geçilemez!");
                TxtMalzemeKodu.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtIndirim.Text))
            {
                MessageBox.Show("İndirim Tutarı Boş geçilemez!");
                txtIndirim.Focus();
                return false;
            }
            return true;
        }
    }
}
