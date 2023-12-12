using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace film_otomasyonu_777
{
    public partial class Form1 : Form
    {
        List<Film> filmler = new List<Film>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string ad = txtAd.Text;
            int sure = Convert.ToInt32(txtSure.Text);
            DateTime tarih = dtTarih.Value;
            string tur = cmbTur.Text;
            int puan = tbBegen.Value;

            Film film = new Film ( id, ad, sure, tarih, tur, puan );

            filmler.Add ( film );

            dataGridView1.Refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Film film = (Film)dataGridView1.SelectedRows[0].DataBoundItem;

                txtId.Text = film.Id.ToString();
                txtAd.Text = film.Ad;
                txtSure.Text = film.sure.ToString();
                dtTarih.Value = film.izlemeTarih;
                cmbTur.Text = film.tur;
                tbBegen.Value = film.begen;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Film film = (Film)dataGridView1.SelectedRows[0].DataBoundItem;

                film.Ad = txtAd.Text;
                film.sure = Convert.ToInt32(txtSure.Text);
                film.tur = cmbTur.Text;
                film.izlemeTarih = dtTarih.Value;
                film.begen = tbBegen.Value;

                dataGridView1.Refresh();

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
