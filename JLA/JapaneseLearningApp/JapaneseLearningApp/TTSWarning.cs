using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseLearningApp
{
    public partial class TTSWarning : Form
    {
        public TTSWarning()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxDoNotShow_Click(object sender, EventArgs e)
        {
            if (checkBoxDoNotShow.Checked)
            {
                SettingsDialog.doNotShow = true;
            }
            else
                SettingsDialog.doNotShow = false;
        }
    }
}
