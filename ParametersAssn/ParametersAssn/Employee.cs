using System;
using System.Collections.Generic;
using System.Text;

namespace ParametersAssn
{
    //Declare class that takes generic type parameter
    public class Employee<T>
    {
        //Add property with generic list data type
        public List<T> Things;
    }
}
