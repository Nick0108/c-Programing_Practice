using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Ch12Ex01
{
    class Vector
    {
        public double? R = null;
        public double? Theta = null;
        public double? ThetaRadians
        {
            get { return (Theta * Math.PI / 180.0); }
        }
    }
}
