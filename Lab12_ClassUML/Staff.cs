using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Staff:Person
    {
        #region Properties
        public string School { get; set; }
        public double Pay { get; set; }
        #endregion

        #region Constructors
        public Staff() { }
        public Staff(string Name, string Address, string School, double Pay) : base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return (String.Format("{0} lives at {1}. \nHe/She is currently teaches at {2}. \nThe pay for this position is ${3}", Name, Address, School, Pay));
        }
        #endregion
    }
}
