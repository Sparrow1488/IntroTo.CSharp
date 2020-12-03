using System;
using System.Collections.Generic;
using System.Text;
using MyWorkTeamHW.Commands;

namespace MyWorkTeamHW.Commands
{
    class VisitShopCommand : Command
    {
        public override void MyCommand(string enterCommand)
        {
            myCommand = "visit shop";
            if (enterCommand == myCommand)
            {
                Console.WriteLine("");
            }
        }
    }
}
