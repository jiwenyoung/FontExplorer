using FontExplorer.Model;

namespace FontExplorer.View
{
    public partial class FontBox : Form
    {
        internal readonly MyFont MyFont;

        internal FontBox(MyFont myFont)
        {
            InitializeComponent();
            this.MyFont = myFont;
        }

        private static async Task Notice(string notice)
        {
            MainForm mainform;
            if (Application.OpenForms["MainForm"] != null)
            {
                mainform = (MainForm)Application.OpenForms["MainForm"];
                await mainform.Notice(notice);
            }
        }

        internal void SetColorBlockStatus(bool open)
        {
            if (open)
            {
                this.FontColorBlock.BackColor = Settings.Settings.CurrentColor;
            }
            else
            {
                this.FontColorBlock.BackColor = Settings.Settings.LightestGrey;
            }
        }

        internal void SyncSampleText(string sampletext)
        {
            this.SampleText.Text = sampletext.Trim();
        }

        private void FontBox_Load(object sender, EventArgs e)
        {
            if (Fonts.IsLoaded(MyFont))
            {
                this.LoadBtn.Hide();
                this.UnloadBtn.Show(); 
                SetColorBlockStatus(true);
            }
            else
            {
                this.UnloadBtn.Hide();
                this.LoadBtn.Show();
                SetColorBlockStatus(false);
            }
            if (Favorites.IsInFavorites(MyFont))
            {
                this.FavoriteBtn.Hide();
                this.UnfavoriteBtn.Show();
            }
            else 
            { 
                this.UnfavoriteBtn.Hide();
                this.FavoriteBtn.Show();
            }
            
            this.SampleText.Text = Settings.Settings.DefaultSampleTextOfEnglish;
            this.SampleText.Font = this.MyFont.Get(Settings.Settings.SampleTextFontSize);
            this.SampleText.Show();
            this.FontNameLabel.Text = this.MyFont.Name;
        }

        private async void LoadBtn_Click(object sender, EventArgs e)
        {
            if (MyFont.Load())
            {
                if (Fonts.RegistorFontAsync(MyFont))
                {
                    SetColorBlockStatus(true);
                    this.LoadBtn.Hide();
                    this.UnloadBtn.Show();
                }
                else
                {
                    await Notice("Add Font Failed");
                }
            }
            else
            {
                await Notice("Load Font Failed");
            }
        }

        private async void UnloadBtn_ClickAsync(object sender, EventArgs e)
        {
            if (MyFont.Unload())
            {
                if (Fonts.UnRegistorFont(MyFont))
                {
                    SetColorBlockStatus(false);
                    this.UnloadBtn.Hide();
                    this.LoadBtn.Show();
                }
                else
                {
                    await Notice("Remove Fonts Failed");
                }
            }
            else
            {
                await Notice("Unload Fonts Failed");
            }
        }

        private async void UnfavoriteBtn_Click(object sender, EventArgs e)
        {
            if(Favorites.RemoveFromFavorites(MyFont))
            {
                this.UnfavoriteBtn.Hide();
                this.FavoriteBtn.Show();
            }
            else
            {
                await Notice("Failed to remove from Favorites");
            }
        }

        private async void FavoriteBtn_Click(object sender, EventArgs e)
        {
            if(await Favorites.AddToFavorites(MyFont))
            {
                this.FavoriteBtn.Hide();
                this.UnfavoriteBtn.Show();
            }
            else
            {
                await Notice("Failed to add to Favorites");
            }
        }
    }
}
