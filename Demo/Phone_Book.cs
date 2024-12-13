using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Phone_Book
    {
        #region Attribute
        //string[]? names;
        //long[] numbers;
        //int size;
        #endregion

        #region Property
        //public int Size //Read only
        //{
        //    get { return size; }
        //}
        #endregion

        //Getter
        //public long GetNumber(string Name)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (Name == names[i])
        //                return numbers[i];
        //        }
        //    }
        //    return -1;
        //}

        //Setter
        //public void SetNumber(string Name, long NewNumber)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (Name == names[i])
        //                numbers[i] = NewNumber;
        //            break;
        //        }
        //    }
        //}

        //public string this[int index]
        //{
        //    get { return $"Postion:{index} , Name:{names[index]}, Number:{numbers[index]}"; }
        //}


        #region Indexer
        //public long this[string Name]
        //{
        //    get {
        //        if (names is not null && numbers is not null)
        //        {
        //            for (int i = 0; i < names.Length; i++)
        //            {
        //                if (Name == names[i])
        //                    return numbers[i];
        //            }
        //        }
        //        return -1;
        //    }
        //    set
        //    {
        //        if (names is not null && numbers is not null)
        //        {
        //            for (int i = 0; i < names.Length; i++)
        //            {
        //                if (Name == names[i])
        //                    numbers[i] = value;
        //                break;
        //            }
        //        }
        //    }
        //}

        #endregion

        #region Constructor
        //public Phone_Book(int _size)
        //{
        //    size = _size;
        //    names = new string[size];
        //    numbers = new long[size];
        //}
        #endregion

        #region Method
        //public void AddPerson(int Position, string Name, long Number)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        if (Position < size)
        //        {
        //            names[Position] = Name;
        //            numbers[Position] = Number;
        //        }

        //    }
        //}
        #endregion
    }
}