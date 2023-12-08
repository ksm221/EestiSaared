using EestiSaared.Models;

namespace EestiSaared.Views;

public partial class IslandDetailsPage : ContentPage
{
	public IslandDetailsPage(Island island)
	{
		InitializeComponent();

		this.BindingContext = island;
	}

	async void BackButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}