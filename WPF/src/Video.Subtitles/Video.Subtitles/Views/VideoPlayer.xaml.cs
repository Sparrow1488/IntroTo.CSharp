using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Video.Subtitles.Views
{
    public partial class VideoPlayer : UserControl
    {
        private string _subtitlesText;
        private List<Subtitles> _subtitlesCollection;
        private DispatcherTimer _timer;

        public VideoPlayer()
        {
            InitializeComponent();
            PlayerHandlePanel.MaxHeight = 0;
            Wrapper.MouseEnter += OnMouseEnter;
            Wrapper.MouseLeave += Player_MouseLeave;
            SubtitlesText.Opacity = 0;
            _subtitlesCollection = new List<Subtitles>
            {
                new Subtitles{ Text = "Добрый день дамусы и настрадамусы" , Position = new TimeSpan(0, 0, 1) },
                new Subtitles{ Text = "Поговорим сегодня про способы решения уравнений с диференциалами" , Position = new TimeSpan(0, 0, 3) },
                new Subtitles{ Text = "А также затронем тему теорией вероятности" , Position = new TimeSpan(0, 0, 5) },
                new Subtitles{ Text = "s4" , Position = new TimeSpan(0, 0, 8) },
                new Subtitles{ Text = "s5" , Position = new TimeSpan(0, 0, 10) },
            };
        }

        private void Player_MouseLeave(object sender, MouseEventArgs e)
        {
            PlayerHandlePanel.MaxHeight = 0;
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            PlayerHandlePanel.MaxHeight = 40;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Player.Play();
            SubtitlesText.Opacity = 1;
            _timer = CreateTimer();
            _timer.Start();
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
