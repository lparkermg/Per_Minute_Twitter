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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TwitterClass.SetTwitterAuth();
            textBox1.Text = TwitterClass.SearchForTweet("gamedev");

        }

        private void exitAppItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
