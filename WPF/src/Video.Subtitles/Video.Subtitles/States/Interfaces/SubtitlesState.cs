using Video.Subtitles.ViewModels;

namespace Video.Subtitles.States.Interfaces
{
    public abstract class SubtitlesState
    {
        protected PlayerViewModel Context { get; set; }

        public SubtitlesState(PlayerViewModel context)
        {
            Context = context;
        }

        public abstract void Switch();
    }
}
