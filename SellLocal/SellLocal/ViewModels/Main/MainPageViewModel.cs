using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SellLocal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SellLocal.ViewModels.Main
{
    public class MainPageViewModel : ViewModelBase
    {
        public List<Filter> FilterList { get; set; }
        public ObservableCollection<Product> ProductList { get; set; }

        public MainPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            FilterList = new List<Filter>
            {
                new Filter
                {
                    FilterText = "Filter 1"
                },
                new Filter
                {
                    FilterText = "Filter 2"
                },
                new Filter
                {
                    FilterText = "Filter 3"
                },
                new Filter
                {
                    FilterText = "Filter 4"
                },
                new Filter
                {
                    FilterText = "Filter 5"
                }
            };

            ProductList = new ObservableCollection<Product>
            {
                new Product
                {
                    Id = 1,
                    ProductText = "Jammy Dodger Blondie",
                    ProductCategory = Models.Enums.ProductCategory.Food
                },
                new Product
                {
                    Id = 2,
                    ProductText = "Lamp",
                    ProductCategory = Models.Enums.ProductCategory.Homeware
                },
                new Product
                {
                    Id = 3,
                    ProductText = "Sewing Kit",
                    ProductCategory = Models.Enums.ProductCategory.Crafts
                },
                new Product
                {
                    Id = 4,
                    ProductText = "Blondie",
                    ProductCategory = Models.Enums.ProductCategory.Food
                },
                new Product
                {
                    Id = 5,
                    ProductText = "Makeup Brushes",
                    ProductCategory = Models.Enums.ProductCategory.Makeup
                },
                new Product
                {
                    Id = 6,
                    ProductText = "Rice Crispie Cake",
                    ProductCategory = Models.Enums.ProductCategory.Food
                },
                new Product
                {
                    Id = 7,
                    ProductText = "Gravy",
                    ProductCategory = Models.Enums.ProductCategory.Food
                }
            };
        }

        public override void Initialize(INavigationParameters parameters)
        {

        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {

        }
    }
}
