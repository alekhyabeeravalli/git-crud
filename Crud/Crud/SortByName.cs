using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
    public class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return string.Compare(x.firstname, y.lastname);
        }
    }
}
    
    

