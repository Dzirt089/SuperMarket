using CommunityToolkit.Mvvm.ComponentModel;

using SuperMarket.Model;
using SuperMarket.Services.Interfaces;

using System.Collections.ObjectModel;

namespace SuperMarket.ViewModel
{
	/// <summary>
	/// The view model for the cart.
	/// </summary>
	/// <param name="productService"></param>
	public partial class CartViewModel(IProductService productService) : ViewModelBase
	{
		/// <summary>
		/// The list of cart items.
		/// </summary>
		[ObservableProperty]
		private ObservableCollection<CartItem> _cartItems = [new CartItem { Product = productService.GetProducts()[0], CartQuantity = 2 }];
	}
}
