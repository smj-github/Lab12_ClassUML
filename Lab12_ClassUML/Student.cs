using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Student: Person
    {
        #region Properties
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }
        #endregion

        #region Constructors
        public Student() { }
        public Student(string Name, string Address, string Program, int Year, double Fee):base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return (String.Format("{0} lives at {1}. \nHe/She is currently enrolled in the {2}, for the year {3}. \nThe fee for this program is ${4}", Name, Address, Program, Year, Fee));
        }
        #endregion
    }
}
