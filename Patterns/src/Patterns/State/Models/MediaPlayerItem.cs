namespace State.Models
{
    public class MediaPlayerItem
    {
        public string PlayMode { get; private set; } = "Default";

        public void Play()
        {
            PlayMode = "Play";
        }

        public void Pause()
        {
            PlayMode = "Pause";
        }
    }
}
