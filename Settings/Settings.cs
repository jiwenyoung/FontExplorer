namespace FontExplorer.Settings
{
    internal static class Settings
    {
        internal static Color CurrentColor = ColorTranslator.FromHtml("#5352ed");
        internal static Color PrimaryColor
        {
            get
            {
                string[] Colors = {
                   "#5352ed",
                   "#ff6348",
                   "#ffa502",
                   "#2980b9",
                   "#d35400",
                   "#8e44ad",
                   "#c0392b",
                   "#16a085"
                };
                int rand = new Random().Next(Colors.Length);
                return ColorTranslator.FromHtml(Colors[rand]);
            }
        }
        internal static Color brighterGrey = ColorTranslator.FromHtml("#57606f");
        internal static Color darkerGrey = ColorTranslator.FromHtml("#2f3542");
        internal static Color LightestGrey = Color.FromArgb(224, 224, 224, 255);
        internal static int SampleTextFontSize = 30;
        internal static string DefaultSampleTextOfEnglish = "Sample Text";
        internal static string Name = "Font Explorer";
        internal static string FavoritesFolder = "MyFavorites";
        internal static string MyFavoriteHeaderText = "My Favorites";
        internal static string OpenFolderHeaderText = "Open Folder";
    }
}
