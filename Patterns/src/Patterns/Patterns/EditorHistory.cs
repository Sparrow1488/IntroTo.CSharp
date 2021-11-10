using System;
using System.Collections.Generic;

namespace Patterns
{
    /// <summary>
    /// Хранит историю изменений объектов (в данном случае документов)
    /// </summary>
    public class EditorHistory
    {
        public event Action<string> Changes;
        private Stack<DocumentMemento> History { get; set; }
        public EditorHistory()
        {
            History = new Stack<DocumentMemento>();
        }
        /// <summary>
        /// Добавлет в верх стека объект
        /// </summary>
        public void Push(DocumentMemento memento)
        {
            History.Push(memento);
            Changes?.Invoke(string.Format("Документ сохранен"));
        }
        /// <summary>
        /// Удаляет верхний объект в стеке
        /// </summary>
        public DocumentMemento Pop()
        {
            Changes?.Invoke(string.Format("Отмена последних действий"));
            return History.Pop();
        }
    }
}
