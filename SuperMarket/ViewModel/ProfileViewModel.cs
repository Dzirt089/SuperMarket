using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SuperMarket.ViewModel
{
	public partial class ProfileViewModel : ViewModelBase
	{
		[ObservableProperty]
		private string _userName = "Гость";

		[ObservableProperty]
		private bool _isReadMode = true;

		[RelayCommand]
		private void ToggleEdit() => IsReadMode = !IsReadMode;
	}
}
