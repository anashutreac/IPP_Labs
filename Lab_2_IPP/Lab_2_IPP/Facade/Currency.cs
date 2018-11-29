using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Facade
{
    class Currency
    {
        private string currencyType;
        private double changeCost;

        public Currency(string currencyType, double changeCost)
        {
            this.currencyType = currencyType;
            this.changeCost = changeCost;
        }

        public void setType(string type)
        {
            currencyType = type;
        }

        public string getType()
        {
            return currencyType;
        }

        public double changeCurrency(double amount)
        {
            double rest;

            rest = amount * changeCost;

            return amount; 
        }
    }
}
