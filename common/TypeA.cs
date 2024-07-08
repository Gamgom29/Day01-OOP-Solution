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
    }

    // Code Contract Between the Developers
    public interface ICar
    {
        /// What You Cab Write Inside Interaface
        /// 1. Signature for Method 
        /// 2. Signature for Property
        /// 3. C# 8.0 Default Implemented Method [.Net Core 3.1]
        void Accelerate() { }

    }

    public class BMWCar : ICar
    { 
        public void Accelerate()
        {

        }
    }

    public enum Gender
    {
        Male, 
        Female
    }
}
