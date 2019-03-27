using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructEnum
{
    public enum Vacancies
    {
        Boss = 1,
        Manager = 2,
        Clerk = 3,
        Salesman = 4
    }
    public struct Employee
    {
        public string name;
        public Vacancies vacancy;
        public int money;
        public int[] date;
        
    }
    
}
