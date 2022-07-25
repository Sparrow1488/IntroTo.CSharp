using System;

namespace Patterns
{
    public class Document
    {
        private string _text = string.Empty;
        private int _font = 14;
        public event Action<string> Changes;
        public void AddBlock(string textBlock)
        {
            _text = textBlock;
            Changes?.Invoke(string.Format("Добавлен новый блок текста: {0}", _text));
        }
        public void SetFontSize(int size)
        {
            if(size > 0)
            {
                _font = size;
            }
            Changes?.Invoke(string.Format("Установлен новый размер: {0}", _font));
        }
        public DocumentMemento SaveState()
        {
            Changes?.Invoke(string.Format("Сохраняем документ..."));
            return new DocumentMemento(_text, _font);
        }
        public void RestoreState(DocumentMemento memento)
        {
            _text = memento.Text;
            _font = memento.Font;
            Changes?.Invoke(string.Format("Данные восстановлены"));
        }
        public void Print()
        {
            Changes?.Invoke(string.Format("Текст: {0}\nРазмер шрифта: {1}", _text, _font));
        }
    }
}
