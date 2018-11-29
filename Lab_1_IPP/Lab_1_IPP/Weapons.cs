using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_IPP
{
    //Builder pattern

    class Shop
    {
        public void Construct(WeaponBuilder weaponBuilder)
        {
            weaponBuilder.BuildFrame();
        }
    }

    abstract class WeaponBuilder
    {
        protected Weapon weapon;

        public Weapon weapon
        {
            get { return weapon; }
        }

        public abstract void BuildFrame();
    }

    class CatapultBuilder : WeaponBuilder
    {

        public CatapultBuilder()
        {
            weapon = new Weapon("Catapult")
        }

        public override void BuildFrame()
        {
            weapon["frame"] = "Catapult Frame"
        }
    }

    class SwordsBuilder : WeaponBuilder
    {
        public SwordBuilder()
        {
            weapon = new Weapon("Sword")
        }

        public override void BuildFrame()
        {
            weapon["frame"] = "Sword Frame"
        }
    }

    class ArrowsBuilder : WeaponBuilder
    {
        public ArrowsBuilder()
        {
            weapon = new Weapon("Arrow")
        }

        public override void BuildFrame()
        {
            weapon["frame"] = "Arrow Frame"
        }
    }

    class Weapon
    {
        private string weaponType;
        private Dictionary<string, string> parts =
        new Dictionary<string, string>();

        public Weapon(string v)
        {
        }

        public (string weaponType)
    {
      this.weaponType = weaponType;
    }

    // Indexer

    public string this[string key]
    {
        get { return _parts[key]; }
        set { parts[key] = value; }
    }

    public void Show()
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine("weapon Type: {0}", weaponType);
        Console.WriteLine(" Frame : {0}", parts["frame"]);
    }
}
