using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Qu05
{
    public class ShortList<T> : IList<T>
    {
        public List<T> AListTest = new List<T>();
        T innnerAListNum = default(10);
        public ShortList<T>() : IEnumerable<T>{}
    }
}
