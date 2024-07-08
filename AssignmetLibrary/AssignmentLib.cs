using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmetLibrary
{
    public enum WeekDays : byte
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }

    public enum Season : byte
    {
        Spring = 1, Summer, Autumn, Winter
    }

    [Flags]
    public enum Permission
    {
        Read = 1  , Write = 2  , Delete = 4 , Execute = 8
    }
    public struct Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            this.name = name;   
            this.age = age;
        }
        public override string ToString()
        {
            return $" Name : {name} \n Age: {age} ";
        }
    }

}
