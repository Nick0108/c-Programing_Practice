using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Qu04
{
    public class MyCopyableClass
    {
        //public string testing { get; set; }
        private string testing = "This is the default";
        public string testingProp
        {
            get { return testing; }
            set
            {
                testing = value;
            }
        }
        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)MemberwiseClone();
        }
    }
}
