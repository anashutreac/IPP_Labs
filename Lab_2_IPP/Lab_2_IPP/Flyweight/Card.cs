using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Flyweight
{
    abstract class Card
    {
        protected string cardType;
        protected string cardNumber;
        protected DateTime endDate;
        protected int CVV;

        public abstract void ShowCard(string cardHolder);
    }
}
