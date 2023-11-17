using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastYearsInClass
{
    public enum deals
    {
        All,
        Top,
        Best
    }

    public enum Category
    {
        Baby,
        Electronic,
        Device, 
        Books
    }
    public abstract class Department
    {

        public string Title;
        public string Description;
        public int Price;
        public Category Category;
        public int CategoryId;
        public deals dealType;
        public int DealId;
    }
}
