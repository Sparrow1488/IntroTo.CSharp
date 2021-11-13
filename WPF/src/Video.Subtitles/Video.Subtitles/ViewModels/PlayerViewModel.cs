using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using Video.Subtitles.Commands;
using Video.Subtitles.Services;
using Video.Subtitles.Services.Intefaces;

namespace Video.Subtitles.ViewModels
{
    public class PlayerViewModel : ViewModelBase
    {
        public PlayerViewModel()
        {
            Messenger.Default.Register<MediaElement>(this, InitPlayer);

            _subtitlesService = new SubtitlesService();
            _subtitlesService.Open(CreateTestSubtitles());
            _subtitlesService.OnChanged((subs) => SubtitlesText = subs);
        }

        
        private Subtitles _subtitles;
        private MediaElement _player;
        private ISubtitlesService _subtitlesService;
        private string _subtitlesText;
        private bool isPlay = false;
        

        public string SubtitlesText
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_subtitlesText))
                {
                    _subtitlesText = "";
                }
                return _subtitlesText;
            }
            set
            {
                OnPropertyChanged(nameof(SubtitlesText));
                _subtitlesText = value;
            }
        }
        public Subtitles Subtitles
        {
            get => _subtitles;
            set
            {
                OnPropertyChanged(nameof(Subtitles));
                _subtitles = value;
            }
        }
        public MediaElement Player
        {
            get => _player;
            set
            {
                _player = value;
                OnPropertyChanged(nameof(Player));
            }
        }


        public ICommand PlayerActivate
        {
            get => new PlayerActivate((obj) =>
            {
                if (!isPlay)
                {
                    isPlay = true;
                    PlayVideo();
                }
                else
                {
                    isPlay = false;
                    PauseVideo();
                }
            });
        }

        private void InitPlayer(MediaElement player)
        {
            if (player == null)
                throw new NullReferenceException("WPF Media Player Element not initialized! Register property to manipulate from player manager");
            Player = player;
        }

        private List<Subtitles> CreateTestSubtitles()
        {
            return new List<Subtitles>
            {
                new Subtitles{ Text = "Добрый день дамусы и настрадамусы" , Position = new TimeSpan(0, 0, 0) },
                new Subtitles{ Text = "Поговорим сегодня про способы решения уравнений с диференциалами" , Position = new TimeSpan(0, 0, 2) },
                new Subtitles{ Text = "А также затронем тему теорией вероятности" , Position = new TimeSpan(0, 0, 4) },
                new Subtitles{ Text = "s4" , Position = new TimeSpan(0, 0, 6) },
                new Subtitles{ Text = "s5" , Position = new TimeSpan(0, 0, 8) },
                new Subtitles{ Text = "s6" , Position = new TimeSpan(0, 0, 12) },
            };
        }

        private void PlayVideo()
        {
            Player.Play();
            _subtitlesService.Start();
        }

        private void PauseVideo()
        {
            Player.Pause();
            _subtitlesService.Pause();
        }

        private void DisplayPlayerHandler()
        {
            var animation = new DoubleAnimation(40, new Duration(new TimeSpan(0, 0, 0, 0, 250)));
            //PlayerHandlePanel.BeginAnimation(FrameworkElement.MaxHeightProperty, animation);
        }

        private void HidePlayerHandler()
        {
            var animation = new DoubleAnimation(0, new Duration(new TimeSpan(0, 0, 0, 0, 250)));
            //PlayerHandlePanel.BeginAnimation(FrameworkElement.MaxHeightProperty, animation);
        }

        
    }
}
