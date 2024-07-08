using Common;
namespace Demo
{
    enum Grade : byte
    {
        A, B, C, D, E, F
    }
    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    [Flags]
    enum Permission : byte
    {
        Write = 1, Read = 2, Execute = 4, Delete = 8
    }

 /*   class Employee
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Permission permission { get; set; }
    }*/


    internal class Program
    {

        static void Main()
        {
            #region Access Modifiers [internal , public , private]
            //TypeA obj = new TypeA();
            //obj.x = 10 ; invalid ===>due its prodection level [x is private]  
            //obj.y = 1; invalid ==> as y is internal
            //obj.z = 20; valid ==> as z is public  
            #endregion

            #region Enum : Example01
           /* Grade G01 = Grade.A;
            if (G01 == Grade.A)
                Console.WriteLine(":)");
            else
                Console.WriteLine(":(");
            G01 = (Grade)4;
            Console.WriteLine(G01); //E*/
            #endregion

            #region Enum:Example02
            Console.WriteLine(" Enter Your Gender");
            Gender MyGender;
            #region Parse
            /* MyGender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine() ?? "");
             MyGender = Enum.Parse<Gender>(Console.ReadLine() ?? "", true);*/
            #endregion

            #region Try Parse
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object? obj);
            //MyGender = (Gender) obj;
            //Enum.TryParse/*<Gender>*/(Console.ReadLine() ?? "", true, out MyGender);

            #endregion


            //Console.WriteLine(MyGender);

            #endregion

            #region Enum-Permission Ex:03
            /*Employee employee = new Employee();
            employee.id = 101;
            employee.Name = "Gamgom";
            employee.Salary = 9_000;
            employee.permission = (Permission)15; // Write, Read, Execute, Delete


            Permission MyP = (Permission)3;
            Console.WriteLine(MyP);

            MyP = MyP | Permission.Execute; // Add Permission
            Console.WriteLine(MyP);

            MyP &= ~Permission.Read; // Delet Permission
            Console.WriteLine(MyP);

            MyP ^= Permission.Execute; // Toogle on Permission
            Console.WriteLine(MyP);*/
            #endregion

            #region Struct
            /*Point P1;
            ///Declare For Object Of Type Point
            ///CLR will Allocated 8 Unitilialized Bytes at Stack
            P1.x = 10;
            P1.y = 20;
            P1 = new Point(); // Default Constructor

            P1 = new Point(10, 20);
            Console.WriteLine(P1.ToString()); // ToString --> [Namespace.ClassName]*/

            #endregion

            #region Encapsulation
            /*Employee employee = new Employee(_id: 10, _Name: "Abdelrahman", _salary: 5_000);
            employee.Id = 20; // set id directy through the attribute
            Console.WriteLine(employee);
            employee.SetName("Gamgom"); //Set Name Using Setter Function
            Console.WriteLine(employee.GetName()); //Get Name Using Getter Function
            employee.Salary = 9_000; //Set Using Property
            Console.WriteLine(employee.Salary); //Get Using Property*/
            #endregion

            #region Encapsulation-indexer
            //Phone_Book Note = new Phone_Book(3);
            //Note.AddPerson(0, "Abdelrahman", 123);
            //Note.AddPerson(1, "Ahmed", 456);
            //Note.AddPerson(2, "Ali", 789);

            //Note.SetNumber("Abdelrahman", 999); // set using setter
            //Console.WriteLine(Note.GetNumber("Abdelrahman"); // get using getter
            //Note["Abdelrahman"] = 999;
            //Console.WriteLine(Note["Abdelrahman"]);
            //for (int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}
            #endregion
        }

    }
}