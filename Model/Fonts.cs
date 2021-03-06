using System.Drawing.Text;

namespace FontExplorer.Model
{
    internal static class Fonts
    {
        internal static string Folder = "";
        internal static List<MyFont> Collection = new();
        internal static List<MyFont> LoadedFonts = new();
        internal static InstalledFontCollection InstalledFonts = new();

        internal static bool Init(string dir)
        {
            if (Directory.Exists(dir))
            {
                Folder = dir;
                return true;
            }
            else
            {
                if (File.Exists(dir))
                {
                    Folder = dir;
                    return true;
                }
                else
                {
                    Folder = "";
                    return false;
                }
            }
        }

        internal static async Task<bool> Fill(bool isClear = true) {
            if(Folder != "")
            {
                bool IsFileOrFolder = false;
                if (Directory.Exists(Folder))
                {
                    IsFileOrFolder = true;
                    if (isClear)
                    {
                        Collection.Clear();
                    }
                    string[] files = await Task.Run(() => { return Directory.GetFiles(Folder); });
                    foreach (string file in files)
                    {
                        if (File.Exists(file))
                        {
                            if(file.EndsWith(".otf") || file.EndsWith(".ttf"))
                            {
                                MyFont myfont = new(file);
                                Collection.Add(myfont);
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return true; 
                }
                if (File.Exists(Folder))
                {
                    IsFileOrFolder= true;
                    if (isClear)
                    {
                        Collection.Clear();  
                    }
                    string file = Folder;
                    if(file.EndsWith(".otf") || file.EndsWith(".ttf"))
                    {
                        MyFont myfont = new(file);
                        Collection.Add(myfont);
                    }
                    else
                    {
                        return false;
                    }
                }
                if (IsFileOrFolder)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        internal static bool RegistorFont(MyFont myFont) { 
            LoadedFonts.Insert(0,myFont);
            return true; 
        }
        internal static bool UnRegistorFont(MyFont myfont) {
            LoadedFonts.Remove(myfont);
            return true; 
        }
        internal static bool IsLoaded(MyFont myfont)
        {
            if (LoadedFonts.Contains(myfont))
            {
                return true;
            }
            else { 
                return false; 
            }
        }

        internal static bool IsInstalled(MyFont myFont)
        {
            FontFamily[] families = InstalledFonts.Families;
            foreach (FontFamily family in families)
            {
                if (family.Name == myFont.Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
