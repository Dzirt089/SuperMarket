using SuperMarket.Model;

namespace SuperMarket.Services.Interfaces
{
	public interface IProductService
	{
		/// <summary>
		/// Get the list of products.
		/// </summary>
		/// <returns></returns>
		List<Product> GetProducts();
	}
}
