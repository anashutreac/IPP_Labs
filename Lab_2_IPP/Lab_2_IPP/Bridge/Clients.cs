using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Bridge
{
    class Clients : ClientBase
    {
        public Clients(string group): base(group)
        {
        }

        public override void ShowAll()
        {
            // Add separator lines

            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
