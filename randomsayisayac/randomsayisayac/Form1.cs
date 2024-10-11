using System;
using System.Windows.Forms;


namespace randomsayisayac

{
    public partial class Form1 : Form
    {

        private int sayi1;
        private int sayi2;
        private int skor;
        private int sonuc;

        private int sayi3;
        private int sayi4;
        private int sonuc2;
        private int skor1;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Timer _timercarpma;

        private DateTime baslangic;
        private DateTime baslangiccarpma;


        public Form1()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;

            _timercarpma = new System.Windows.Forms.Timer();
            _timercarpma.Interval = 1000;
            _timercarpma.Tick += Timer_Tick_Carpma;
            baslangiccarpma = DateTime.Now.AddMinutes(5);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateNumbers();
            baslangic = DateTime.Now;
            _timer.Start();

        }
        private void GenerateNumbers()
        {
            sayi1 = new Random().Next(1, 100);
            sayi2 = new Random().Next(1, 100);
            sonuc = sayi1 + sayi2;
            lblSayi1.Text = $"1. Sayý: {sayi1}";
            lblSayi2.Text = $"2. Sayý: {sayi2}";

        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int tahmin = int.Parse(tbTahmin.Text);
            if (tahmin == sonuc)
            {
                _timer.Stop();
                skor = (int)(DateTime.Now - baslangic).TotalSeconds;
                lblSkor.Text = $" Tebrikler  {skor} saniyede tamamladýn";
                CarpmaProblemiUret();
                _timercarpma.Start();

            }
            else
            {
                MessageBox.Show("Tekrar dene.");
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timespan = DateTime.Now - baslangic;
            lblTimer.Text = $"{timespan.Hours:00}:{timespan.Minutes:00}:{timespan.Seconds:00}";




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CarpmaProblemiUret()
        {
            int sayi3 = new Random().Next(1, 10);
            int sayi4 = new Random().Next(1, 10);
            sonuc2 = sayi3 * sayi4;
            lblSayi3.Text = $"3.Sayi: {sayi3}";
            lblSayi4.Text = $"4.sayi: {sayi4}";

        }
        private void Timer_Tick_Carpma(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - baslangiccarpma;
            lblTimer2.Text = $"{timeSpan.Hours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = int.Parse(tbTahmin2.Text);
            if (tahmin == sonuc2)
            {
                _timercarpma.Stop();
                skor1 = (int)(DateTime.Now - baslangic).TotalSeconds;
                lblSkor2.Text = $" Tebrikler  {skor1} saniyede tamamladýn";
                lblToplam.Text = $" Tebrikler toplam {skor + skor1} saniyede tamamladýn ";
              

            }
            else
            {
                MessageBox.Show("Tekrar dene.");
            }
        }
    }
}