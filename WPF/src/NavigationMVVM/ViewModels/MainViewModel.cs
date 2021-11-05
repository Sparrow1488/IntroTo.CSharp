using NavigationMVVM.Commands;
using NavigationMVVM.Stores;
using System.Windows;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(NavigationStore navigationStore)
        {
            MessageBox.Show("MainVM");
            _navigationStore = navigationStore;
            NavigateAccountCommand = new NavigateAccountCommand(_navigationStore);

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }
        private readonly NavigationStore _navigationStore;
        public ICommand NavigateAccountCommand { get; set; }
        public ViewModelBase CurrentViewModel  => _navigationStore.CurrentViewModel;
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
