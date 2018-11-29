using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_IPP.Bridge
{
    abstract class DataObject
    {
            public abstract void NextRecord();
            public abstract void PriorRecord();
            public abstract void AddRecord(string name);
            public abstract void DeleteRecord(string name);
            public abstract void ShowRecord();
            public abstract void ShowAllRecords();
        }
}
