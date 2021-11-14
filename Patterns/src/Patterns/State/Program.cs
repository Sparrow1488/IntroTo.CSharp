using State.Models;
using System;

namespace State
{
    public class Program
    {
        // Main как представление в WPF (MVVM)
        public static void Main()
        {
            var player = new MediaPlayerItem();
            var subtitles = new SubtitlesItem();
            var playBtn = new PlayButtonItem();
            var toggleBtn = new SubtitlesToggleItem();

            var vm = new PlayerViewModel(player, subtitles, playBtn, toggleBtn);
            vm.ActivatePlayer();                // Command="{Binding ActivatePlayer}"
            ShowStateInfos(vm);

            vm.ActivateSubtitles();            // Command="{Binding ActivateSubtitles}"
            ShowStateInfos(vm);

            vm.ActivatePlayer();
            ShowStateInfos(vm);
        }

        private static void ShowStateInfos(PlayerViewModel vm)
        {
            Console.WriteLine("Player mode: " + vm.Player.PlayMode);
            Console.WriteLine("Play button mode: " + vm.PlayButton.Image);
            Console.WriteLine("Subtitles is visiable: " + vm.Subtitles.IsVisiable);
            Console.WriteLine("Toggle checked mode: " + vm.ToggleButton.SubtitlesMode);
            Console.WriteLine();
        }
    }
}
