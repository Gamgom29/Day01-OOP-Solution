using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        #region Attributes
        public int x;
        public int y;
        #endregion

        #region Constructor
        ///Is A Spacial Function For 2 Ressons
        ///1. Named Alawys With The Same Name of Its class or struct
        ///2. has no return

        public Point()
        {
            x = default; 
            y = default; 
        }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public Point(int Number)
        {
            x = y = Number;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"{x},{y}";
        }
        #endregion
    }
}