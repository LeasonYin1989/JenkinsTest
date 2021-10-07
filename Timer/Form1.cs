using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Threading.Timer timer1;
        long timeCount;
        delegate void SetValue();

        bool goon = true;

        private void begin_Click(object sender, EventArgs e)
        {
            timeCount = 0;
            timer1.Change(0, 1000);
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (goon)
            {
                timer1.Change(Timeout.Infinite, 1000);
                goon = false;
            }
            else
            {
                timer1.Change(0, 1000);
                goon = true;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.timeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1 = new System.Threading.Timer(new System.Threading.TimerCallback(TimeUp), null, Timeout.Infinite, 1000);
        }
        private void TimeUp(object state)
        {
            this.Invoke(new SetValue(ShowTime));
            timeCount++;
        }
        public void ShowTime()
        {
            TimeSpan t = new TimeSpan(0, 0, (int)timeCount);
            this.timeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", t.Hours, t.Minutes, t.Seconds);

        }
    }
}
