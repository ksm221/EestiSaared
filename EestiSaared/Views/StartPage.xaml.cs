using EestiSaared.Models;

namespace EestiSaared.Views
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}