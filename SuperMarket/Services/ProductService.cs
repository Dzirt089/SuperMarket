using SuperMarket.Model;
using SuperMarket.Services.Interfaces;

using System.Collections.ObjectModel;

namespace SuperMarket.Services
{
	/// <summary>
	/// The service for the products.
	/// </summary>
	class ProductService : IProductService
	{
		/// <summary>
		/// Get the list of products.
		/// </summary>
		/// <returns></returns>
		public ObservableCollection<Product> GetProducts()
		{
			return
			[
				new() {
					ImageUrl = "https://via.placeholder.com/150",
					Name = "Бананы",
					Quantity = 10
				},
				new()
				{
					ImageUrl = "https://via.placeholder.com/150",
					Name = "Яблоки",
					Quantity = 20
				},
				new()
				{
					ImageUrl = "https://via.placeholder.com/150",
					Name = "Груши",
					Quantity = 30
				},
				new()
				{
					ImageUrl = "https://via.placeholder.com/150",
					Name = "Помидоры",
					Quantity = 50
				}
			];
		}
	}

}
