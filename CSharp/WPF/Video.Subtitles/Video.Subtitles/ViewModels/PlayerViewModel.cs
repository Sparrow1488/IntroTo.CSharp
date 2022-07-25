using GalaSoft.MvvmLight.Messaging;
using System.Windows.Controls;
using System.Windows.Input;
using Video.Subtitles.Commands;
using Video.Subtitles.Services;
using Video.Subtitles.Services.Intefaces;
using Video.Subtitles.States;
using Video.Subtitles.States.Interfaces;
using Video.Subtitles.Views.CustomComponents;

namespace Video.Subtitles.ViewModels
{
    public class PlayerViewModel : ViewModelBase
    {
        public PlayerViewModel()
        {
            Messenger.Default.Register<MediaElement>(this, (p) => PlayerItem = p);
            Messenger.Default.Register<SubtitlesTextBlock>(this, (b) => _subtitlesBlock = b);

            SubtitlesService = new SubtitlesService();
            SubtitlesService.Open(Initializer.CreateTestSubtitles());
            SubtitlesService.OnChanged((subs) => SubtitlesText = subs);

            PlayerState = new PlayerPlayed(this);
            SubtitlesState = new SubtitlesHidden(this);
        }

        private SubtitlesTextBlock _subtitlesBlock = new SubtitlesTextBlock();
        private MediaElement _player;
        public ISubtitlesService SubtitlesService { get; private set; }
        private string _subtitlesText;

        public PlayerState PlayerState { get; set; }
        public SubtitlesState SubtitlesState { get; set; }
        public MediaElement PlayerItem
        {
            get => _player;
            set
            {
                _player = value;
                OnPropertyChanged(nameof(PlayerItem));
            }
        }
        public SubtitlesTextBlock SubtitlesItem
        {
            get => _subtitlesBlock;
            set
            {
                _subtitlesBlock = value;
                OnPropertyChanged(nameof(SubtitlesItem));
            }
        }
        public string SubtitlesText
        {
            get => _subtitlesText;
            set
            {
                OnPropertyChanged(nameof(SubtitlesText));
                _subtitlesText = value;
            }
        }


        public ICommand PlayerSwitchState => new EmptyCommand((obj) => PlayerState.Switch());
        public ICommand SubtitlesSwitchState => new EmptyCommand((obj) => SubtitlesState.Switch());
    }
}
