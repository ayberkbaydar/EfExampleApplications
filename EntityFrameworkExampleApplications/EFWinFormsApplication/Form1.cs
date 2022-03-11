using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFWinFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindDBContext db = new NorthwindDBContext();

        void Statistics()
        {
            //Urun Toplam
            lblUrunAdet.Text = db.Products.Count().ToString();

            //Stokta bulunan ürün toplam
            lblStokUrunAdet.Text = db.Products.Where(x => x.UnitsInStock > 0).Count().ToString();

            //Stoğu tükenen ürünlerin toplamı
            lblStoktaOlmayanUrunAdet.Text = db.Products.Where(x => x.UnitsInStock == 0).Count().ToString();

            //En pahalı ürün fiyatı
            lblEnYuksekUrunFiyat.Text = db.Products.OrderByDescending(x => x.UnitPrice).Select(x => x.UnitPrice).First().Value.ToString();

            //En pahalı ürün adı
            lblYuksekFiyatUrun.Text = db.Products.OrderByDescending(x => x.UnitPrice).Select(x => x.ProductName).First();

            //En ucuz ürünün fiyatı
            lblEnDusukUrunFiyat.Text = db.Products.OrderBy(x => x.UnitPrice).Select(x => x.UnitPrice).First().ToString();

            //En ucuz ürünün adı
            lblDusukFiyatUrun.Text = db.Products.OrderBy(x => x.UnitPrice).Select(x => x.ProductName).First();

            //Çalışan Toplam
            lblToplamCalisan.Text = db.Employees.Count().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Statistics();
        }
    }
}
