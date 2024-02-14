using CacheAppMaui.Models;

namespace CacheAppMaui.Pages;

public partial class InformationWord : ContentPage
{
	public InformationWord(Word word)
	{
		InitializeComponent();
		VSLContent.BindingContext = word;
	}

    private void BBack_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}