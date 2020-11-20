using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CorrectionExeption
{
    class DownButton : MyButtons
    {
        public override void PressButton(PictureBox obj, char btn)
        {
            
            Button = 's';
            if (btn == Button)
            {
                int X = obj.Location.X;
                int Y = obj.Location.Y;
                Y += 10;
                obj.Location = new Point(X, Y);
                
            }
        }
    }
}
