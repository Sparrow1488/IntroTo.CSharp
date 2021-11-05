using NavigationMVVM.Commands;
using NavigationMVVM.Stores;
using System.Windows;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel(NavigationStore store)
        {
            MessageBox.Show("HomeVM");
            NavigateAccountCommand = new NavigateAccountCommand(store);
        }
        public string StartupText => "Хааай";
        public ICommand NavigateAccountCommand { get; }
    }
}
