using System;
using System.Collections.Generic;

namespace Prototype
{
    public class GovernPanel
    {
        public int Id { get; set; }
        public GovernPanel(List<UiComponent> components)
        {
            Components = components;
        }
        public List<UiComponent> Components { get; } = new List<UiComponent>();
        public void Display()
        {
            Console.WriteLine($"[id:{Id}] Отображаю панель с {Components.Count} компонентами");
        }
        /// <summary>
        /// Копирует только значимые типы
        /// </summary>
        public virtual GovernPanel ShallowClone()
        {
            return (GovernPanel) this.MemberwiseClone();
        }
        /// <summary>
        /// Копирует все свойства и поля; Инициализирует новый объект
        /// </summary>
        public virtual GovernPanel DeepClone()
        {
            var comps = new List<UiComponent>(Components);
            return new GovernPanel(comps);
        }
    }
}
