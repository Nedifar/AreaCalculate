using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculateLibrary.Exceptions
{
    public class RectangleException : Exception
    {
        public RectangleException(string message)
            : base(message) { }
    }
}
