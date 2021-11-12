using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using Video.Subtitles.Commands;
using Video.Subtitles.Views.CustomComponents;

namespace Video.Subtitles.ViewModels
{
    public class PlayerViewModel : ViewModelBase
    {
        public PlayerViewModel()
        {
            Messenger.Default.Register<MediaElement>(this, InitPlayer);

            _subtitlesCollection = CreateTestSubtitles();
        }

        private DispatcherTimer _timer;
        private List<Subtitles> _subtitlesCollection;
        private Subtitles _subtitles;
        private MediaElement _player;
        private string _subtitlesText;
        private bool isPlay = false;
        

        public string SubtitlesText
        {
            get
            {
                if (_subtitlesText == null)
                    return "No Subtitles";
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
                    _timer.Start();
                    //MainPlayButton.Visibility = Visibility.Hidden;
                }
                else
                {
                    isPlay = false;
                    //MainPlayButton.Visibility = Visibility.Visible;
                    _timer.Stop();
                    Player.Pause();
                }
            });
        }

        private int _subCounter = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            var time = Player.Position;
            if (_subCounter < _subtitlesCollection.Count)
            {
                if (time > _subtitlesCollection[_subCounter].Position)
                {
                    SubtitlesText = _subtitlesCollection[_subCounter].Text;
                    _subCounter++;
                }
            }
            else
            {
                _subCounter = 0;
                _timer.Stop();
            }
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
                new Subtitles{ Text = "Добрый день дамусы и настрадамусы" , Position = new TimeSpan(0, 0, 1) },
                new Subtitles{ Text = "Поговорим сегодня про способы решения уравнений с диференциалами" , Position = new TimeSpan(0, 0, 3) },
                new Subtitles{ Text = "А также затронем тему теорией вероятности" , Position = new TimeSpan(0, 0, 5) },
                new Subtitles{ Text = "s4" , Position = new TimeSpan(0, 0, 8) },
                new Subtitles{ Text = "s5" , Position = new TimeSpan(0, 0, 10) },
                new Subtitles{ Text = "Вообще то есть еще субтитры, получайте!" , Position = new TimeSpan(0, 0, 12) },
                new Subtitles{ Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut turpis diam, commodo at varius at, efficitur eget erat." , Position = new TimeSpan(0, 0, 14) },
                new Subtitles{ Text = "Cras vehicula suscipit erat, non mollis ante semper vitae." , Position = new TimeSpan(0, 0, 16) },
            };
        }

        private DispatcherTimer CreateTimer()
        {
            var timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            return timer;
        }

        private void PlayVideo()
        {
            Player.Play();
            _timer = CreateTimer();
            _timer.Start();
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
