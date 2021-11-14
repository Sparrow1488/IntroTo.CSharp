namespace State.Models
{
    public class SubtitlesToggleItem
    {
        public string SubtitlesMode { get; private set; } = "Unchecked";
        public void Enable()
        {
            SubtitlesMode = "Checked";
        }

        public void Disabled()
        {
            SubtitlesMode = "Unchecked";
        }
    }
}
