using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerMinuteTwitter
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void SaveSettings()
        {
            if (shortDuration.Checked)
                Properties.Settings.Default.BalloonDuration = "Short";
            else if (longDuration.Checked)
                Properties.Settings.Default.BalloonDuration = "Long";

            Properties.Settings.Default.SearchTerm = searchTerm.Text;

            Properties.Settings.Default.PopupFrequency = (int) frequencyUpDown.Value*(60*1000);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            tokenStatus.Text = TwitterClass.GetTokensLeft();
            frequencyUpDown.Value = (Properties.Settings.Default.PopupFrequency/1000)/60;
        }
    }
}
