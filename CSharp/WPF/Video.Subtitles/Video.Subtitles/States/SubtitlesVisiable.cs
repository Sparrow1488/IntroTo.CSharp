using Video.Subtitles.States.Interfaces;
using Video.Subtitles.ViewModels;

namespace Video.Subtitles.States
{
    public class SubtitlesVisiable : SubtitlesState
    {
        public SubtitlesVisiable(PlayerViewModel context) : base(context) { }

        public override void Switch()
        {
            Context.SubtitlesItem.Display();
            Context.SubtitlesState = new SubtitlesHidden(Context);
        }
    }
}
