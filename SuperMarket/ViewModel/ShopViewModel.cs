using CommunityToolkit.Mvvm.ComponentModel;

using SuperMarket.Model;
using SuperMarket.Services.Interfaces;

using System.Collections.ObjectModel;

namespace SuperMarket.ViewModel
{
	/// <summary>
	/// The view model for the shop.
	/// </summary>
	/// <param name="productService"></param>
	public partial class ShopViewModel(IProductService productService) : ViewModelBase
	{
		/// <summary>
		/// The list of products.
		/// </summary>
		[ObservableProperty]
		public ObservableCollection<Product> _products = productService.GetProducts();
	}
}
