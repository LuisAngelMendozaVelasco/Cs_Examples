/*The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.
The get method returns the value of the variable name.
The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.*/

using System;

namespace MyApplication
{
    class Person
    {
        private string name;  // field

        public string Name    // property
        {
            get{return name;}
            set{name = value;}
        }  
    }
}