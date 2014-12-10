namespace Yourfirefly.EQSM
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabPage();
            this.groupHotButtons = new System.Windows.Forms.GroupBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.picRightArrow = new System.Windows.Forms.PictureBox();
            this.picLeftArrow = new System.Windows.Forms.PictureBox();
            this.groupCharacters = new System.Windows.Forms.GroupBox();
            this.listCharacters = new System.Windows.Forms.ListBox();
            this.tabTools = new System.Windows.Forms.TabControl();
            this.tabCharacters = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelEQDir = new System.Windows.Forms.Label();
            this.textEQLocation = new System.Windows.Forms.TextBox();
            this.tabMain.SuspendLayout();
            this.groupHotButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftArrow)).BeginInit();
            this.groupCharacters.SuspendLayout();
            this.tabTools.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.groupHotButtons);
            this.tabMain.Controls.Add(this.groupCharacters);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(752, 484);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // groupHotButtons
            // 
            this.groupHotButtons.Controls.Add(this.labelPage);
            this.groupHotButtons.Controls.Add(this.picRightArrow);
            this.groupHotButtons.Controls.Add(this.picLeftArrow);
            this.groupHotButtons.Location = new System.Drawing.Point(212, 6);
            this.groupHotButtons.Name = "groupHotButtons";
            this.groupHotButtons.Size = new System.Drawing.Size(108, 280);
            this.groupHotButtons.TabIndex = 3;
            this.groupHotButtons.TabStop = false;
            this.groupHotButtons.Text = "Hot Buttons";
            this.groupHotButtons.Visible = false;
            // 
            // labelPage
            // 
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.Location = new System.Drawing.Point(32, 19);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(44, 12);
            this.labelPage.TabIndex = 2;
            this.labelPage.Text = "Page #";
            this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picRightArrow
            // 
            this.picRightArrow.Location = new System.Drawing.Point(82, 19);
            this.picRightArrow.Name = "picRightArrow";
            this.picRightArrow.Size = new System.Drawing.Size(20, 12);
            this.picRightArrow.TabIndex = 1;
            this.picRightArrow.TabStop = false;
            this.picRightArrow.Click += new System.EventHandler(this.picRightArrow_Click);
            // 
            // picLeftArrow
            // 
            this.picLeftArrow.Location = new System.Drawing.Point(6, 19);
            this.picLeftArrow.Name = "picLeftArrow";
            this.picLeftArrow.Size = new System.Drawing.Size(20, 12);
            this.picLeftArrow.TabIndex = 0;
            this.picLeftArrow.TabStop = false;
            this.picLeftArrow.Click += new System.EventHandler(this.picLeftArrow_Click);
            // 
            // groupCharacters
            // 
            this.groupCharacters.Controls.Add(this.listCharacters);
            this.groupCharacters.Location = new System.Drawing.Point(6, 6);
            this.groupCharacters.Name = "groupCharacters";
            this.groupCharacters.Size = new System.Drawing.Size(200, 472);
            this.groupCharacters.TabIndex = 2;
            this.groupCharacters.TabStop = false;
            this.groupCharacters.Text = "Characters";
            // 
            // listCharacters
            // 
            this.listCharacters.FormattingEnabled = true;
            this.listCharacters.Location = new System.Drawing.Point(6, 19);
            this.listCharacters.Name = "listCharacters";
            this.listCharacters.Size = new System.Drawing.Size(188, 446);
            this.listCharacters.TabIndex = 1;
            this.listCharacters.SelectedIndexChanged += new System.EventHandler(this.listCharacters_SelectedIndexChanged);
            // 
            // tabTools
            // 
            this.tabTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTools.Controls.Add(this.tabMain);
            this.tabTools.Controls.Add(this.tabCharacters);
            this.tabTools.Controls.Add(this.tabSettings);
            this.tabTools.Location = new System.Drawing.Point(12, 39);
            this.tabTools.Name = "tabTools";
            this.tabTools.SelectedIndex = 0;
            this.tabTools.Size = new System.Drawing.Size(760, 510);
            this.tabTools.TabIndex = 1;
            // 
            // tabCharacters
            // 
            this.tabCharacters.Location = new System.Drawing.Point(4, 22);
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacters.Size = new System.Drawing.Size(752, 484);
            this.tabCharacters.TabIndex = 2;
            this.tabCharacters.Text = "Characters";
            this.tabCharacters.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.buttonBrowse);
            this.tabSettings.Controls.Add(this.buttonAbout);
            this.tabSettings.Controls.Add(this.labelEQDir);
            this.tabSettings.Controls.Add(this.textEQLocation);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(752, 484);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(718, 24);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(28, 22);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(646, 456);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(100, 22);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "&About EQSM";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // labelEQDir
            // 
            this.labelEQDir.AutoSize = true;
            this.labelEQDir.Location = new System.Drawing.Point(6, 9);
            this.labelEQDir.Name = "labelEQDir";
            this.labelEQDir.Size = new System.Drawing.Size(105, 13);
            this.labelEQDir.TabIndex = 6;
            this.labelEQDir.Text = "EverQuest Directory:";
            // 
            // textEQLocation
            // 
            this.textEQLocation.Location = new System.Drawing.Point(9, 25);
            this.textEQLocation.Name = "textEQLocation";
            this.textEQLocation.ReadOnly = true;
            this.textEQLocation.Size = new System.Drawing.Size(703, 20);
            this.textEQLocation.TabIndex = 5;
            this.textEQLocation.Text = "<EverQuest Directory>";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EverQuest Settings Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabMain.ResumeLayout(false);
            this.groupHotButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftArrow)).EndInit();
            this.groupCharacters.ResumeLayout(false);
            this.tabTools.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabControl tabTools;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label labelEQDir;
        private System.Windows.Forms.TextBox textEQLocation;
        private System.Windows.Forms.TabPage tabCharacters;
        private System.Windows.Forms.GroupBox groupCharacters;
        private System.Windows.Forms.ListBox listCharacters;
        private System.Windows.Forms.GroupBox groupHotButtons;
        private System.Windows.Forms.PictureBox picRightArrow;
        private System.Windows.Forms.PictureBox picLeftArrow;
        private System.Windows.Forms.Label labelPage;
    }
}

