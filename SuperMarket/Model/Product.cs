using CommunityToolkit.Mvvm.ComponentModel;

namespace SuperMarket.Model
{
	public class Product : ObservableObject
	{
		/// <summary>
		/// The URL of the image of the product.
		/// </summary>
		public string ImageUrl
		{
			get => _imageUrl;
			set => SetProperty(ref _imageUrl, value);
		}
		private string _imageUrl;

		/// <summary>
		/// The name of the product.
		/// </summary>
		public string Name
		{
			get => _name;
			set => SetProperty(ref _name, value);
		}
		private string _name;

		/// <summary>
		/// The quantity of the product.
		/// </summary>
		public int Quantity
		{
			get => _quantity;
			set => SetProperty(ref _quantity, value);
		}
		private int _quantity;
	}
}
