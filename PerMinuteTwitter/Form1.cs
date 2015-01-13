using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerMinuteTwitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TwitterClass.SetTwitterAuth();
            mainTimer.Interval = Properties.Settings.Default.PopupFrequency;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exitAppItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            ShowATweet();
        }

        private void appNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            ShowATweet();
        }

        private int ConvertTime()
        {
            string durationLength = Properties.Settings.Default.BalloonDuration;
            if (durationLength == "Long")
                return 10;
            else
                return 2;
        }

        private void optionsItem_Click(object sender, EventArgs e)
        {
            OptionsForm opsForm = new OptionsForm();
            opsForm.Show();
        }

        private void showATweetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowATweet();
        }

        private void ShowATweet()
        {
            string[] tweetHolder = new string[2];
            tweetHolder = TwitterClass.SearchForTweet(Properties.Settings.Default.SearchTerm);
            appNotifyIcon.BalloonTipTitle = "Tweet By: " + tweetHolder[0];
            appNotifyIcon.BalloonTipText = tweetHolder[1];
            appNotifyIcon.ShowBalloonTip(ConvertTime());
            mainTimer.Interval = Properties.Settings.Default.PopupFrequency;
        }
    }
}
