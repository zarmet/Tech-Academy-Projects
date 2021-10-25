using System;
using System.Collections.Generic;
using System.Text;

namespace GenericThings
{
    public class Employee <T>
    {
        public List<T> Things { get; set; }
    }
}
