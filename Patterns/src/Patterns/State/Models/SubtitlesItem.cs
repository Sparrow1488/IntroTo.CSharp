namespace State.Models
{
    public class SubtitlesItem
    {
        public bool IsVisiable { get; private set; } = false;
        public void Display()
        {
            IsVisiable = true;
        }

        public void Hide()
        {
            IsVisiable = false;
        }
    }
}
