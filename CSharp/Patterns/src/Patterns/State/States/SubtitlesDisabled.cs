using State.Models;
using State.States.Interfaces;

namespace State.States
{
    public class SubtitlesDisabled : SubtitlesState
    {
        public SubtitlesDisabled(PlayerViewModel context) : base(context) { }

        public override void Activate()
        {
            Context.Subtitles.Hide();
            Context.ToggleButton.Disabled();
            Context.SubtitlesState = new SubtitlesEnabled(Context);
        }
    }
}
