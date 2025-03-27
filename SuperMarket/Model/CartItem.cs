using CommunityToolkit.Mvvm.ComponentModel;

namespace SuperMarket.Model
{
	/// <summary>
	/// The item in the cart.
	/// </summary>
	public class CartItem : ObservableObject
	{
		/// <summary>
		/// The product in the cart.
		/// </summary>
		public Product Product
		{
			get => _product;
			set => SetProperty(ref _product, value);
		}
		private Product _product;

		/// <summary>
		/// The quantity of the product in the cart.
		/// </summary>
		public int CartQuantity
		{
			get => _cartQuantity;
			set => SetProperty(ref _cartQuantity, value);
		}
		private int _cartQuantity;

		/// <summary>
		/// The status of the product in the cart.
		/// </summary>
		public string Status => CartQuantity > Product.Quantity ? "❌" : "✅";
	}
}
