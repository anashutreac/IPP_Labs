using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_IPP
{


    public abstract class MonsterPrototype
    {
        int m_health;
        int m_life;
        double m_money;

        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }

        public int Life
        {
            get { return m_life; }
            set { m_life = value; }
        }

        public double Money
        {
            get { return m_money; }
            set { m_money = value; }
        }


        public abstract MonsterPrototype Clone { get; }

        public abstract void info();
    }

    public class Druid : MonsterPrototype
    {
        public override MonsterPrototype Clone
        {
            get
            {
                return new this.MemberwiseClone() as Druid;
            }
        }

        public override void info()
        {
            throw new NotImplementedException();
        }
    }

    class Ogre : MonsterPrototype
    {
        public override MonsterPrototype Clone
        {
            get
            {
                retrun new this.MemberwiseClone() as Ogre;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void info()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Goblin : MonsterPrototype
    {
        public override MonsterPrototype Clone
        {
            get
            {
                retrun new this.MemberwiseClone() as Goblin;
            }
        }

        public override void info()
        {
            throw new NotImplementedException();
        }
    }

    class PrototypeFactory
    {
        public override MonsterPrototype createDruid()
        {
            Druid prototype;
            return prototype.clone();
        }
        public override MonsterPrototype createOgre()
        {
             Ogre prototype;
            return prototype.clone();
        }
        public override MonsterPrototype createGoblin()
        {
            Goblin prototype;
            return prototype.clone();
        }
    }

}
