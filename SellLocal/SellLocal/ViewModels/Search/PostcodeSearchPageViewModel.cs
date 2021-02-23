using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SellLocal.ViewModels.Search
{
    public class PostcodeSearchPageViewModel : ViewModelBase
    {
        public ICommand PostcodeSearchCommand { get; set; }
        public string Postcode { get; set; }
        public string ErrorText { get; set; }

        public PostcodeSearchPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            PostcodeSearchCommand = new Command(PostcodeSearch);
        }

        private void PostcodeSearch(object obj)
        {
            if (string.IsNullOrEmpty(Postcode))
            {
                ErrorText = "You must enter a postcode to continue";
            }
            else
            {
                NavigationService.NavigateAsync("MainPage");
            }
        }
    }
}
