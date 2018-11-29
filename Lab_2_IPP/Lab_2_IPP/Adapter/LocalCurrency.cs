using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Adapter
{
    class LocalCurrency
    {
       public virtual void TransformCurrnecy(float change)
        {
            Console.WriteLine("Your ammount is changed");
        }
    }
}
