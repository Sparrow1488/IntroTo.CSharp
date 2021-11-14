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
using Video.Subtitles.States;
using Video.Subtitles.States.Interfaces;
using Video.Subtitles.Views.CustomComponents;

namespace Video.Subtitles.ViewModels
{
    public class PlayerViewModel : ViewModelBase
    {
        public PlayerViewModel()
        {
            Messenger.Default.Register<MediaElement>(this, InitPlayer);
            Messenger.Default.Register<SubtitlesTextBlock>(this, InitSubtitlesBlock);

            _subtitlesService = new SubtitlesService();
            _subtitlesService.Open(CreateTestSubtitles());
            _subtitlesService.OnChanged((subs) => SubtitlesText = subs);

            PlayerState = new PlayerPaused(this);
            SubtitlesState = new SubtitlesVisiable(this);
        }

        private SubtitlesTextBlock _subtitlesBlock = new SubtitlesTextBlock();
        private MediaElement _player;
        private ISubtitlesService _subtitlesService;
        private string _subtitlesText;

        public PlayerState PlayerState { get; set; }
        public SubtitlesState SubtitlesState { get; set; }
        public string SubtitlesText
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_subtitlesText))
                {
                    _subtitlesText = "";
                    HideSubtitles();
                }
                else ShowSubtitles();
                return _subtitlesText;
            }
            set
            {
                OnPropertyChanged(nameof(SubtitlesText));
                _subtitlesText = value;
            }
        }
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

        public ICommand PlayerSwitchState
        {
            get => new EmptyCommand((obj) => PlayerState.Switch());
        }

        public ICommand SubtitlesSwitchState
        {
            get => new EmptyCommand((obj) => SubtitlesState.Switch());
        }

        private void InitPlayer(MediaElement player)
        {
            if (player == null)
                throw new NullReferenceException("WPF Media Player Element not initialized! Register property to manipulate from player manager");
            PlayerItem = player;
            PlayerItem.MediaEnded += Player_MediaEnded;
        }

        private void InitSubtitlesBlock(SubtitlesTextBlock block)
        {
            if (block == null)
                throw new NullReferenceException("WPF Subtitles TextBlock Element not initialized! Register property to manipulate from player manager");
            _subtitlesBlock = block;
        }

        private void Player_MediaEnded(object sender, RoutedEventArgs e)
        {
            PlayerItem.Position = new TimeSpan();
            PlayerItem.Play();
        }

        

        private List<Subtitles> CreateTestSubtitles()
        {
            return new List<Subtitles>
            {
                new Subtitles{ Text = "Ну привет" , Position = new TimeSpan(0, 0, 0) },
                new Subtitles{ Text = "Это тестовые субтитры, которые используются в эксперементальной библиотеке Video.Subtitles" , Position = new TimeSpan(0, 0, 5) },
                new Subtitles{ Text = "Абсолютно не важно какое ты решил воспроизвести видео, так как они лягут поверх видеодорожки" , Position = new TimeSpan(0, 0, 9) },
                new Subtitles{ Text = "Вы спросите: \"А на кой вообще нам нужен еще один плеер? Их итак безкрайнее множество\"" , Position = new TimeSpan(0, 0, 14) },
                new Subtitles{ Text = "Однако учтите, что для использования в рамках фреймворка WPF существует не так много подобных решений" , Position = new TimeSpan(0, 0, 18) },
                new Subtitles{ Text = "Поэтому примите это как данность :)" , Position = new TimeSpan(0, 0, 22) },
                new Subtitles{ Text = "Так вот, я это к тому, что можете просто использовать этот жирный пользовательский контрол в своих проектах" , Position = new TimeSpan(0, 0, 25) },
                new Subtitles{ Text = "Бесплатно" , Position = new TimeSpan(0, 0, 29) },
                
            };
        }

        private void PlayVideo()
        {
            PlayerItem.Play();
            PlayerItem.MediaOpened += SynchronizeDisplaySubtitles;
        }

        private void SynchronizeDisplaySubtitles(object sender, RoutedEventArgs e)
        {
            _subtitlesService.Start();
        }

        private void PauseVideo()
        {
            PlayerItem.Pause();
            _subtitlesService.Pause();
        }

        private void HideSubtitles()
        {
            _subtitlesBlock.Visibility = Visibility.Hidden;
        }

        private void ShowSubtitles()
        {
            _subtitlesBlock.Visibility = Visibility.Visible;
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
