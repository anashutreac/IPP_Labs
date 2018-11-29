using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Facade
{
    class Bank {

        private string bankName;
        private string centralLocation;

        public Bank()
        {

        }

        public string getBank()
        {
            return bankName;
        }

        public void setBank(string name)
        {
            bankName = name;
        }
    }
}
