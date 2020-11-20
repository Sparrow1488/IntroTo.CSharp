using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrectExeption1.Buttons.ControlsButtons
{
    class UpButton : ButtonsPress
    {
        public override void Press(TextBox pb, int go)
        {
            int X = pb.Location.X;
            int Y = pb.Location.Y;
            X += go;
            pb.Location = new Point(X, Y);
        }
    }
}
