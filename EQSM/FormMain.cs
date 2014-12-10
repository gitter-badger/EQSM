using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Text;
using System.Windows.Forms;
using Yourfirefly.EQSM.Properties;

namespace Yourfirefly.EQSM
{
    public partial class FormMain : Form
    {
        public static SettingsLoader settings;
        public Font hotButtonFont;
        public int page = 1;
        
        private FormAbout _formAbout;
        
        public string TextEQLocation
        {
            get { return textEQLocation.Text; }
            set { textEQLocation.Text = value; }
        }

        public FormMain()
        {
            // Initialize UI components
            InitializeComponent();

            // Initialize font object
            hotButtonFont = new Font("Arial", 7);

            // Initialize Settings and set this form as the parent for references
            settings = new SettingsLoader { Parent = this };
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // Display the About form
            _formAbout = new FormAbout();
            _formAbout.ShowDialog(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Load drive info and scan known directories for EverQuest INI files
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo d in drives)
                foreach (string l in settings.EQLocations)
                    if (Directory.Exists(d + l))
                        settings.EQLocation = d + l;
            
            // Load all found character INIs
            foreach (Character c in settings.Characters)
                listCharacters.Items.Add(c.Name + " (" + c.Server + ")");
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            // Display folder browser dialog so user can select EverQuest directory
            FolderBrowserDialog browser = new FolderBrowserDialog();

            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
                settings.EQLocation = browser.SelectedPath;
        }

        private void loadHotButtons(Character character)
        {
            if (character == null) throw new ArgumentNullException("character");

            groupHotButtons.Controls.Clear();

            picLeftArrow.Image = Resources.arrow_left;
            groupHotButtons.Controls.Add(picLeftArrow);
            picRightArrow.Image = Resources.arrow_right;
            groupHotButtons.Controls.Add(picRightArrow);

            Label labelPage = new Label();
            labelPage.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelPage.Name = "labelPage";
            labelPage.TextAlign = ContentAlignment.MiddleCenter;
            labelPage.Text = page.ToString();
            labelPage.Location = new Point(30, 17);
            labelPage.Size = new Size(48, 14);
            groupHotButtons.Controls.Add(labelPage);
            
            for (int i = 0; i < 10; i++)
            {
                PictureBox picBox = new PictureBox
                {
                    Location = new Point(54 - (((i + 1) % 2) * 48), 34 + ((i / 2) * 48)),
                    Height = 48,
                    Width = 48,
                    Name = "button" + i,
                };

                Bitmap button = new Bitmap(Resources.hotbutton);
                Bitmap background = new Bitmap(Resources.hotbutton_empty);
                Bitmap finalButton = new Bitmap(48, 48);

                using (Graphics graphics = Graphics.FromImage(finalButton))
                {
                    graphics.Clear(Color.Transparent);
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;

                    graphics.DrawImage(background, 0, 0);

                    if (character.HotButtons.HotButtonPages[page - 1].Buttons(i).Value != "")
                        graphics.DrawImage(button, 4, 4);

                    StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
                    SizeF textSize = graphics.MeasureString(character.HotButtons.HotButtonPages[page - 1].Buttons(i).Value, hotButtonFont, 36, stringFormat);
                    PointF textLocation = new PointF { X = 24 - (textSize.Width / 2), Y = 24 - (textSize.Height / 2) };
                    graphics.DrawString(character.HotButtons.HotButtonPages[page - 1].Buttons(i).Value, hotButtonFont, Brushes.White, textLocation);
                }

                picBox.Image = finalButton;
                groupHotButtons.Controls.Add(picBox);
            }
            groupHotButtons.Show();
        }

        private void listCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            page = 1;
            loadHotButtons(settings.Characters[listCharacters.SelectedIndex]);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotButtonFont.Dispose();
        }

        private void picLeftArrow_Click(object sender, EventArgs e)
        {
            if (page - 1 >= 1)
                page--;
            else
                page = 10;

            loadHotButtons(settings.Characters[listCharacters.SelectedIndex]);
        }

        private void picRightArrow_Click(object sender, EventArgs e)
        {
            if (page + 1 <= 10)
                page++;
            else
                page = 1;

            loadHotButtons(settings.Characters[listCharacters.SelectedIndex]);
        }
    }
}
