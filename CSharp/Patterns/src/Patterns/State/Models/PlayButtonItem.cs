namespace State.Models
{
    public class PlayButtonItem
    {
        public string Image { get; set; } = string.Empty;
        public void SetPlayImage()
        {
            Image = "Played";
        }

        public void SetPauseImage()
        {
            Image = "Paused";
        }
    }
}
