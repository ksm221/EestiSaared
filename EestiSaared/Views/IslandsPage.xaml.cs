using EestiSaared.Models;
using EestiSaared.Services;

namespace EestiSaared.Views;

public partial class IslandsPage : ContentPage
{
	public IslandsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstPopularPlanets.ItemsSource = IslandsService.GetFeaturedIslands();
        lstAllPlanets.ItemsSource = IslandsService.GetAllPlanets();
    }

    async void ApiPic_Clicked(System.Object sender, System.EventArgs e)
	{

	}

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		await Navigation.PushAsync(new IslandDetailsPage(e.CurrentSelection.First() as Island));
    }
}