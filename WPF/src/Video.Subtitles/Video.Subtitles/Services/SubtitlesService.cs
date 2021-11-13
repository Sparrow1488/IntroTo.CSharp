using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Threading;
using Video.Subtitles.Services.Intefaces;

namespace Video.Subtitles.Services
{
    public class SubtitlesService : ISubtitlesService
    {
        public SubtitlesService()
        {
            _timer = CreateTimer();

        }

        private DispatcherTimer _timer;
        private DispatcherTimer _displayTimer;
        private IList<Subtitles> _easySubtitles;
        private TimeSpan _timerInterval = new TimeSpan(0, 0, 0, 0, 50);
        private TimeSpan _maxDisplayTime = new TimeSpan(0, 0, 3);
        private TimeSpan _currentTime = new TimeSpan();
        private delegate void OnSubtitlesChanged(string subs);
        private event OnSubtitlesChanged OnSubtitlesChangedEvent;
        private int _currentIndex;

        public void OnChanged(Action<string> handler)
        {
            var func = new OnSubtitlesChanged(handler);
            OnSubtitlesChangedEvent += func;
        }

        public void Open(IEnumerable<Subtitles> subtitles)
        {
            if (subtitles == null)
                throw new NullReferenceException($"Can't open forwarded subtitles {nameof(subtitles)} becuse Null");
            if (subtitles is IList<Subtitles> current)
                _easySubtitles = current;
            else _easySubtitles = new List<Subtitles>(_easySubtitles);
            _easySubtitles.Add(new Subtitles() { Position = _easySubtitles[_easySubtitles.Count - 1].Position + new TimeSpan(0, 0, 3) });
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Pause()
        {
            _timer.Stop();
        }

        public void Reset()
        {

        }

        public TimeSpan GetCurrentTime()
        {
            return _currentTime;
        }

        public void SetTime(TimeSpan syncTime)
        {
            _currentTime = syncTime;
            // TODO: CORRECT TEST
            var syncedSubsIndex = _easySubtitles.Where(sub => sub.Position > syncTime).FirstOrDefault();
            if (syncedSubsIndex != null)
            {
                var syncedIndex = _easySubtitles.IndexOf(syncedSubsIndex);
                if (syncedIndex == -1)
                    throw new Exception("Can't synced subtitles");
                else _currentIndex = syncedIndex;
            }
        }

        private DispatcherTimer CreateTimer()
        {
            var timer = new DispatcherTimer();
            timer.Tick += TimerChanger_Tick;
            timer.Interval = _timerInterval;
            return timer;
        }

        private DispatcherTimer InitDisplayTimer(DispatcherTimer timer)
        {
            timer.Interval = _maxDisplayTime;
            timer.Tick += DisplayTimer_Tick;
            return timer;
        }

        private void TimerChanger_Tick(object sender, EventArgs e)
        {
            _currentTime = new TimeSpan(_currentTime.Ticks + _timerInterval.Ticks);
            if (_currentIndex >= _easySubtitles.Count) 
                return;

            var currentSubtitle = _easySubtitles[_currentIndex];
            Subtitles nextSubtitle = null;
            var nextIndex = _currentIndex + 1;
            if (nextIndex < _easySubtitles.Count)
                nextSubtitle = _easySubtitles[nextIndex];
            else InitDisplayTimer(CreateTimer()).Start();

            if (currentSubtitle.Position <= _currentTime && _currentTime <= nextSubtitle?.Position)
            {
                OnSubtitlesChangedEvent?.Invoke(currentSubtitle.Text);
                _currentIndex++;
            }
        }

        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            OnSubtitlesChangedEvent?.Invoke(string.Empty);
        }
    }
}
