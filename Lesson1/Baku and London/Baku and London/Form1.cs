using Timer = System.Windows.Forms.Timer;

namespace Baku_and_London
{
    public partial class Form1 : Form
    {
        Timer timerL = new();
        Timer timerB = new();
        public Form1()
        {
            InitializeComponent();

            timerB.Interval = 1000;
            timerB.Tick += Timer_Baku;
            timerB.Start();
        }
        private void Timer_Baku(object? sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }
        private void Timer_London(object? sender, EventArgs e)
        {

            Text = DateTime.Now.AddHours(-4).ToLongTimeString();
        }

        private void baku_Click(object sender, EventArgs e)
        {
            timerL.Stop();
            timerB.Interval = 1000;
            timerB.Tick += Timer_Baku;
            timerB.Start();
            BackgroundImage = Properties.Resources.Baku;

            var randY = new Random();
            var randX = new Random();
            button1.Location = new Point(randX.Next(0, 713), randY.Next(0, 415));
        }

        private void london_Click(object sender, EventArgs e)
        {
            
            timerB.Stop();
            timerL.Interval = 1000;
            timerL.Tick += Timer_London;
            timerL.Start();
            BackgroundImage = Properties.Resources.London;

            var randY = new Random();
            var randX = new Random();
            button2.Location = new Point(randX.Next(0, 713), randY.Next(0, 415));
        }
    }
}