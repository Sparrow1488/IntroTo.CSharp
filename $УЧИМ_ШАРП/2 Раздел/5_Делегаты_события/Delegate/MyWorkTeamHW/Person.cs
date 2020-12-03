using System;

namespace MyWorkTeamHW
{
    public class Person
    {
        public event Action GoWork;
        public event Action GoSleep;
        public event Action GoEatDinner;

        public void ControlPerson(string command)
        {
            if(command == "work")
            {
                GoWork?.Invoke();
            }
            if (command == "sleep")
            {
                GoSleep?.Invoke();
            }
            if (command == "eat")
            {
                GoEatDinner?.Invoke();
            }
        }
    }
}
