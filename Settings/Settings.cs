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
        internal static int SampleTextLenght = 12;

        internal static string DefaultSampleText = "Sample Text";
        internal static string Name = "Font Explorer";
        internal static string FavoritesFolder = "MyFavorites";
        internal static string MyFavoriteHeaderText = "My Favorites";
        internal static string OpenFolderHeaderText = "Open Folder";
        internal static string OpenFolderBtnText = "Open Folder";
        internal static string MyFavoritesBtnText = "My Favorites";
        internal static string SampleTextLabelText = "Sample Text";
        internal static string SearchLabelText = "Search";

        internal static string FavoriteFolderNotOpenHere = "Favorite Folder can not be opened here";
        internal static string SystemFolderNotOpenHere = "System Font Folder can not be opened here";
        internal static string OnlyOneFolderDropHere = "You can only drop one folder or multi-files here";
        internal static string ReadFontsFail = "Fail to load this font";
        internal static string FolderNotExist = "This folder does not exist";

        internal static string AddFontFail = "Add Font Failed";
        internal static string LoadFontFail = "Load Font Failed";
        internal static string RemoveFontFail = "Remove Font Failed";
        internal static string UnloadFontFail = "Unload Fonts Failed";

        internal static string AddToFavoritesFail = "Failed to add to Favorites";
        internal static string RemoveFromFavoritesFail = "Failed to remove from Favorites";

        internal static string FontIsSystemInstalled = "Some fonts have been already installed on system";

        internal static void SetLanguageOfCN()
        {
            DefaultSampleText = "测试文本";
            Name = "字体浏览器";
            FavoritesFolder = "我的收藏";
            MyFavoriteHeaderText = "我的收藏";
            OpenFolderHeaderText = "打开文件夹";
            OpenFolderBtnText = "打开文件夹";
            MyFavoritesBtnText = "我的收藏";
            SampleTextLabelText = "样本文字";
            SearchLabelText = "搜索";

            FavoriteFolderNotOpenHere = "收藏文件夹不能在这里打开";
            SystemFolderNotOpenHere = "系统文件夹不能在这里打开";
            OnlyOneFolderDropHere = "只允许一个文件或文件夹或多个文件被拖入";
            ReadFontsFail = "读取字体文件失败";
            FolderNotExist = "这个文件夹不存在";

            AddFontFail = "注册字体失败";
            RemoveFontFail = "移除字体失败";
            LoadFontFail = "加载字体失败";
            UnloadFontFail = "卸载字体失败";

            AddToFavoritesFail = "加入收藏失败";
            RemoveFromFavoritesFail = "从收藏移除字体失败";

            FontIsSystemInstalled = "一些字体已经安装在系统上了";
        }

        internal static bool IsChiniese()
        {
            string lang = System.Globalization.CultureInfo.CurrentUICulture.Name;
            if (lang.StartsWith("zh"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
