using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kafeSiparisUygulaması
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        Form1 frm1 = new Form1();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(frm1.connstring);
            baglanti.Open();
            string getir = "select * from kullanici where k_ad = @kad AND sifre = @sfr";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            komut.Parameters.AddWithValue("@kad",textBox1.Text);
            komut.Parameters.AddWithValue("@sfr",textBox2.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                i++;
                MessageBox.Show("Giriş Başarılı");
                panel1.Visible = false;
                lblMasasayi.Text = "Masa Sayısı Değiştir(" + dr["masasayisi"].ToString() + ")";
                panel2.Visible = true;
            }
            if (i==0)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            baglanti.Close();  
        }
        private void BtnMasa_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(frm1.connstring);
            baglanti.Open();
            string guncelle = "update kullanici set masasayisi = @numara where k_ad = '"+textBox1.Text+"'";
            OleDbCommand komut = new OleDbCommand(guncelle, baglanti);
            komut.Parameters.AddWithValue("@numara", Convert.ToInt32(textBox3.Text));
            if (komut.ExecuteNonQuery() >= 1)
             {
                MessageBox.Show("Masa Sayısı Değişti");
                lblMasasayi.Text = "Masa Sayısı Değiştir(" + textBox3.Text + ")";
            }
            baglanti.Close();
        }
        private void BtnBilgi_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(frm1.connstring);
            baglanti.Open();
            string guncelle = "update kullanici set k_ad = @kad , sifre = @sfr where k_ad = '"+textBox1.Text+"'";
            OleDbCommand komut = new OleDbCommand(guncelle, baglanti);
            komut.Parameters.AddWithValue("@kad", textBox4.Text);
            komut.Parameters.AddWithValue("@sfr", textBox5.Text);
            if (komut.ExecuteNonQuery() >=1)
            {
                MessageBox.Show("Bilgiler Değişti");
                panel1.Visible = true;
                panel2.Visible = false;
            }
            
            baglanti.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
