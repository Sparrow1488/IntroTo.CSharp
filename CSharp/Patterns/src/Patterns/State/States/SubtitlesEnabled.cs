using State.Models;
using State.States.Interfaces;

namespace State.States
{
    public class SubtitlesEnabled : SubtitlesState
    {
        public SubtitlesEnabled(PlayerViewModel context) : base(context) { }

        public override void Activate()
        {
            Context.Subtitles.Display();
            Context.ToggleButton.Enable();
            Context.SubtitlesState = new SubtitlesDisabled(Context);
        }
    }
}
