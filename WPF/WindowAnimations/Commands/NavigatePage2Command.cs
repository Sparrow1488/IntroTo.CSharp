namespace WindowAnimations.Commands
{
    public class NavigatePage2Command : CommandBase
    {
        public NavigatePage2Command(NavigationService service)
        {
            _service = service;
        }
        public NavigationService _service;
        public override void Execute(object parameter)
        {
            _service.Navigate(new Page2());
        }
    }
}
