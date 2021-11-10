using System.Windows.Controls;
using System.Windows.Input;
using WindowAnimations.Commands;

namespace WindowAnimations.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            _navigationService = new NavigationService();
            _navigationService.CurrentPageChanged += OnCurrentPageChanged;

            NavigateOnePage = new NavigatePage1Command(_navigationService);
            NavigateTwoPage = new NavigatePage2Command(_navigationService);
        }
        public Page CurrentPage
        {
            get => _navigationService.CurrentPage;
        }
        private void OnCurrentPageChanged()
        {
            OnPropertyChanged(nameof(CurrentPage));
        }
        private NavigationService _navigationService;
        public ICommand NavigateOnePage { get; set; }
        public ICommand NavigateTwoPage { get; set; }
    }
}
