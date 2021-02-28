using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveBgTool
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Api.Length > 0)
            {
                textBox1.Text = Properties.Settings.Default.Api;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter an api key", "Settings");
            }
            RemoveBgTool.Properties.Settings.Default.Api = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
