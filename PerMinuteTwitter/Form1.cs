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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            textBox1.Text = "";
            
        }

        private void exitAppItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void appNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            string[] tweetHolder = new string[2];
            tweetHolder = TwitterClass.SearchForTweet("gamedev");
            appNotifyIcon.BalloonTipTitle = "Tweet By: " + tweetHolder[0];
            appNotifyIcon.BalloonTipText = tweetHolder[1];
            appNotifyIcon.ShowBalloonTip();
        }

        private int ConvertTime()
        {
            
        }

    }
}
