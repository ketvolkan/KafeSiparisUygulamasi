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
    public partial class masadurum : Form
    {
        public int numara;
        Form1 frm1 = new Form1();
        double toplamtutar = 0;
        string fatura;
        public masadurum(int masa)
        {
            numara = masa;   
            InitializeComponent();
        }
        private void Masadurum_Load(object sender, EventArgs e)
        {
            comboboxagetir();
            listboxagetir();
            lblMasa.Text = "Masa Numarası : " + numara.ToString(); 
        }
        void comboboxagetir()
        {
            OleDbConnection baglanti = new OleDbConnection(frm1.connstring);
            baglanti.Open();
            string getir = "select * from kategoriler";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["kategori_isim"]);
            }
            baglanti.Close();
        }
       void listboxagetir()
        {
            OleDbConnection baglanti = new OleDbConnection(frm1.connstring);
            baglanti.Open();
            string getir = "select * from siparisler where masaNumara = @masaNumara";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            komut.Parameters.AddWithValue("@masaNumara", numara);
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read()) 
            {
                listBox1.Items.Add(reader["siparis"]);
                toplamtutar += Convert.ToInt32(reader["fiyat"]);
                lblTutar.Text = "Toplam Tutar : "+toplamtutar.ToString();
            }
            baglanti.Close();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(frm1.connstring);
            baglanti.Open();
            string getir = "select * from urunler where tur = @tur";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            komut.Parameters.AddWithValue("@tur", comboBox1.Text);
            OleDbDataReader reader = komut.ExecuteReader();
            OleDbConnection baglanti2 = new OleDbConnection(frm1.connstring);
            baglanti2.Open();
            string count = "SELECT count(*) as RowCount FROM urunler where tur = @tur2";
            OleDbCommand komut2 = new OleDbCommand(count, baglanti2);
            komut2.Parameters.AddWithValue("@tur2", comboBox1.Text);
            int cnt = Convert.ToInt32(komut2.ExecuteScalar());
            baglanti2.Close();
            //MessageBox.Show(sayac.ToString());
            groupBox1.Controls.Clear();
            groupBox1.Text = comboBox1.Text;
            int boyutW = groupBox1.Width - 20;
            int boyutH = groupBox1.Height / cnt -10 ;
            int i = 0;
            while (reader.Read())
            {
                i++;
                Button siparis = new Button();
                siparis.Width = boyutW;
                siparis.Height = boyutH;
                siparis.BackColor = Color.White;
                siparis.Text = (reader["isim"].ToString());
                siparis.Font = new Font("Tahoma", 15.25F, FontStyle.Bold);
                siparis.TextAlign = ContentAlignment.MiddleCenter;
                siparis.Name = "siparis" + i.ToString();
                siparis.BackgroundImageLayout = ImageLayout.Stretch;
                siparis.Location = new Point(0, ((boyutH) * (i-1) + 40));
                siparis.Click += siparis_Click;
                groupBox1.Controls.Add(siparis);
            }
            baglanti.Close();
        }
        private void siparis_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            listBox1.Items.Add(btn.Text);
            toplamtutar += dizideElemanFiyatiBulma(btn.Text);
            lblTutar.Text = "Toplam Tutar : " + toplamtutar.ToString();
        }
        private double dizideElemanFiyatiBulma(string aranan)
        {
            //Dizide istediğim elemanın fiyatını bulmak için yazdığım method
            double bulunan = 0;
            OleDbConnection baglanti = new OleDbConnection(frm1.connstring);
            baglanti.Open();
            string getir = "select * from urunler where isim = @isim";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            komut.Parameters.AddWithValue("@isim", aranan);
            OleDbDataReader reader = komut.ExecuteReader();
            while(reader.Read())
            { 
                bulunan = Convert.ToInt16(reader["fiyat"]);
            }
            baglanti.Close();
            return bulunan;
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listboxta ürün çıkartma
            if (listBox1.SelectedIndex != 0)
            {
                toplamtutar -= dizideElemanFiyatiBulma(listBox1.GetItemText(listBox1.SelectedItem));
                listBox1.Items.Remove(listBox1.SelectedItem);
                lblTutar.Text = "Fiyat : " + toplamtutar.ToString();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            siparisiOnayla();
        }
        void siparisiOnayla()
        {
            OleDbConnection baglanti2 = new OleDbConnection(frm1.connstring);
            baglanti2.Open();
            string sil = "delete * from siparisler where masaNumara =@masaNumara";
            OleDbCommand komut2 = new OleDbCommand(sil, baglanti2);
            komut2.Parameters.AddWithValue("@masaNumara", numara);
            komut2.ExecuteReader();
            baglanti2.Close();
            foreach (string item in listBox1.Items)
            {
                if (item != "Seçilen Ürünler")
                {  
                    string urun = item;
                    int masa = numara;
                    double fiyat = dizideElemanFiyatiBulma(item);
                    OleDbConnection baglanti = new OleDbConnection(frm1.connstring);
                    baglanti.Open();
                    string ekle = "insert into siparisler(masaNumara,siparis,fiyat) values(@masaNumara,@siparis,@fiyat) ";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@masaNumara", masa);
                    komut.Parameters.AddWithValue("@siparis", urun);
                    komut.Parameters.AddWithValue("@fiyat", fiyat);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            
            foreach (var item in listBox1.Items)
            {
                if (listBox1.GetItemText(item) != "Seçilen Ürünler")
                {
                    fatura += listBox1.GetItemText(item) + "    Fiyat : " + dizideElemanFiyatiBulma(listBox1.GetItemText(item)).ToString() + "\n";
                }
            }
            OleDbConnection baglanti = new OleDbConnection(frm1.connstring);
            baglanti.Open();
            string sil = "delete * from siparisler where masaNumara = " + numara.ToString();
            OleDbCommand komut = new OleDbCommand(sil, baglanti);
            komut.ExecuteReader();
            baglanti.Close();
            listBox1.Items.Clear();
            MessageBox.Show(fatura+"\n Toplam Tutar : "+toplamtutar.ToString());
            
        }
    }
}
