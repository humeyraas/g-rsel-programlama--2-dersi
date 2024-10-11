namespace keydownolaylari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyValue.ToString());
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyData.ToString());
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Conrtol tusuna bastýnn");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.B)
            {

                this.Close();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

                e.Handled = false;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else { 
              e.Handled = false;
            }
        }
    }
}
