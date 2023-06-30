using System;
using CRToolKit.DTO;
using CRToolKit.Models;
using System.Linq;

namespace CRToolKit.Views
{
	public class List1VM:BaseViewModel
	{
        public List1VM()
        {
            PopulateProds();
        }
        public List<ProductListDTO> ProductList { get; set; }
        public string DisplayProductDescription { get; set; }

        public Command OnProductDetailNavigation
        {
            get
            {
                return new Command<Int32>(async (activitySummaryId) =>
                {
                    var detailPage = new MainPage();
                    await Navigation.PushModalAsync(detailPage);
                });
            }
        }

        private async void PopulateProds()
        {
            var prodList = await App.Database.database.Table<Product>().ToListAsync();
            ProductList = prodList.Select(x => new ProductListDTO
            {
                ProductId = x.Id,
                DisplayProductDescription = x.Description
            }).ToList();
            OnPropertyChanged("ProductList");
        }

    }
}

