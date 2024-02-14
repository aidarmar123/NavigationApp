using CacheAppMaui.Service;

namespace CacheAppMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            DataManager.InitDataPath(Path.Combine(FileSystem.Current.AppDataDirectory, "copyWords.json"), DataManager.WordImportPath);
        }
    }
}
