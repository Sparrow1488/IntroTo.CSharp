using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Video.Subtitles.Views
{
    public partial class VideoPlayer : UserControl
    {
        private List<Subtitles> _subtitlesCollection;
        private DispatcherTimer _timer;

        public VideoPlayer()
        {
            InitializeComponent();
            PlayerHandlePanel.MaxHeight = 0;
            Wrapper.MouseEnter += OnMouseEnter;
            Wrapper.MouseLeave += Player_MouseLeave;
            _subtitlesCollection = new List<Subtitles>
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

        private void Player_MouseLeave(object sender, MouseEventArgs e)
        {
            HidePlayerHandler();
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            DisplayPlayerHandler();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Player.Play();
            _timer = CreateTimer();
            _timer.Start();
        }

        private void DisplayPlayerHandler()
        {
            var animation = new DoubleAnimation(40, new Duration(new TimeSpan(0, 0, 0, 0, 250)));
            PlayerHandlePanel.BeginAnimation(MaxHeightProperty, animation);
        }

        private void HidePlayerHandler()
        {
            var animation = new DoubleAnimation(0, new Duration(new TimeSpan(0, 0, 0, 0, 250)));
            PlayerHandlePanel.BeginAnimation(MaxHeightProperty, animation);
        }

        private int _subCounter = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            var time = Player.Position;
            if (_subCounter < _subtitlesCollection.Count)
            {
                if (time > _subtitlesCollection[_subCounter].Position)
                {
                    SubtitlesText.Text = _subtitlesCollection[_subCounter].Text;
                    _subCounter++;
                }
            }
            else
            {
                SubtitlesText.Opacity = 0;
                _subCounter = 0;
                _timer.Stop();
            }
        }
        private DispatcherTimer CreateTimer()
        {
            var timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            return timer;
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            Player.Pause();
        }
    }
}
