using State.States;
using State.States.Interfaces;
using System;

namespace State.Models
{
    public class PlayerViewModel
    {
        public PlayerViewModel(MediaPlayerItem player, SubtitlesItem subtitles, PlayButtonItem playBtn, SubtitlesToggleItem toggleBtn)
        {
            Player = player;
            Subtitles = subtitles;
            PlayButton = playBtn;
            ToggleButton = toggleBtn;

            PlayerState = new PlayerPaused(this);
            SubtitlesState = new SubtitlesEnabled(this);
        }

        public PlayerState PlayerState { get; set; }
        public SubtitlesState SubtitlesState { get; set; }
        public MediaPlayerItem Player { get; }
        public SubtitlesItem Subtitles { get; }
        public PlayButtonItem PlayButton { get; }
        public SubtitlesToggleItem ToggleButton { get; }


        // Для реализации паттерна MVVM используем реализации ICommand
        public void ActivatePlayer()
        {
            Log("Player activated");
            PlayerState.Activate();
        }

        public void ActivateSubtitles()
        {
            Log("Subtitles activated");
            SubtitlesState.Activate();
        }

        private void Log(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
