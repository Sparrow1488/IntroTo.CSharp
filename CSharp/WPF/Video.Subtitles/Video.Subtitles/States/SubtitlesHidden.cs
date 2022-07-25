using Video.Subtitles.States.Interfaces;
using Video.Subtitles.ViewModels;

namespace Video.Subtitles.States
{
    public class SubtitlesHidden : SubtitlesState
    {
        public SubtitlesHidden(PlayerViewModel context) : base(context) { }

        public override void Switch()
        {
            Context.SubtitlesItem.Hide();
            Context.SubtitlesState = new SubtitlesVisiable(Context);
        }
    }
}
