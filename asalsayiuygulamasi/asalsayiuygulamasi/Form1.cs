using System;
using System.Windows.Forms;

namespace asalsayiuygulamasi
{
    public partial class Form1 : Form
    {

        private int _countdownTimer = 60;
        private List<int> _primeNumbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
            lblSayac.Text = _countdownTimer.ToString();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _countdownTimer--;
            lblSayac.Text = _countdownTimer.ToString();
            if (_countdownTimer == 0)
            {

                MessageBox.Show("Süre doldu! Oyunu kaybettiniz.");
                
                btnEnter.Enabled = false;
                tbTahmin.Enabled = false;
                lbAsal.Enabled = false;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input = tbTahmin.Text;
            if (input.Length >= 2)
            {
                string lastTwoDigits = input.Substring(input.Length - 2, 2);

                if (IsValidPrimeNumber(lastTwoDigits))
                {

                    lbAsal.Items.Add(lastTwoDigits); 
                    _primeNumbers.Add(int.Parse(lastTwoDigits)); 
                    if (_primeNumbers.Count == 5)
                    {

                        MessageBox.Show("Tebrikler! Oyunu kazandýnýz.");
                        this.Enabled = false;
                    }
                }
                else
                {

                    MessageBox.Show("Girdiðiniz sayý asal deðildir.");
                    tbTahmin.Text = tbTahmin.Text.Substring(0, tbTahmin.Text.Length - 2);

                }
            }
            else
            {

                MessageBox.Show("Lütfen iki basamaklý bir sayý giriniz.");
                tbTahmin.Text = "";
            }
        }

        private bool IsValidPrimeNumber(string input)
        {
            int number = int.Parse(input);
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

    }
}