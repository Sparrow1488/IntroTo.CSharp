using System;
using System.Collections.Generic;

namespace Video.Subtitles.Services.Intefaces
{
    public interface ISubtitlesService
    {
        void Open(IEnumerable<Subtitles> subtitles);
        void Start();
        void Pause();
        void Reset();
        void OnChanged(Action<string> handler);
        TimeSpan GetCurrentTime();
        void SetTime(TimeSpan syncTime);
    }
}
