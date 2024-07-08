namespace Assignment
{
    enum WeekDays:byte
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }

    enum Season:byte 
    {
        Spring = 1, Summer ,Autumn , Winter
    }


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

            #endregion

            #region Q03
            /*Console.Write("Enter Season Name : ");
           Enum.TryParse(Console.ReadLine() , true , out Season season);
           if(season == (Season) 1 ) Console.WriteLine("March To May");

           else if (season == (Season) 2) Console.WriteLine("June To August");

           else if (season == (Season)3) Console.WriteLine("Septemper To November");

           else if (season == (Season)4) Console.WriteLine("December To February");

           else Console.WriteLine("Invalid Season Name");
           */
            #endregion
        }
    }
}
