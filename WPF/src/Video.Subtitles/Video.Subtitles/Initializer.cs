using System;
using System.Collections.Generic;

namespace Video.Subtitles
{
    public static class Initializer
    {
        public static List<Subtitles> CreateTestSubtitles()
        {
            return new List<Subtitles>
            {
                new Subtitles{ Text = "Ну привет" , Position = new TimeSpan(0, 0, 0) },
                new Subtitles{ Text = "Это тестовые субтитры, которые используются в эксперементальной библиотеке Video.Subtitles" , Position = new TimeSpan(0, 0, 5) },
                new Subtitles{ Text = "Абсолютно не важно какое ты решил воспроизвести видео, так как они лягут поверх видеодорожки" , Position = new TimeSpan(0, 0, 9) },
                new Subtitles{ Text = "Вы спросите: \"А на кой вообще нам нужен еще один плеер? Их итак безкрайнее множество\"" , Position = new TimeSpan(0, 0, 14) },
                new Subtitles{ Text = "Однако учтите, что для использования в рамках фреймворка WPF существует не так много подобных решений" , Position = new TimeSpan(0, 0, 18) },
                new Subtitles{ Text = "Поэтому примите это как данность :)" , Position = new TimeSpan(0, 0, 22) },
                new Subtitles{ Text = "Так вот, я это к тому, что можете просто использовать этот жирный пользовательский контрол в своих проектах" , Position = new TimeSpan(0, 0, 25) },
                new Subtitles{ Text = "Бесплатно" , Position = new TimeSpan(0, 0, 29) },
            };
        }
    }
}
