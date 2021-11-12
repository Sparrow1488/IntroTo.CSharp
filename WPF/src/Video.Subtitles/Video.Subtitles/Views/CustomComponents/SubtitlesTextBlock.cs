using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Video.Subtitles.Views.CustomComponents
{
    public class SubtitlesTextBlock : TextBlock
    {
        public SubtitlesTextBlock()
        {
            Background = new SolidColorBrush(Colors.Black);
            Foreground = new SolidColorBrush(Colors.White);
            Opacity = 0.7;
            TextAlignment = TextAlignment.Center;
            TextWrapping = TextWrapping.Wrap;
            FontSize = 20;
            Text = "No Subtitles";
        }
    }
}
