using SuperMarket.Services.Interfaces;
using SuperMarket.ViewModel;

namespace SuperMarket.Services
{
	/// <summary>
	/// The navigation service.
	/// </summary>
	public class NavigationService : INavigationService
	{
		/// <summary>
		/// The current view model.
		/// </summary>
		public ViewModelBase CurrentViewModel { get; private set; }

		/// <summary>
		/// Event that is raised when the current view model changes.
		/// </summary>
		public event Action? CurrentViewModelChanged;

		/// <summary>
		/// Navigates to the specified view model.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		public void NavigateTo<T>() where T : ViewModelBase
		{
			CurrentViewModel = Activator.CreateInstance<T>();
			CurrentViewModelChanged?.Invoke();
		}
	}
}
