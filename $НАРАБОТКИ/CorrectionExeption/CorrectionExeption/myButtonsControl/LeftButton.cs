using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CorrectionExeption.myButtonsControl
{
    class LeftButton : MyButtons
    {
        public override void PressButton(PictureBox obj, char btn)
        {
            Button = 'a';
            if (btn == Button)
            {
                int X = obj.Location.X;
                int Y = obj.Location.Y;
                X -= 10;
                obj.Location = new Point(X, Y);
                
            }
        }
    }
}
