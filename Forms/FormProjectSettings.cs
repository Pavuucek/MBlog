using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MBlog.Forms
{
    public partial class FormProjectSettings : Form
    {
        public FormProjectSettings()
        {
            InitializeComponent();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (tabControlSettings.SelectedIndex == tabControlSettings.TabCount - 1)
            {
                tabControlSettings.SelectedIndex = 0;
                return;
            }
            tabControlSettings.SelectedIndex++;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (tabControlSettings.SelectedIndex == 0)
            {
                tabControlSettings.SelectedIndex = tabControlSettings.TabCount - 1;
                return;
            }
            tabControlSettings.SelectedIndex--;
        }
    }
}
