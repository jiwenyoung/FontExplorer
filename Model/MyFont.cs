using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace FontExplorer.Model
{
    internal class MyFont
    {
        [DllImport("gdi32.dll", EntryPoint = "AddFontResource", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int AddFontResource(string lpFileName);

        [DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int RemoveFontResource(string lpFileName);

        internal string Name { get; set; }
        internal FontFamily? FontFamily { get; set; }
        internal string Path { get; }

        internal MyFont(string Path)
        {
            if (File.Exists(Path))
            {
                this.Path = Path;
                PrivateFontCollection MyFonts = new();
                MyFonts.AddFontFile(Path);
                FontFamily MyFontFamily = MyFonts.Families[0];
                this.FontFamily = MyFontFamily;
                this.Name = MyFontFamily.Name;
            }
            else
            {
                this.Path = "";
                this.Name = "";
            }
        }

        internal bool Load()
        {
            string fontfile = this.Path;
            if (File.Exists(fontfile))
            {
                int result = AddFontResource(fontfile);
                int error = Marshal.GetLastWin32Error();
                if (result != 0)
                {
                    return true;
                }
                else
                {
                    Debug.WriteLine(new Win32Exception(error).Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        internal bool Unload()
        {
            string fontfile = this.Path;
            if (File.Exists(fontfile) == false)
            {
                return false;
            }
            else
            {
                int result = RemoveFontResource(fontfile);
                int error = Marshal.GetLastWin32Error();
                if (result != 0)
                {
                    return true;
                }
                else
                {
                    Debug.WriteLine(new Win32Exception(error).Message);
                    return false;
                }
            }
        }

        internal Font Get(int size)
        {
            if (this.FontFamily != null)
            {
                return new Font(this.FontFamily, size);
            }
            else
            {
                return new Font("Segoe UI", size);
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj is MyFont comparedFont)
            {
                if (comparedFont.Name == this.Name)
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
