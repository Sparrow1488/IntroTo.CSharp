using System;
using System.ComponentModel.DataAnnotations;

namespace Event
{
    public class Person
    {
        public event Action GoToSleep;
        public event EventHandler GoWork;

        public string Name;
        public void ControlPerson(DateTime time)
        {
            if(time.Hour < 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                GoWork?.Invoke(this, null); //в конструктор передаем объект и ....
            }
        }
    }
}
