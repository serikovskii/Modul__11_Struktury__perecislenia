using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emplBoss = new Employee()
            {
                Name = "Adam",
                Vacancy = Vacancies.Boss,
                Money = 9000,
                DateForWork = new int[] { 3, 2, 2019 }
            };
            Employee emplManager = new Employee()
            {
                Name = "Pit",
                Vacancy = Vacancies.Manager,
                Money = 1500,
                DateForWork = new int[] { 9, 2, 2019 }
            };
            Employee emplClerk = new Employee()
            {
                Name = "Tom",
                Vacancy = Vacancies.Clerk,
                Money = 800,
                DateForWork = new int[] { 15, 2, 2019 }
            };
        }
    }
}
