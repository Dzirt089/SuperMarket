using SuperMarket.Model;

using System.Collections.ObjectModel;

namespace SuperMarket.Services.Interfaces
{
	/// <summary>
	/// The service for the products.
	/// </summary>
	public interface IProductService
	{
		/// <summary>
		/// Get the list of products.
		/// </summary>
		/// <returns></returns>
		ObservableCollection<Product> GetProducts();
	}
}
