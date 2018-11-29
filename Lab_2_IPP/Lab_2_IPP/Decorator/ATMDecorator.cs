using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Decorator
{
    abstract class ATMDecorator: ATM
    {
        protected ATM atm;

        public void setATM(ATM atm)
        {
            this.atm = atm;
        }

        public override void Transaction()
        {
            if (atm != null)
            {
                atm.Transaction();
            }

            throw new NotImplementedException();
        }
    }
}
