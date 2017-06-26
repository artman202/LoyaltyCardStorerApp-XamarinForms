using FreshMvvm;
using LoyaltyCardStorerApp.Pages;
using Xamarin.Forms;

namespace LoyaltyCardStorerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetNavigation();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public void SetNavigation()
        {
            var navContainer = new FreshMasterDetailNavigationContainer();
            navContainer.Init("Menu", "hamburger.png");
            navContainer.AddPage<DashBoardPageModel>("Dashboard");
            navContainer.AddPage<CardsPageModel>("My Loyalty Cards");

			MainPage = navContainer;
        }
    }
}
