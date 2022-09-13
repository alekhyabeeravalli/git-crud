using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
    public  class SortById:IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.id > y.id)
            {
                return 1;

            }
            else if (x.id < y.id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

    
    

