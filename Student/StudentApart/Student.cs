using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StudentApart
{
    public enum Gender
    {
        Men = 1, 
        Women,
        Trans
    }
    public enum Study
    {
        Full=11,
        Part=12,
        Remote=13
    }
    public struct Student
    {
        public string fullName;
        public int group;
        public double ball;
        public double money;
        public Gender gender;
        public Study study;
    }
}
