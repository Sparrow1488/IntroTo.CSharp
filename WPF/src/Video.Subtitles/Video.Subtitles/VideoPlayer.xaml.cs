using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Video.Subtitles
{
    public partial class VideoPlayer : UserControl
    {
        public VideoPlayer()
        {
            InitializeComponent();
            Wrapper.MouseEnter += OnMouseEnter;
            Wrapper.MouseLeave += Player_MouseLeave; ;
        }

        private void Player_MouseLeave(object sender, MouseEventArgs e)
        {
            PlayerHandlePanel.Opacity = 0;
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            PlayerHandlePanel.Opacity = 1;
        }
    }
}
