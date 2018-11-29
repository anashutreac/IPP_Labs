using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Flyweight
{
    class DebitCard: Card
    {
       public DebitCard()
        {
            this.cardType = "Debit";
            this.CVV = 789;
            this.cardNumber = "5874585612548754";

        }

        public override void ShowCard(string cardHolder)
        {
        }
    }
}
