
using CacheAppMaui.Service;

namespace CacheAppMaui
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            var words = DataManager.Words;
            //var imageBytes = Convert.FromBase64String(words[0].word);
            //words[0].Image = ImageSource.FromStream(() => new MemoryStream(imageBytes));
        }
    }

}
