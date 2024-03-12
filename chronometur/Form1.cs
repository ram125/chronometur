using System.Diagnostics;

namespace chronometur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int seconds;
        private bool timeon;
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private int ConvertToMinutes(int seconds)
        {
            return seconds / 60;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seconds = 0;
            while (true)
            {
                seconds++;
                label1.Text = ConvertToMinutes(seconds).ToString();
            }
        }
    }
}