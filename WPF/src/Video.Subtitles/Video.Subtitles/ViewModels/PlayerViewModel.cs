namespace Video.Subtitles.ViewModels
{
    public class PlayerViewModel : ViewModelBase
    {
        private string _subtitlesText;
        public string SubtitlesText
        {
            get => _subtitlesText;
            set {
                OnPropertyChanged(nameof(SubtitlesText));
                _subtitlesText = value; 
            }
        }



    }
}
