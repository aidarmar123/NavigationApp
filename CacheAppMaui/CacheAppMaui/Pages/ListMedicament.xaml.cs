using CacheAppMaui.Models;
using CacheAppMaui.Service;

namespace CacheAppMaui.Pages;

public partial class ListMedicament : ContentPage
{
    List<Word> words = DataManager.Words;
    public ListMedicament()
	{
		InitializeComponent();

		var listNumber = new List<Word>();
		for(int i = 0; i < words.Count; i++)
		{
			var number = words[i].testNumber;
			for(int y  = 0; y < listNumber.Count; y++)
			{
				if (listNumber[y].testNumber == number)
					listNumber.Remove(listNumber[y]);
			}
			listNumber.Add(words[i]);
		}
		PNumber.ItemsSource = listNumber;
		Refresh(words);
		
	}

    private void Refresh(List<Word> words)
    {
        LVMedicaments.ItemsSource = words;
    }

    private void LVMedicaments_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if(LVMedicaments.SelectedItem is Word word)
		{
			Navigation.PushModalAsync(new InformationWord(word));
		}
    }

    private void BFilter_Clicked(object sender, EventArgs e)
    {
		if(PNumber.SelectedItem is Word word)
		{
			var filterList = words.Where(x => x.testNumber == word.testNumber).ToList();
			Refresh(filterList);
		}
    }

    private void BAll_Clicked(object sender, EventArgs e)
    {
		Refresh(words);
    }
}