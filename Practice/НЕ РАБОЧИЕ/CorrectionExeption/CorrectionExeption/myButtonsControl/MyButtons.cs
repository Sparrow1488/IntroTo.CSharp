using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorrectionExeption.myButtonsControl;

namespace CorrectionExeption
{
    public abstract class MyButtons
    {
        public static List<MyButtons> myButtons { get; private set; } = new List<MyButtons>()
        {
            new UpButton(),
            new LeftButton(),
            new DownButton(),
            new RightButton()
        };
        public char Button { get; protected set; }
        public int Speed { get; protected set; } = 8;
        public abstract void PressButton(PictureBox obj, char btn);
    }
}
