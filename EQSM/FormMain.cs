using System;
using System.IO;
using System.Windows.Forms;

namespace Yourfirefly.EQSM
{
    public partial class FormMain : Form
    {
        public static SettingsLoader Settings;
        private FormAbout _formAbout;

        public string TextEQLocation
        {
            get { return textEQLocation.Text; }
            set { textEQLocation.Text = value; }
        }

        public FormMain()
        {
            InitializeComponent();

            Settings = new SettingsLoader { Parent = this };
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
                foreach (string l in Settings.EQLocations)
                    if (Directory.Exists(d + l))
                        Settings.EQLocation = d + l;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
                Settings.EQLocation = browser.SelectedPath;
        }
    }
}
