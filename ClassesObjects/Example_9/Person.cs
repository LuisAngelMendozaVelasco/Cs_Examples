/*C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, 
and you only have to write get; and set; inside the property.*/

using System;

namespace MyApplication
{
    class Person
    {
        public string Name    // property
        {
            get; 
            set;
        }  
    }
}