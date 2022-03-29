using FontExplorer.Model;
using System.Diagnostics;

namespace FontExplorer.View
{
    public partial class MainForm : Form
    {
        private FontBox? CurrentScrollFontBox;
        private readonly List<FontBox> WhatIsInFontContainer = new();
        private string CurrentFolder = "";
        private bool IsInFavorite = false;
        private bool IsFromSingleFile = false;
        private string CurrentSingleFile = "";
        private Panel? DragHerePanel = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void SetColor()
        {
            Color primary = Settings.Settings.PrimaryColor;
            Settings.Settings.CurrentColor = primary;

            this.HeaderPanel.BackColor = primary;
            this.HeaderTextInputBox.BackColor = primary;
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
                DragHerePic.Image = Properties.Resources.draghere;
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

        internal void FillFontContainer(List<MyFont> collection, bool isRecoverFromMyFavorite = false)
        {
            if(isRecoverFromMyFavorite == false)
            {
                WhatIsInFontContainer.Clear();
            }
            int index = 1;

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
                    await Notice("Favorite Folder can not be opened here");
                }
                if (folder == systemFontFolder)
                {
                    await Notice("System Font Folder can not be opened here");
                }
            }
        }

        internal void LoadSingleFont(string file)
        {
            MyFont myfont = new(file);
            FontBox fontbox = new(myfont);
            fontbox.TopLevel = false;
            this.FontContainer.Controls.Clear();
            this.FontContainer.Controls.Add(fontbox);
            ShowHeaderText(file);
            fontbox.Show();
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
                SetColor();
                DisplayDragHerePic();
                Responsive();
                this.HeaderTextInputBox.Hide();
                this.HeaderText.Text = Settings.Settings.Name;
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
                        CurrentSingleFile = file;
                        IsInFavorite = false;
                    }
                    else
                    {
                        folder = CurrentFolder;
                        IsInFavorite = false;
                        ShowHeaderTextInputBox(folder);
                        FillFontContainerWhenRouteBackFromFavorites();
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
                ShowHeaderText(Settings.Settings.OpenFolderHeaderText);
                ShowFontContainer();

                ClearFontContainer();
                FillFontContentFromFavorites();
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
                if (SampleText.Length > 10)
                {
                    SampleText = SampleText[..10];
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
                    if (folders.Length == 1)
                    {
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
                            if (File.Exists(folder))
                            {
                                string file = folder;
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
                                        await Notice("Fail to load this font");
                                    }
                                }
                                else
                                {
                                    await Notice("Fail to load this font");
                                }
                            }
                            else
                            {
                                await Notice("This folder does not exist");
                            }
                        }
                    }
                    else
                    {
                        await Notice("You can only drop one folder here");
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
                string folder = this.HeaderTextInputBox.Text.Trim();
                if (Directory.Exists(folder))
                {
                    await LoadFontsFromPath(folder);
                }
                else
                {
                    ShowHeaderTextInputBox(CurrentFolder);
                    await Notice("This folder does not exist");
                }
            }
            catch (Exception ex)
            {
                await Notice(ex.Message);
            }
        }
    }
}