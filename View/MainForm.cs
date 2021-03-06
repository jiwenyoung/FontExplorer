using FontExplorer.Model;

namespace FontExplorer.View
{
    public partial class MainForm : Form
    {
        private FontBox? CurrentScrollFontBox;
        private readonly List<FontBox> WhatIsInFontContainer = new();
        private string CurrentFolder = "";
        private bool IsInFavorite = false;
        private bool IsFromSingleFile = false;
        private bool IsFromMultiFile = false;
        private string CurrentSingleFile = "";
        private Panel? DragHerePanel = new();

        public MainForm()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void SetColor()
        {
            Color primary = Settings.Settings.PrimaryColor;
            Settings.Settings.CurrentColor = primary;

            this.HeaderPanel.BackColor = primary;
            this.HeaderTextInputBox.BackColor = primary;
        }

        private static void SetLanguage()
        {
            if(Settings.Settings.IsChiniese())
            {
                Settings.Settings.SetLanguageOfCN();
            }
        }

        private void SetBarBtnText()
        {
            this.NavBtnOpenFolder.Text = Settings.Settings.OpenFolderBtnText;
            this.NavBtnMyFav.Text = Settings.Settings.MyFavoritesBtnText;
        }

        private void SetMainFormCaption()
        {
            this.Text = Settings.Settings.Name;
        }

        private void SetSampleInputLabelAndSeachLabel()
        {
            this.SampleTextLabel.Text = Settings.Settings.SampleTextLabelText;
            this.SearchLabel.Text = Settings.Settings.SearchLabelText;
        }

        private void SetHeaderText()
        {
            this.HeaderTextInputBox.Hide();
            this.HeaderText.Text = Settings.Settings.Name;
        }

        private void DisplayDragHerePic() 
        {
            if(DragHerePanel != null)
            {
                DragHerePanel.Dock = DockStyle.Fill;
                DragHerePanel.AllowDrop = true;
                DragHerePanel.DragEnter += new DragEventHandler(FontContainer_DragEnter);
                DragHerePanel.DragDrop += new DragEventHandler(FontContainer_DragDrop);

                PictureBox DragHerePic = new();
                DragHerePic.Anchor = AnchorStyles.None;
                DragHerePic.Width = 300;
                DragHerePic.Height = 100;
                if (Settings.Settings.IsChiniese())
                {
                    DragHerePic.Image = Properties.Resources.draghereCN;
                }
                else
                {
                    DragHerePic.Image = Properties.Resources.draghere;
                }
                int x = (DragHerePanel.Width - DragHerePic.Width) / 2;
                int y = (DragHerePanel.Height - DragHerePic.Height) / 2;
                DragHerePic.Location = new Point(x, y);
                DragHerePanel.Controls.Add(DragHerePic);
            
                this.TxtContainer.Hide();
                this.FontContainer.Hide();
                this.BodyPanel.Controls.Add(DragHerePanel);
                DragHerePanel.Show();
            }
        }

        private void ShowFontContainer()
        {
            this.BodyPanel.Controls.Remove(DragHerePanel);
            this.TxtContainer.Show();
            this.FontContainer.Show();
            if(DragHerePanel != null)
            {
                DragHerePanel.Dispose();
            }
            DragHerePanel = null;
        }

        private void ShowHeaderTextInputBox(string folder)
        {
            this.HeaderText.Hide();
            this.HeaderTextInputBox.Text = folder;
            this.HeaderTextInputBox.Show();
        }

        private void ShowHeaderText(string text)
        {
            this.HeaderTextInputBox.Hide();
            this.HeaderText.Text = text;
            this.HeaderText.Show();
        }

        private void ClearFontContainer()
        {
            Fonts.Collection.Clear();
            this.FontContainer.Controls.Clear();
        }

        private void Responsive()
        {
            this.HeaderTextInputBox.Width = this.HeaderPanel.Width - 40;

            this.SampleExampleBox.Width = (int)(this.TxtContainer.Width * 0.7);
            this.SearchBox.Width = (int)(this.TxtContainer.Width * 0.3);
            int SampleExampleWidth = this.SampleExampleBox.Width - 40;
            this.SampleExampleInput.Width = SampleExampleWidth;
            this.SampleTextInputUnderLine.Width = SampleExampleWidth;
            int SearchBoxWidth = this.SearchBox.Width - 40;
            this.SearchInput.Width = SearchBoxWidth;
            this.SearchInputUnderline.Width = SearchBoxWidth;

            if (this.FontContainer.Controls.Count > 0)
            {
                List<Form> temp = new();
                foreach (Form ThisFontBox in this.FontContainer.Controls)
                {
                    temp.Add(ThisFontBox);
                };
                this.FontContainer.Controls.Clear();
                foreach (Form ThisFontBox in temp)
                {
                    this.FontContainer.Controls.Add(ThisFontBox);
                }
                this.FontContainer.Update();
            }
        }

        internal void SwitchBarNav(Button Btn, Panel ColorBlock)
        {
            foreach (Panel NavItem in this.NavContainer.Controls)
            {
                foreach (Control element in NavItem.Controls)
                {
                    if (element.GetType() == typeof(Button))
                    {
                        element.ForeColor = Color.White;
                    }
                    if (element.GetType() == typeof(Panel))
                    {
                        element.BackColor = Color.Transparent;
                    }
                }
            }
            ColorBlock.BackColor = Settings.Settings.CurrentColor;
            ColorBlock.BringToFront();
            Btn.ForeColor = Settings.Settings.CurrentColor;
        }

        internal async void FillFontContainer(List<MyFont> collection, bool isRecoverFromMyFavorite = false)
        {
            if(isRecoverFromMyFavorite == false)
            {
                WhatIsInFontContainer.Clear();
            }
            int index = 1;

            List<MyFont> installed = new();

            foreach (MyFont font in collection)
            {
                if (Fonts.IsInstalled(font) == false)
                {
                    FontBox fontbox = new(font);
                    fontbox.TopLevel = false;
                    if (index % 2 == 0)
                    {
                        this.FontContainer.SetFlowBreak(fontbox, true);
                    }
                    fontbox.Width = this.FontContainer.Width - 30;
                    this.FontContainer.Controls.Add(fontbox);
                    if(isRecoverFromMyFavorite == false)
                    {
                        WhatIsInFontContainer.Add(fontbox);
                    }
                    fontbox.Show();
                    index++;
                }
                else
                {
                    installed.Add(font);
                }
            }

            if(installed.Count > 0)
            {
                await Notice(Settings.Settings.FontIsSystemInstalled);
            }
        }

        internal void FillFontContainerWhenRouteBackFromFavorites()
        {
            ClearFontContainer();
            foreach(FontBox fontbox in WhatIsInFontContainer)
            {
                Fonts.Collection.Add(fontbox.MyFont);   
                this.FontContainer.Controls.Add(fontbox);
                fontbox.Show();    
            }
            this.FontContainer.ScrollControlIntoView(CurrentScrollFontBox);
        }

        internal async Task FillFontContainerFromPath(string folder)
        {
            if (folder != "")
            {
                if (Fonts.Init(folder))
                {
                    if (await Fonts.Fill())
                    {
                        FillFontContainer(Fonts.Collection);
                    }
                }
            }
        }

        internal void FillFontContentFromFavorites()
        {
            FillFontContainer(Favorites.Pool, true);
        }

        internal async Task LoadFontsFromPath(string folder)
        {
            string systemFontFolder = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            string favoriteFontFolder = Path.Combine(Environment.CurrentDirectory, Settings.Settings.FavoritesFolder); ;

            if (folder != systemFontFolder && folder != favoriteFontFolder)
            {
                this.HeaderText.Text = folder;
                ClearFontContainer();

                await FillFontContainerFromPath(folder);
                if (this.FontContainer.Controls.Count > 0)
                {
                    this.FontContainer.ScrollControlIntoView(this.FontContainer.Controls[0]);
                }
            }
            else
            {
                if (folder == favoriteFontFolder)
                {
                    await Notice(Settings.Settings.FavoriteFolderNotOpenHere);
                }
                if (folder == systemFontFolder)
                {
                    await Notice(Settings.Settings.SystemFolderNotOpenHere);
                }
            }
        }

        internal void LoadSingleFont(string file)
        {
            MyFont myfont = new(file);
            FontBox fontbox = new(myfont);
            fontbox.TopLevel = false;
            fontbox.Show();
            WhatIsInFontContainer.Clear();
            this.FontContainer.Controls.Clear();
            this.FontContainer.Controls.Add(fontbox);
            WhatIsInFontContainer.Add(fontbox);
            ShowHeaderTextInputBox(file);
        }

        internal async void LoadMultiFont(List<string> files)
        {
            ShowHeaderText("Multi Files");
            ClearFontContainer();
            WhatIsInFontContainer.Clear();
            foreach (string file in files)
            {
                if (Fonts.Init(file))
                {
                    if (await Fonts.Fill())
                    {
                        ShowFontContainer();
                        MyFont myfont = new(file);
                        FontBox fontBox = new(myfont);
                        fontBox.TopLevel = false;
                        this.FontContainer.Controls.Add(fontBox);
                        WhatIsInFontContainer.Add(fontBox);
                        fontBox.Show();
                    }
                }
            }
        }

        internal async Task<bool> Notice(string notice)
        {
            Panel NoticeBox = new();
            int Width = 400;
            int Height = 100;
            NoticeBox.Size = new Size(Width, Height);
            int x = this.Width;
            int y = this.Height - Height;
            NoticeBox.Location = new Point(x, y);
            NoticeBox.BackColor = Settings.Settings.CurrentColor;

            Label NoticeText = new();
            NoticeText.Text = notice;
            NoticeText.Width = NoticeBox.Width;
            NoticeText.TextAlign = ContentAlignment.MiddleCenter;
            NoticeText.ForeColor = Settings.Settings.LightestGrey;
            NoticeText.Font = new Font("Segoe UI", 10);
            y = (Height - NoticeText.Height) / 4;
            NoticeText.Location = new Point(0, y);

            this.Controls.Add(NoticeBox);
            NoticeBox.Controls.Add(NoticeText);
            NoticeBox.BringToFront();
            NoticeText.Show();
            NoticeBox.Show();

            int startX = this.Width;
            int startY = this.Height - Height;
            while (true)
            {
                startX -= 10;
                NoticeBox.Location = new Point(startX, startY);
                await Task.Delay(4);
                if (startX <= (this.Width - NoticeBox.Width))
                {
                    break;
                }
            }
            await Task.Delay(2000);
            NoticeBox.Hide();
            this.Controls.Remove(NoticeBox);
            NoticeBox.Dispose();
            return true;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetLanguage();
                SetMainFormCaption();
                SetBarBtnText();
                SetSampleInputLabelAndSeachLabel();
                SetHeaderText();
                SetColor();
                DisplayDragHerePic();
                Responsive();
                await Favorites.SyncFavorites();
            }
            catch (Exception ex)
            {
                await Notice(ex.Message);
            }
        }

        private async void MainForm_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                Responsive();
                this.FontContainer.ScrollControlIntoView(CurrentScrollFontBox);
            }
            catch (Exception ex)
            {

                await Notice(ex.Message);
            }
        }

        private async void NavBtnOpenFolder_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                SwitchBarNav(this.NavBtnOpenFolder, this.NavBtnColorBlockOpenFolder);
                this.HeaderText.Text = Settings.Settings.OpenFolderHeaderText;
                ShowFontContainer();

                string folder = "";
                if (IsInFavorite)
                {
                    if (IsFromSingleFile)
                    {
                        string file = CurrentSingleFile;
                        ShowFontContainer();
                        LoadSingleFont(file);
                        IsFromSingleFile = true;
                        IsFromMultiFile = false;
                        CurrentSingleFile = file;
                        IsInFavorite = false;
                    }
                    else
                    {
                        if (IsFromMultiFile)
                        {

                            IsInFavorite = false;
                            IsFromMultiFile = true;
                            IsFromSingleFile = false;
                            this.FontContainer.Controls.Clear();
                            Fonts.Collection.Clear();
                            List<string> paths = new();
                            foreach(FontBox fontBox in WhatIsInFontContainer)
                            {
                                paths.Add(fontBox.MyFont.Path);
                            }
                            LoadMultiFont(paths);
                            ShowFontContainer();
                        }
                        else
                        {
                            folder = CurrentFolder;
                            IsInFavorite = false;
                            ShowHeaderTextInputBox(folder);
                            FillFontContainerWhenRouteBackFromFavorites();
                        }
                    }
                }
                else
                {
                    FolderBrowserDialog PickFolderDialog = new();
                    DialogResult result = PickFolderDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        folder = PickFolderDialog.SelectedPath;
                        CurrentFolder = folder;
                        ShowHeaderTextInputBox(folder);
                        await LoadFontsFromPath(folder);
                    }
                }
                    
            }
            catch (Exception ex)
            {
                await Notice(ex.Message);
            }
        }

        private async void NavBtnMyFav_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                SwitchBarNav(this.NavBtnMyFav, this.NavBtnColorBlockMyFav);

                IsInFavorite = true;   
                ShowFontContainer();
                ClearFontContainer();
                FillFontContentFromFavorites();
                ShowHeaderText(Settings.Settings.MyFavoriteHeaderText);
            }
            catch (Exception ex)
            {
                await Notice(ex.Message);
            }
        }

        private async void FontContainer_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                int index = e.NewValue / 100;
                if (index < this.FontContainer.Controls.Count - 1)
                {
                    CurrentScrollFontBox = (FontBox)this.FontContainer.Controls[index];
                }
            }
            catch (Exception ex)
            {
                await Notice(ex.Message);
            }
        }

        private async void SampleExampleInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string SampleText = SampleExampleInput.Text;
                if (SampleText.Length > Settings.Settings.SampleTextLenght)
                {
                    SampleText = SampleText[..Settings.Settings.SampleTextLenght];
                }
                foreach (FontBox fontbox in this.FontContainer.Controls)
                {
                    fontbox.SyncSampleText(SampleText);
                }
            }
            catch (Exception ex)
            {
                await Notice(ex.Message);
            }
        }

        private async void SearchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                void FillContainer(List<FontBox> group)
                {
                    int index = 1;
                    foreach (FontBox fontbox in group)
                    {
                        this.FontContainer.SetFlowBreak(fontbox, false);
                        if (index % 2 == 0)
                        {
                            this.FontContainer.SetFlowBreak(fontbox, true);
                        }
                        this.FontContainer.Controls.Add(fontbox);
                        index++;
                    }
                }

                if (WhatIsInFontContainer.Count > 0)
                {
                    string keyword = SearchInput.Text.Trim();
                    if (keyword.Length > 0)
                    {
                        List<FontBox> group = new();
                        foreach (FontBox fontbox in WhatIsInFontContainer)
                        {
                            if (fontbox.MyFont.Name.Contains(keyword))
                            {
                                group.Add(fontbox);
                            }
                        }
                        this.FontContainer.Controls.Clear();
                        if (group.Count > 0)
                        {
                            FillContainer(group);
                        }
                    }
                    else
                    {
                        FillContainer(WhatIsInFontContainer);
                    }
                }
            }
            catch (Exception ex)
            {
                await Notice(ex.Message);
            }
        }

        private void FontContainer_DragEnter(object? sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private async void FontContainer_DragDrop(object? sender, DragEventArgs e)
        {
            try
            {
                if (e.Data != null)
                {
                    string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

                    static bool IsArrayIncludeMoreThanOneFolder(string[] folders)
                    {
                        if(folders.Length == 1)
                        {
                            string folder = folders[0];
                            if (Directory.Exists(folder))
                            {
                                return false;
                            }
                            string file = folder;
                            if (File.Exists(file))
                            {
                                return false;
                            }
                            return true;
                        }
                        else
                        {
                            int howmanyfiles = 0;
                            foreach(string folder in folders)
                            {
                                if (Directory.Exists(folder))
                                {
                                    return true;
                                }
                                if (File.Exists(folder))
                                {
                                    howmanyfiles++;
                                }
                            }

                            if(howmanyfiles == folders.Length)
                            {
                                return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }

                    if (IsArrayIncludeMoreThanOneFolder(folders))
                    {
                        await Notice(Settings.Settings.OnlyOneFolderDropHere);
                    }
                    else
                    {
                        if(folders.Length == 1)
                        {
                            // Only One Folder
                            string folder = folders[0];
                            if (Directory.Exists(folder))
                            {
                                CurrentFolder = folder;
                                SwitchBarNav(this.NavBtnOpenFolder, this.NavBtnColorBlockOpenFolder);
                                ShowHeaderTextInputBox(folder);
                                ShowFontContainer();
                                ClearFontContainer();
                                await FillFontContainerFromPath(folder);
                                if (this.FontContainer.Controls.Count > 0)
                                {
                                    this.FontContainer.ScrollControlIntoView(this.FontContainer.Controls[0]);
                                }
                            }
                            else
                            {
                                string file = folder;
                                if (File.Exists(file))
                                {
                                    if (Fonts.Init(file))
                                    {
                                        if (await Fonts.Fill())
                                        {
                                            ShowFontContainer();
                                            LoadSingleFont(file);
                                            IsFromSingleFile = true;
                                            CurrentSingleFile = file;
                                        }
                                        else
                                        {
                                            await Notice(Settings.Settings.ReadFontsFail);
                                        }
                                    }
                                    else
                                    {
                                        await Notice(Settings.Settings.ReadFontsFail);
                                    }
                                }
                                else
                                {
                                    await Notice(Settings.Settings.FolderNotExist);
                                }
                            }
                        }
                        else
                        {
                            // Many Files
                            Fonts.Collection.Clear();
                            this.FontContainer.Controls.Clear();
                            LoadMultiFont(folders.ToList());
                            IsFromMultiFile = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                await Notice(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Fonts.LoadedFonts.Count > 0)
                {
                    foreach (MyFont myfont in Fonts.LoadedFonts)
                    {
                        myfont.Unload();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private async void HeaderTextInputBox_Leave(object sender, EventArgs e)
        {
            try
            {
                string destination = this.HeaderTextInputBox.Text.Trim();
                if (Directory.Exists(destination))
                {
                    string folder = destination;
                    await LoadFontsFromPath(folder);
                }
                else
                {
                    if (File.Exists(destination))
                    {
                        string file = destination;
                        if (Fonts.Init(file))
                        {
                            if(await Fonts.Fill())
                            {
                                LoadSingleFont(file);
                                IsFromSingleFile = true;
                                CurrentSingleFile = file;
                            }
                        }
                    }
                    else
                    {
                        ShowHeaderTextInputBox(CurrentFolder);
                        await Notice(Settings.Settings.FolderNotExist);
                    }
                }
            }
            catch (Exception ex)
            {
                await Notice(ex.Message);
            }
        }
    }
}