
using AssignmetLibrary;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            /* Console.WriteLine("Week Days :");
             for (int i = 1; i <= 7; i++)
             {
                 Console.WriteLine((WeekDays) i);
             }*/
            #endregion

            #region Q02
            /*  Person[] persons = new Person[3];
              persons[0] = new Person("Abdelrahman Gamgom" , 21);
              persons[1] = new Person("Ahmed Mohamed", 25);
              persons[2] = new Person("Ali", 20);

              for (int i = 0; i < persons.Length; i++) 
              {
                  Console.WriteLine($"Person {i+1} Informations");
                  Console.WriteLine(persons[i].ToString());
                  Console.WriteLine();
              }*/
            #endregion

            #region Q03
            /*Console.Write("Enter Season Name : ");
            Enum.TryParse(Console.ReadLine(), true, out Season season);
            if (season == Season.Spring) Console.WriteLine("March To May");

            else if (season == Season.Summer) Console.WriteLine("June To August");

            else if (season == Season.Autumn) Console.WriteLine("Septemper To November");

            else if (season == Season.Winter) Console.WriteLine("December To February");

            else Console.WriteLine("Invalid Season Name");*/

            #endregion

            #region Q04
            /*Permission MyPermission = (Permission) 0;

            MyPermission |= Permission.Write; // Add Write Permission
            MyPermission |= Permission.Read; // Add Read Permission
            Console.WriteLine(MyPermission);

            MyPermission &= ~Permission.Write; // Delete Write Permission
            Console.WriteLine(MyPermission);
            
            // check if permission exist
            if((MyPermission & Permission.Read) == Permission.Read) Console.WriteLine("Permission Exist");
            else Console.WriteLine("Permission dosen't Exist");
*/
            #endregion

            #region Q05
            /* Console.Write("Enter a color name :  ");
             Enum.TryParse(Console.ReadLine(), true, out Color color);
             if(color == Color.Red || color == Color.Blue || color == Color.Green) Console.WriteLine("Primary Color");
             else Console.WriteLine("Not Primary Color");*/
            #endregion

            #region Q06
            /*Point P1 = new Point(1, 2);
            Point P2 = new Point(7, 7);

            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine($"Enter Point {i+1}");
                Console.Write($"X{i+1}: ");
                int.TryParse(Console.ReadLine(), out int x);

                Console.Write($"Y{i + 1}: ");
                int.TryParse(Console.ReadLine(), out int y);

                if(i == 0)
                {
                    P1.X = x;
                    P1.Y = y;
                }
                else
                {
                    P2.X = x;
                    P2.Y = y;
                }
            }

            Console.Clear();
            float Distance = (float)Math.Sqrt(Math.Pow((P2.X - P1.X), 2) + Math.Pow((P2.Y - P1.Y), 2));
            Console.WriteLine($"The Distance Between P1 And P2 Is : {Distance}");*/
            #endregion

            #region Q07
            /*Person[] Persons = new Person[3];
            int idx = 0;
            int mx = -1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Data for Person {i+1}");
                Console.Write("Enter Person Name: ");
                string Name = Console.ReadLine() ?? "No Name";
                Console.Write("Enter Person Age: ");
                int.TryParse(Console.ReadLine(), out int Age);
                Console.WriteLine();
                Persons[i] = new Person(Name, Age);
                if (Persons[i].Age > mx) 
                {
                    idx = i;
                    mx = Persons[i].Age;
                }
            }
            Console.Clear();
            Console.WriteLine("The Data Of Oldest Person :");
            Console.WriteLine(Persons[idx].ToString());*/

            #endregion
        }
    }
}
