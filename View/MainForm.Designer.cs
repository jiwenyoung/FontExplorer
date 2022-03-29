namespace FontExplorer.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FontContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.DragHerePicture = new System.Windows.Forms.PictureBox();
            this.BarPanel = new System.Windows.Forms.Panel();
            this.NavContainer = new System.Windows.Forms.Panel();
            this.NavBtnBoxMyFav = new System.Windows.Forms.Panel();
            this.NavBtnMyFav = new System.Windows.Forms.Button();
            this.NavBtnColorBlockMyFav = new System.Windows.Forms.Panel();
            this.NavBtnBoxOpenFolder = new System.Windows.Forms.Panel();
            this.NavBtnOpenFolder = new System.Windows.Forms.Button();
            this.NavBtnColorBlockOpenFolder = new System.Windows.Forms.Panel();
            this.LogoContainer = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderTextInputBox = new System.Windows.Forms.TextBox();
            this.HeaderText = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.Panel();
            this.SearchInputUnderline = new System.Windows.Forms.Panel();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.TxtContainer = new System.Windows.Forms.Panel();
            this.SampleExampleBox = new System.Windows.Forms.Panel();
            this.SampleTextInputUnderLine = new System.Windows.Forms.Panel();
            this.SampleExampleInput = new System.Windows.Forms.TextBox();
            this.SampleTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DragHerePicture)).BeginInit();
            this.BarPanel.SuspendLayout();
            this.NavContainer.SuspendLayout();
            this.NavBtnBoxMyFav.SuspendLayout();
            this.NavBtnBoxOpenFolder.SuspendLayout();
            this.LogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.SearchBox.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.TxtContainer.SuspendLayout();
            this.SampleExampleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontContainer
            // 
            this.FontContainer.AllowDrop = true;
            this.FontContainer.AutoScroll = true;
            this.FontContainer.AutoSize = true;
            this.FontContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FontContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.FontContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FontContainer.Location = new System.Drawing.Point(0, 80);
            this.FontContainer.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.FontContainer.Name = "FontContainer";
            this.FontContainer.Size = new System.Drawing.Size(584, 431);
            this.FontContainer.TabIndex = 1;
            this.FontContainer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FontContainer_Scroll);
            this.FontContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.FontContainer_DragDrop);
            this.FontContainer.DragEnter += new System.Windows.Forms.DragEventHandler(this.FontContainer_DragEnter);
            // 
            // DragHerePicture
            // 
            this.DragHerePicture.Location = new System.Drawing.Point(0, 0);
            this.DragHerePicture.Name = "DragHerePicture";
            this.DragHerePicture.Size = new System.Drawing.Size(100, 50);
            this.DragHerePicture.TabIndex = 0;
            this.DragHerePicture.TabStop = false;
            // 
            // BarPanel
            // 
            this.BarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.BarPanel.Controls.Add(this.NavContainer);
            this.BarPanel.Controls.Add(this.LogoContainer);
            this.BarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarPanel.Location = new System.Drawing.Point(0, 0);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.Size = new System.Drawing.Size(200, 561);
            this.BarPanel.TabIndex = 0;
            // 
            // NavContainer
            // 
            this.NavContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.NavContainer.Controls.Add(this.NavBtnBoxMyFav);
            this.NavContainer.Controls.Add(this.NavBtnBoxOpenFolder);
            this.NavContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavContainer.Location = new System.Drawing.Point(0, 100);
            this.NavContainer.Name = "NavContainer";
            this.NavContainer.Size = new System.Drawing.Size(200, 461);
            this.NavContainer.TabIndex = 0;
            // 
            // NavBtnBoxMyFav
            // 
            this.NavBtnBoxMyFav.BackColor = System.Drawing.Color.Transparent;
            this.NavBtnBoxMyFav.Controls.Add(this.NavBtnMyFav);
            this.NavBtnBoxMyFav.Controls.Add(this.NavBtnColorBlockMyFav);
            this.NavBtnBoxMyFav.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NavBtnBoxMyFav.Location = new System.Drawing.Point(0, 50);
            this.NavBtnBoxMyFav.Name = "NavBtnBoxMyFav";
            this.NavBtnBoxMyFav.Size = new System.Drawing.Size(200, 50);
            this.NavBtnBoxMyFav.TabIndex = 1;
            // 
            // NavBtnMyFav
            // 
            this.NavBtnMyFav.BackColor = System.Drawing.Color.Transparent;
            this.NavBtnMyFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NavBtnMyFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavBtnMyFav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavBtnMyFav.FlatAppearance.BorderSize = 0;
            this.NavBtnMyFav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.NavBtnMyFav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.NavBtnMyFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavBtnMyFav.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NavBtnMyFav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NavBtnMyFav.Location = new System.Drawing.Point(0, 0);
            this.NavBtnMyFav.Name = "NavBtnMyFav";
            this.NavBtnMyFav.Size = new System.Drawing.Size(200, 50);
            this.NavBtnMyFav.TabIndex = 1;
            this.NavBtnMyFav.Text = "My Favorites";
            this.NavBtnMyFav.UseVisualStyleBackColor = false;
            this.NavBtnMyFav.Click += new System.EventHandler(this.NavBtnMyFav_ClickAsync);
            // 
            // NavBtnColorBlockMyFav
            // 
            this.NavBtnColorBlockMyFav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.NavBtnColorBlockMyFav.Location = new System.Drawing.Point(0, 0);
            this.NavBtnColorBlockMyFav.Name = "NavBtnColorBlockMyFav";
            this.NavBtnColorBlockMyFav.Size = new System.Drawing.Size(20, 50);
            this.NavBtnColorBlockMyFav.TabIndex = 1;
            // 
            // NavBtnBoxOpenFolder
            // 
            this.NavBtnBoxOpenFolder.BackColor = System.Drawing.Color.Transparent;
            this.NavBtnBoxOpenFolder.Controls.Add(this.NavBtnOpenFolder);
            this.NavBtnBoxOpenFolder.Controls.Add(this.NavBtnColorBlockOpenFolder);
            this.NavBtnBoxOpenFolder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NavBtnBoxOpenFolder.Location = new System.Drawing.Point(0, 0);
            this.NavBtnBoxOpenFolder.Name = "NavBtnBoxOpenFolder";
            this.NavBtnBoxOpenFolder.Size = new System.Drawing.Size(200, 50);
            this.NavBtnBoxOpenFolder.TabIndex = 0;
            // 
            // NavBtnOpenFolder
            // 
            this.NavBtnOpenFolder.BackColor = System.Drawing.Color.Transparent;
            this.NavBtnOpenFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NavBtnOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavBtnOpenFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavBtnOpenFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.NavBtnOpenFolder.FlatAppearance.BorderSize = 0;
            this.NavBtnOpenFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.NavBtnOpenFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.NavBtnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavBtnOpenFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NavBtnOpenFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NavBtnOpenFolder.Location = new System.Drawing.Point(0, 0);
            this.NavBtnOpenFolder.Name = "NavBtnOpenFolder";
            this.NavBtnOpenFolder.Size = new System.Drawing.Size(200, 50);
            this.NavBtnOpenFolder.TabIndex = 1;
            this.NavBtnOpenFolder.Text = "Open Folder";
            this.NavBtnOpenFolder.UseVisualStyleBackColor = false;
            this.NavBtnOpenFolder.Click += new System.EventHandler(this.NavBtnOpenFolder_ClickAsync);
            // 
            // NavBtnColorBlockOpenFolder
            // 
            this.NavBtnColorBlockOpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.NavBtnColorBlockOpenFolder.Location = new System.Drawing.Point(0, 0);
            this.NavBtnColorBlockOpenFolder.Name = "NavBtnColorBlockOpenFolder";
            this.NavBtnColorBlockOpenFolder.Size = new System.Drawing.Size(20, 50);
            this.NavBtnColorBlockOpenFolder.TabIndex = 1;
            // 
            // LogoContainer
            // 
            this.LogoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.LogoContainer.Controls.Add(this.Logo);
            this.LogoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoContainer.Location = new System.Drawing.Point(0, 0);
            this.LogoContainer.Name = "LogoContainer";
            this.LogoContainer.Size = new System.Drawing.Size(200, 100);
            this.LogoContainer.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(70, 20);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(60, 60);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.HeaderPanel.Controls.Add(this.HeaderTextInputBox);
            this.HeaderPanel.Controls.Add(this.HeaderText);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(200, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(584, 50);
            this.HeaderPanel.TabIndex = 1;
            // 
            // HeaderTextInputBox
            // 
            this.HeaderTextInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.HeaderTextInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeaderTextInputBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderTextInputBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderTextInputBox.Location = new System.Drawing.Point(20, 12);
            this.HeaderTextInputBox.Name = "HeaderTextInputBox";
            this.HeaderTextInputBox.Size = new System.Drawing.Size(544, 28);
            this.HeaderTextInputBox.TabIndex = 1;
            this.HeaderTextInputBox.Leave += new System.EventHandler(this.HeaderTextInputBox_Leave);
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderText.ForeColor = System.Drawing.Color.White;
            this.HeaderText.Location = new System.Drawing.Point(20, 10);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(68, 30);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "label1";
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.SearchInputUnderline);
            this.SearchBox.Controls.Add(this.SearchInput);
            this.SearchBox.Controls.Add(this.SearchLabel);
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBox.Location = new System.Drawing.Point(384, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(200, 80);
            this.SearchBox.TabIndex = 1;
            // 
            // SearchInputUnderline
            // 
            this.SearchInputUnderline.BackColor = System.Drawing.Color.White;
            this.SearchInputUnderline.Location = new System.Drawing.Point(20, 58);
            this.SearchInputUnderline.Name = "SearchInputUnderline";
            this.SearchInputUnderline.Size = new System.Drawing.Size(160, 2);
            this.SearchInputUnderline.TabIndex = 1;
            // 
            // SearchInput
            // 
            this.SearchInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.SearchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchInput.Location = new System.Drawing.Point(21, 36);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(160, 22);
            this.SearchInput.TabIndex = 1;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchLabel.ForeColor = System.Drawing.Color.White;
            this.SearchLabel.Location = new System.Drawing.Point(20, 10);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(42, 15);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.BodyPanel.Controls.Add(this.FontContainer);
            this.BodyPanel.Controls.Add(this.TxtContainer);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(200, 50);
            this.BodyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(584, 511);
            this.BodyPanel.TabIndex = 2;
            // 
            // TxtContainer
            // 
            this.TxtContainer.Controls.Add(this.SampleExampleBox);
            this.TxtContainer.Controls.Add(this.SearchBox);
            this.TxtContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtContainer.Location = new System.Drawing.Point(0, 0);
            this.TxtContainer.Name = "TxtContainer";
            this.TxtContainer.Size = new System.Drawing.Size(584, 80);
            this.TxtContainer.TabIndex = 0;
            // 
            // SampleExampleBox
            // 
            this.SampleExampleBox.Controls.Add(this.SampleTextInputUnderLine);
            this.SampleExampleBox.Controls.Add(this.SampleExampleInput);
            this.SampleExampleBox.Controls.Add(this.SampleTextLabel);
            this.SampleExampleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SampleExampleBox.Location = new System.Drawing.Point(0, 0);
            this.SampleExampleBox.Name = "SampleExampleBox";
            this.SampleExampleBox.Size = new System.Drawing.Size(384, 80);
            this.SampleExampleBox.TabIndex = 1;
            // 
            // SampleTextInputUnderLine
            // 
            this.SampleTextInputUnderLine.BackColor = System.Drawing.Color.White;
            this.SampleTextInputUnderLine.Location = new System.Drawing.Point(20, 58);
            this.SampleTextInputUnderLine.Name = "SampleTextInputUnderLine";
            this.SampleTextInputUnderLine.Size = new System.Drawing.Size(360, 2);
            this.SampleTextInputUnderLine.TabIndex = 1;
            // 
            // SampleExampleInput
            // 
            this.SampleExampleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.SampleExampleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SampleExampleInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SampleExampleInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SampleExampleInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SampleExampleInput.Location = new System.Drawing.Point(20, 38);
            this.SampleExampleInput.Name = "SampleExampleInput";
            this.SampleExampleInput.Size = new System.Drawing.Size(360, 22);
            this.SampleExampleInput.TabIndex = 2;
            this.SampleExampleInput.TextChanged += new System.EventHandler(this.SampleExampleInput_TextChanged);
            // 
            // SampleTextLabel
            // 
            this.SampleTextLabel.AutoSize = true;
            this.SampleTextLabel.ForeColor = System.Drawing.Color.White;
            this.SampleTextLabel.Location = new System.Drawing.Point(20, 10);
            this.SampleTextLabel.Name = "SampleTextLabel";
            this.SampleTextLabel.Size = new System.Drawing.Size(70, 15);
            this.SampleTextLabel.TabIndex = 1;
            this.SampleTextLabel.Text = "Sample Text";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.BarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DragHerePicture)).EndInit();
            this.BarPanel.ResumeLayout(false);
            this.NavContainer.ResumeLayout(false);
            this.NavBtnBoxMyFav.ResumeLayout(false);
            this.NavBtnBoxOpenFolder.ResumeLayout(false);
            this.LogoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.TxtContainer.ResumeLayout(false);
            this.SampleExampleBox.ResumeLayout(false);
            this.SampleExampleBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BarPanel;
        private Panel HeaderPanel;
        private Panel BodyPanel;
        private Panel LogoContainer;
        private PictureBox Logo;
        private Panel NavContainer;
        private Panel NavBtnBoxOpenFolder;
        private Button NavBtnOpenFolder;
        private Panel NavBtnColorBlockOpenFolder;
        private Panel NavBtnBoxMyFav;
        private Button NavBtnMyFav;
        private Panel NavBtnColorBlockMyFav;
        private Label HeaderText;
        private Panel SampleExampleBox;
        private Panel TxtContainer;
        private Panel SearchBox;
        private Label SampleTextLabel;
        private Panel SampleTextInputUnderLine;
        private TextBox SampleExampleInput;
        private Panel SearchInputUnderline;
        private TextBox SearchInput;
        private Label SearchLabel;
        private FlowLayoutPanel FontContainer;
        private PictureBox DragHerePicture;
        private TextBox HeaderTextInputBox;
    }
}