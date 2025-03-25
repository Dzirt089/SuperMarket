using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using SuperMarket.Services.Interfaces;

namespace SuperMarket.ViewModel
{
	partial class MainViewModel : ViewModelBase
	{
		private readonly INavigationService _navigationService;


		[ObservableProperty]
		private string _currentPageTitle = "Магазин";

		[ObservableProperty]
		private bool _isMenuExpanded = true;

		public MainViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			_navigationService.CurrentViewModelChanged += OnNavigationServiceCurrentViewModelChanged;
			_navigationService.NavigateTo<ShopViewModel>();

		}

		private void OnNavigationServiceCurrentViewModelChanged() => CurrentPageTitle = _navigationService.CurrentViewModel switch
		{
			ShopViewModel => "Магазин",
			CartViewModel => "Корзина",
			ProfileViewModel => "Профиль",
			_ => "Приложение"
		};

		[RelayCommand]
		private void ToggleMenu() => IsMenuExpanded = !IsMenuExpanded;

		[RelayCommand]
		private void NavigateToShop() => _navigationService.NavigateTo<ShopViewModel>();

		[RelayCommand]
		private void NavigateToCart() => _navigationService.NavigateTo<CartViewModel>();

		[RelayCommand]
		private void NavigateToProfile() => _navigationService.NavigateTo<ProfileViewModel>();
	}
}
