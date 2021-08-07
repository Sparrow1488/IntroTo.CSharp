namespace WindowAnimations.Commands
{
    public class NavigatePage1Command : CommandBase
    {
        public NavigatePage1Command(NavigationService service)
        {
            _service = service;
        }
        private readonly  NavigationService _service;
        public override void Execute(object parameter)
        {
            _service.Navigate(new Page1());
        }
    }
}
