using SuperMarket.ViewModel;

namespace SuperMarket.Services.Interfaces
{
	/// <summary>
	/// The navigation service.
	/// </summary>
	public interface INavigationService
	{
		/// <summary>
		/// Navigates to the specified view model.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		void NavigateTo<T>() where T : ViewModelBase;

		/// <summary>
		/// The current view model.
		/// </summary>
		ViewModelBase CurrentViewModel { get; }

		/// <summary>
		/// Event that is raised when the current view model changes.
		/// </summary>
		event Action? CurrentViewModelChanged;
	}
}
