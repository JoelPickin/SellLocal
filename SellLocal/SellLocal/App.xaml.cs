using Prism;
using Prism.Ioc;
using SellLocal.ViewModels;
using SellLocal.ViewModels.Main;
using SellLocal.ViewModels.Search;
using SellLocal.Views;
using SellLocal.Views.Main;
using SellLocal.Views.Search;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace SellLocal
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/PostcodeSearchPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<PostcodeSearchPage, PostcodeSearchPageViewModel>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }
    }
}
