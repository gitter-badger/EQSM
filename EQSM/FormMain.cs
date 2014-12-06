using System;
using System.IO;
using System.Windows.Forms;

namespace Yourfirefly.EQSM
{
    public partial class FormMain : Form
    {
        private FormAbout _formAbout;
        private SettingsLoader settings;

        public string TextEQLocation
        {
            get { return textEQLocation.Text; }
            set { textEQLocation.Text = value; }
        }

        public FormMain()
        {
            InitializeComponent();

            settings = new SettingsLoader();
            settings.Parent = this;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            _formAbout = new FormAbout();
            _formAbout.ShowDialog(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo d in drives)
                foreach (string l in settings.EQLocations)
                    if (Directory.Exists(d + l))
                        settings.EQLocation = d + l;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
                settings.EQLocation = browser.SelectedPath;
        }
    }
}
