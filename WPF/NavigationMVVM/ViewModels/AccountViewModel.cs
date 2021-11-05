using NavigationMVVM.Commands;
using NavigationMVVM.Stores;
using System.Windows;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        public AccountViewModel(NavigationStore store)
        {
            MessageBox.Show("AccountVM");
            NavigateHomeCommand = new NavigateHomeCommand(store);
        }
        public ICommand NavigateHomeCommand { get; }
        public string StartupText => "ЭТА СТРАНИЧКА ДЛЯ КРУТЫХ!!!";
    }
}
