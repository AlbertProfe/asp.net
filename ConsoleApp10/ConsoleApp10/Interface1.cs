using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    interface IEquatable<T>
    {
        bool Equals(T obj);
    }
}
