using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB() 
        {
            TypeA obj = new TypeA();

            //obj.X = 10 ; invalid due its protection X is private
            obj.Y = 20; // valid as Y is internal 
            obj.Z = 30; // valid as Z is Public

        }
    }
}
