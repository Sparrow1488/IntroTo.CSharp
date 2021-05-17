using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    // Подробнее про паттерн: https://tproger.ru/articles/pattern-oop-hranitel/
    /// <summary>
    /// Хранит состояние объекта Document (контейтер-копия)
    /// </summary>
    public class DocumentMemento
    {
        public string Text { get; private set; } = string.Empty;
        public int Font { get; private set; } = 14;
        public DocumentMemento(string text, int fontSize)
        {
            Text = text;
            Font = fontSize;
        }
    }
}
