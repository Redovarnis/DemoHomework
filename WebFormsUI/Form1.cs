using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.NHibernate;
using Entities.Concrete;

namespace WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _kitapService = new KitapManager(new NhProductDal());
            _uyeService = new UyeManager(new NhUyeDal());
        }

        private IKitapService _kitapService;
        private IUyeService _uyeService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKitap();
            LoadUye();
        }

        private void LoadKitap()
        {
            dgwKitap.DataSource = _kitapService.GetAll();
        }

        private void LoadUye()
        {
            cbxUye.DataSource = _uyeService.GetAll();
            cbxUye.DisplayMember = "Ad";
            cbxUye.ValueMember = "ID";



            cbxTurGüncelle.DataSource = _uyeService.GetAll();
            cbxTurGüncelle.DisplayMember = "Ad";
            cbxTurGüncelle.ValueMember = "ID";

            cbxTurSil.DataSource = _uyeService.GetAll();
            cbxTurSil.DisplayMember = "Ad";
            cbxTurSil.ValueMember = "ID";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwKitap.DataSource = _kitapService.GetKitapByUye(Convert.ToInt32(cbxUye.SelectedValue));
            }
            catch
            {
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxKitap.Text))
            {
                dgwKitap.DataSource = _kitapService.GetKitapByKitapAdı(tbxKitap.Text);
            }
            else
            {
                LoadKitap();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _kitapService.Add(new Kitap()
            {
                KitapAdi = tbxKitapAdiEkle.Text.ToString(),
                Yazar = tbxYazarEkle.Text.ToString(),
                Tur = tbxTurEkle.Text.ToString(),
                Sayfa = Convert.ToInt32(tbxSayfaEkle.Text),
                Uygunluk = Convert.ToBoolean(tbxUygunlukEkle.Text)
            });
            MessageBox.Show("Saved successfully!");
            LoadKitap();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _kitapService.Update(new Kitap()
            {
                ID = Convert.ToInt32(cbxTurGüncelle.SelectedValue),
                KitapAdi = tbxKitapAdiGüncelle.Text,
                Yazar = tbxSayfaGüncelle.Text,
                Tur = tbxUygunlukGüncelle.Text.ToString(),
                Sayfa = Convert.ToInt32(tbxYazarGüncelle.Text),
                Uygunluk = Convert.ToBoolean(tbxUygunlukGüncelle.Text)
            });
            MessageBox.Show("Successfully updated!");
            LoadKitap();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKitapAdiGüncelle.Text = dgwKitap.CurrentRow.Cells[1].Value.ToString();
            cbxTurGüncelle.SelectedValue = dgwKitap.CurrentRow.Cells[2].Value;
            tbxUygunlukGüncelle.Text = dgwKitap.CurrentRow.Cells[3].Value.ToString();
            tbxSayfaGüncelle.Text = dgwKitap.CurrentRow.Cells[4].Value.ToString();
            tbxYazarGüncelle.Text = dgwKitap.CurrentRow.Cells[5].Value.ToString();

            tbxKitapAdiSil.Text = dgwKitap.CurrentRow.Cells[1].Value.ToString();
            cbxTurSil.SelectedValue = dgwKitap.CurrentRow.Cells[2].Value;
            tbxUygunlukSil.Text = dgwKitap.CurrentRow.Cells[3].Value.ToString();
            tbxSayfaSil.Text = dgwKitap.CurrentRow.Cells[4].Value.ToString();
            tbxYazarSil.Text = dgwKitap.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _kitapService.Delete(new Kitap()
            {
                ID = Convert.ToInt32(cbxTurSil.SelectedValue),
                KitapAdi = tbxKitapAdiSil.Text,
                Yazar = tbxSayfaSil.Text,
                Tur = tbxUygunlukSil.Text,
                Sayfa = Convert.ToInt32(tbxYazarSil.Text),
                Uygunluk = Convert.ToBoolean(tbxYazarSil.Text)
            });

            MessageBox.Show("Successfully Deleted!");
            LoadKitap();
        }
    }
}
