using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_IPP
{
    abstract class Plebs
    {
        public override void info();
        public override void info();
    }

    class Farmer : Plebs
    {
        public override void info()
        {
            Console.WriteLine();
        }
    }

    class Blacksmith : Plebs
    {
        public override void info()
        {
            Console.WriteLine();
        }
    }

    class Merchant : Plebs
    {
        public override void info()
        {
            Console.WriteLine();
        }
    }

    abstract class PlebsFactory
    {
        public Plebs createPlebs();
    }

    class FarmersFactory : PlebsFactory
    {
        public Plebs createPlebs()
        {
            return new Farmer;
        }
    }

    class BlacksmithsFactory : PlebsFactory
    {
        public Plebs createPlebs()
        {
            return new Blacksmith;
        }
    }

    class MerchantsFactory : PlebsFactory
    {
        public Plebs createPlebs()
        {
            return new Merchant;
        }
    }

}
