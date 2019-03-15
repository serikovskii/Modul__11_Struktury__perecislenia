using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApart
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new List<Student>
            {

                new Student
                {
                    fullName = "Alex",
                    ball = 4.9,
                    group = 2,
                    money = 500,
                    gender = Gender.Men,
                    study = Study.Full
                },
                new Student
                {
                    fullName = "Leo",
                    ball = 4.8,
                    group = 2,
                    money = 496,
                    gender = Gender.Men,
                    study = Study.Full
                },
                new Student
                {
                    fullName = "Mia",
                    ball = 4.7,
                    group = 2,
                    money = 966,
                    gender = Gender.Women,
                    study = Study.Part
                },
                new Student
                {
                    fullName = "Anne",
                    ball = 4.2,
                    group = 2,
                    money = 203,
                    gender = Gender.Women,
                    study = Study.Part
                },
                new Student
                {
                    fullName = "Oleg",
                    ball = 4.1,
                    group = 2,
                    money = 350,
                    gender = Gender.Trans,
                    study = Study.Full
                }
            };

            var sortedMoney = from s in st
                         orderby s.money
                         select s;
            int minMoney = 400;
            Console.WriteLine("Сорировка по сред доходу:");
            foreach (Student stud in sortedMoney)
            {
                if (stud.money <= minMoney)
                {
                    Console.WriteLine($"{stud.fullName}, {stud.money}, {stud.ball}");
                }
            }

            var sortedBall = from s in st
                              orderby s.ball descending
                             select s;
            Console.WriteLine("Сорировка по баллу:");
            foreach (Student stud in sortedBall)
            {
                if (stud.money >= minMoney)
                {
                    Console.WriteLine($"{stud.fullName}, {stud.money}, {stud.ball}");
                }
            }
        }
    }
}
