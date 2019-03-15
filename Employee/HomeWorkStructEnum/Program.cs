using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructEnum
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во сотрудников для добавления:");
            int size = Int32.Parse(Console.ReadLine());
            Employee[] employee = new Employee[size];
            int num;
            int sizeDate = 3;
            for(int i = 0; i< size; i++)
            {
                employee[i] = new Employee();
                Console.WriteLine("Введите имя сотрудника:");
                employee[i].name=Console.ReadLine();
                Console.WriteLine("Введите должность сотрудника\n1-Босс, 2-Менеджер, 3-Клерк, 4-Продажник:");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1: employee[i].vacancy = Vacancies.Boss; break;
                    case 2: employee[i].vacancy = Vacancies.Manager; break;
                    case 3: employee[i].vacancy = Vacancies.Clerk; break;
                    case 4: employee[i].vacancy = Vacancies.Salesman; break;
                }
                Console.WriteLine("Введите зп сотрудника:");
                employee[i].money = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите дату приема на работу сотрудника:");
                employee[i].date = new int[sizeDate];
                for (int j = 0; j < sizeDate; j++)
                {
                    employee[i].date[j] = Int32.Parse(Console.ReadLine());
                }
                

            }
            /*a.	вывести полную информацию обо всех сотрудниках;*/
            Console.WriteLine("Все сотрудники:");
            for (int i = 0; i < size; i++)  //a
            {
                Console.WriteLine(employee[i].name);
                Console.WriteLine(employee[i].vacancy);
                Console.WriteLine(employee[i].money);
                for (int j = 0; j < sizeDate; j++)
                {
                    Console.Write(employee[i].date[j] + ".");
                }
                Console.WriteLine();

            }
            Console.WriteLine("-----------");
            /*b.найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, 
            вывести на экран полную информацию о таких менеджерах отсортированной по их фамилии.
            */
            int moneyClerk = 0;
            int countClerk = 0;
            int indexBoss = 0;
            for (int i = 0; i < size; i++)  
            {
                if (employee[i].vacancy == Vacancies.Clerk)
                {
                    moneyClerk += employee[i].money;
                    countClerk++;
                }
                if (employee[i].vacancy == Vacancies.Boss)
                {
                    indexBoss = i;
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Менеджеры, чьи зп больше средней зп клерка:");
            for (int i = 0; i < size; i++)  
            {
                if (employee[i].vacancy == Vacancies.Manager && (employee[i].money >= moneyClerk / countClerk))
                {
                    Console.WriteLine(employee[i].name);
                    Console.WriteLine(employee[i].vacancy);
                    Console.WriteLine(employee[i].money);
                    for (int j = 0; j < sizeDate; j++)
                    {
                        Console.Write(employee[i].date[j] + ".");
                    }
                    Console.WriteLine();
                }
            }

            /*c.	распечатать информацию обо всех сотрудниках, принятых на работу позже босса, 
                    отсортированную в алфавитном порядке по фамилии сотрудника.*/
            Console.WriteLine("");
            Console.WriteLine("Работники, кто устроился позже босса:");
            int countDate = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < sizeDate; j++)
                {
                    if(employee[i].vacancy != Vacancies.Boss && (employee[i].date[j]>= employee[indexBoss].date[j]))
                    {
                        countDate++;
                    }
                }
                if(countDate == sizeDate)
                {
                    Console.WriteLine(employee[i].name);
                    Console.WriteLine(employee[i].vacancy);
                    Console.WriteLine(employee[i].money);
                    for (int j = 0; j < sizeDate; j++)
                    {
                        Console.Write(employee[i].date[j] + ".");
                    }
                    Console.WriteLine();
                }
                countDate = 0;
                
            }
            Console.ReadLine();
        }
    }
}
