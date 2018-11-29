using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Flyweight
{
    class CardFactory
    {
        private Dictionary<string, Card> _cardType = new Dictionary<Card, string>();

        public Card GetCardType(string type)
        {
            Card cardType;
            cardType = _cardType[type];

            switch(cardType)
            {
                case "Credit": cardType = new CreditCard(); break;
                case "Debit": cardType = new DebitCard(); break;
                case "Premium": cardType = new PremiumCard(); break;

            }
            return cardType;
        }
        
    }

}
