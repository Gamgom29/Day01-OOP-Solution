using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// What You Can Write inside the Namespace
    /// 1. Class
    /// 2. Struct [stands for datastructure]
    /// 3. Interface
    /// 4. Enum
    /// </summary>

    /// Allowed Access Modifires inside namespace
    /// 1. internal [Default Access modifier]
    /// 2. Public
    
    
    public class TypeA
    {
        /// Wha you can write inside the class or struct
        /// 1. Attributes [fields] Member Variables
        /// 2. Properties [Full , Automatic , indexer] 
        /// 3. Functions [Constructor , Getter Setter , Method]
        /// 4. Events
        /// 

        /// Allowed Access Modifires inside the struct
        /// 1. private
        /// 2. internal
        /// 3. public

        /// Allowed Access Modifires inside the class
        /// 1. private
        /// 2. private protected
        /// 3. protected
        /// 4. internal
        /// 5. internal protected
        /// 6. public

        /// Default Access Modifier inside class or struct is Private

        /*private*/ int X;
        internal int Y;
        public int Z;

        public void pirnt()
        {
            Console.WriteLine(X);
        }
    }

    // Code Contract Between the Developers
    public interface ICar
    {
        /// What You Cab Write Inside Interaface
        /// 1. Signature for Method 
        /// 2. Signature for Property
        /// 3. C# 8.0 Default Implemented Method [.Net Core 3.1]

        /// Allowed Access Modifires inside the interface
        /// 1. private protected
        /// 2. protected
        /// 3. internal
        /// 4. internal protected
        /// 5. public
        
        // public is default accesss modifier inside the interface
        void Accelerate() { }

    }

    public class BMWCar : ICar
    { 
        public void Accelerate()
        {

        }
    }

/*    public enum Gender
    {
        Male = 1, 
        Female = 2
    }
*/
   /* public class Employee
    {
        private protected int Id;
        private protected string? Name;
    }
    public class FullTimeEmployee : Employee
    {
        private int Id;
        private string? Name;
        private decimal? Salary;
    }
    public class PartTimeEmployee : Employee
    {
        private int Id;
        private string? Name;
        private decimal? HourRate;
    }*/

}
