using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Person
    {
        #region Properties
        public string Name { get; set; }
        public string Address { get; set; }
        #endregion

        #region Constructors
        public Person() { }
        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return (Name + " lives at " + Address);
        }
        #endregion
    }
}
