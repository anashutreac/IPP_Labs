using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Facade
{
    class Account
    {
            private String accountNo;
            private String personName;
            private String personID;
            private double cardBalance;

            public Account()
            {

            }

            public Account(String accountNo, String personName, String personID, double cardBalance)
            {
                this.accountNo = accountNo;
                this.personName = personName;
                this.personID = personID;
                this.cardBalance = cardBalance;
            }

            public String getAccountName()
            {
                return personName;
            }

            public String getAccountNo()
            {
                return accountNo;
            }

            public String getPersonID()
            {
                return personID;
            }

            public double getCardBalance()
            {
                return cardBalance;
            }

            public void setCardBalance(double amount)
            {
                cardBalance = amount;
            }
        }
    }
