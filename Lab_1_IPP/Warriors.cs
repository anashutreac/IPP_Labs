using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_IPP
{
    //Abstract factory pattern
    abstract class Infatryman
    {
        public override void info();
    }

    abstract class Archer
    {
        public override void info();
    }

    abstract class Horseman
    {
        public override void info();
    }

    class RomanInfantryman : Infatryman
    {
        public override void info()
        {
            Console.WriteLine();
        }
    }

    class RomanArcher : Archer
    {
        public override void info()
        {
            Console.WriteLine();
        }
    }

    class RomanHorseman : Horseman
    {
        public override void info()
        {
            Console.WriteLine();
        }
    }

    class CarthaginianInfantryman : Infatryman
    {
        public override void info()
        {
            Console.WriteLine();
        }
    }

    class CarthaginianArcher : Archer
    {
        public override void info()
        {
            Console.WriteLine();
        }
    }

    class CarthaginianHorseman : Horseman
    {
        public override void info()
        {
            Console.WriteLine();
        }
    }

    abstract class ArmyFactory
    {
        public override Infatryman();
        public override Archer();
        public override Horseman();
    }

    class RomanArmyFactory : ArmyFactory
    {
        public override Infatryman()
        {
            return new RomanInfantryman;
        }

        public override Archer()
        {
            return new RomanArcher;
        }

        public override Horseman()
        {
            return new RomanHorseman;
        }
    }

    class CarthaginianArmyFactory : ArmyFactory
    {
        public override Infatryman()
        {
            return new CarthaginianInfatryman;
        }

        public override Archer()
        {
            return new CarthaginianArcher;
        }

        public override Horseman()
        {
            return new CarthaginianHorseman;
        }
    }

    class Army
    {
        List<Infatryman>  = new List<Infatryman>();
    List<Archer> = new List<Archer>();
    List<Horseman> = new List<Horseman>();
}

    class Game
    {
        public override Army createArmy(ArmyFactory)
        {

        }
    }

}
