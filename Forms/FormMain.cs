using System.Windows.Forms;

namespace MBlog.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var settings = new FormProjectSettings();
            settings.ShowDialog();
        }
    }
}
