namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Urun> urunListesi = new List<Urun>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstListe.Items.Clear();
            foreach (var urun in urunListesi)
            {
                double toplamFiyat = urun.UrunAdedi * urun.BirimFiyati;
                lstListe.Items.Add($"{urun.UrunAdi} / {urun.UrunAdedi} - �r�n�n %20 KDV'li Fiyat�: {toplamFiyat * 1.2}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Urun[] urunDizisi = urunListesi.ToArray();
            MessageBox.Show($"Diziye aktar�ld�. Dizi Eleman Say�s�: {urunDizisi.Length}");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text;
            int urunAdedi = int.Parse(txtUrunAdedi.Text);
            double birimFiyati = double.Parse(txtBirimFiyati.Text);

            Urun yeniUrun = new Urun()
            {
                UrunAdi = urunAdi,
                UrunAdedi = urunAdedi,
                BirimFiyati = birimFiyati
            };

            urunListesi.Add(yeniUrun);
            MessageBox.Show("�r�n ba�ar�yla kaydedildi.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Urun[] urunDizisi = urunListesi.ToArray();
            MessageBox.Show($"Dizi Eleman Say�s�: {urunDizisi.Length}");
        }
    }
    public class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunAdedi { get; set; }
        public double BirimFiyati { get; set; }
    }
}
