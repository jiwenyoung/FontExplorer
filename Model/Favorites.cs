namespace FontExplorer.Model
{
    internal static class Favorites
    {
        internal static List<MyFont> Pool = new();
        internal static string FavoritesFolder = "MyFavorites";

        private static string ComposeFavoriteFile(MyFont myfont)
        {
            string originPath = myfont.Path;
            string extension = Path.GetExtension(originPath);
            string filename = string.Format("{0}{1}", myfont.Name, extension);
            string to = Path.Combine(Environment.CurrentDirectory, FavoritesFolder);
            to = Path.Combine(to, filename);
            return to;
        }

        internal static async Task<bool> SyncFavorites()
        {
            string folder = Path.Combine(Environment.CurrentDirectory, FavoritesFolder);
            if(Directory.Exists(folder) == false)
            {
                Directory.CreateDirectory(folder);
                return true;
            }
            else
            {
                string[] files = await Task.Run(() => { return Directory.GetFiles(folder); });   
                if(files.Length > 0)
                {
                    foreach(string file in files)
                    {
                        MyFont thisfont = new(file);
                        Pool.Add(thisfont);
                    }
                }
                return true;
            }
        }

        internal static async Task<bool> AddToFavorites(MyFont myfont)
        {
            static async Task<bool> CopyFileAsync(string source, string destination)
            {
                FileStream SourceSream = File.OpenRead(source);
                FileStream DestinationStream = File.Create(destination);
                await SourceSream.CopyToAsync(DestinationStream);
                SourceSream.Close();
                DestinationStream.Close();
                return true;
            }

            string from = myfont.Path;
            string to = ComposeFavoriteFile(myfont);
            if (File.Exists(to))
            {
                File.Delete(to);
            }
            if (await CopyFileAsync(from, to))
            {
                Pool.Insert(0, myfont);
                return true;
            }
            else {
                return false;            
            }
        }

        internal static bool RemoveFromFavorites(MyFont myfont) 
        {
            string favoriteFile = ComposeFavoriteFile(myfont);
            File.Delete(favoriteFile);
            Pool.Remove(myfont);
            return true; 
        }

        internal static bool IsInFavorites(MyFont myfont) 
        {
            if (Pool.Contains(myfont))
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
