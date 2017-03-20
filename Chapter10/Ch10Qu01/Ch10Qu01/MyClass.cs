using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Qu01
{
    public class MyClass
    {
        #region Fields
        protected string myString;
        #endregion
        #region Properties
        public string ContainedString
        {
            set { myString = value; }
        }
        #endregion
        #region Methods
        public virtual string GetString()
        {
            return myString;
        } 
        #endregion
        #region Constructor
        #endregion
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            //string newString = "(output from derived class)" + myString;
            //return newString;
            return base.GetString() + "(output from derived class)";
        }
    }
}
