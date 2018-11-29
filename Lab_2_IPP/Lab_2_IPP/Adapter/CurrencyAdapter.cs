using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Adapter
{
    class CurrencyAdapter: 
    {
        private DolarChange dolarChange = new DolarChange();

        private EuroChange euroChange = new EuroChange();
        public virtual float ChangeCurrency()
        {
            
        }
    }
}
