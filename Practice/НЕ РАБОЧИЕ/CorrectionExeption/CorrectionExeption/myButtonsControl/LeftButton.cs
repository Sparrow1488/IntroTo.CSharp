﻿using System;
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
            if (btn.Equals(Button))
            {
                int x = obj.Location.X;
                int y = obj.Location.Y;
                x -= Speed;
                obj.Location = new Point(x, y);
                
            }
        }
    }
}
