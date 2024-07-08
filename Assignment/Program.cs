
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
        }
    }
}
