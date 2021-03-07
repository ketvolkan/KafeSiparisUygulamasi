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
    public partial class Form1 : Form
    {
        public string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Volkan\source\repos\kafeSiparisUygulaması\kafeSiparisUygulaması\bin\Debug\kafeDb.accdb";
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int masanumara;
        int masasayisi;   
        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(connstring);
            baglanti.Open();
            string getir = "select * from kullanici";
            OleDbCommand komut = new OleDbCommand(getir, baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            { 
                masalariGetir(Convert.ToInt32(dr["masasayisi"]));
                masasayisi = Convert.ToInt32(dr["masasayisi"]);  

            }
            baglanti.Close();   
        }
        public int sayacarttir()
        {
            sayac++;
            return sayac-1;
        }
        
        void masalariGetir(int masaSayisi)
        {
            int boyutW = groupBox1.Width / 10-25;
            int boyutH = groupBox1.Height / 5-25;
            int i = 0;
            for (int h = 0; h < masaSayisi; h++)
            {
                    int j = h/10;
                    int sayi= (j * 10) + (i + 1);
                    Button masa = new Button();
                    masa.Width = boyutW;
                    masa.Height = boyutH;
                    masa.Image = Image.FromFile("masa.png");
                    masa.Text = (sayi.ToString());
                    masa.Font = new Font("Tahoma", 15.25F, FontStyle.Bold);
                    masa.TextAlign = ContentAlignment.MiddleCenter;
                    masa.Name = "masa" + sayi.ToString();
                    masa.BackgroundImageLayout = ImageLayout.Stretch;
                    masa.Location = new Point((i * (boyutW + 25) + 5), ((boyutH + 25) * j + 40));      
                    masa.Click += Masa_Click;
                    masa.Tag = sayi.ToString();
                    groupBox1.Controls.Add(masa);
                    i++;
                    if (i==10)
                    {
                         i = 0;
                    }            
            }    
        }
        private void Masa_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masadurum frm = new masadurum(Convert.ToInt32(btn.Name.Substring(4, btn.Name.Length - 4)));
            masanumara = Convert.ToInt32(btn.Name.Substring(4, btn.Name.Length - 4));
            frm.ShowDialog();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(connstring);
            baglanti.Open();
            string sil = "delete * from siparisler";
            OleDbCommand komut = new OleDbCommand(sil, baglanti);
            komut.ExecuteReader();
            baglanti.Close();
            Application.Exit();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(this.Width-40,this.Height-60);
        }
    }
}
