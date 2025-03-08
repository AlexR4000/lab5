using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    using System;

    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException(double radius)
            : base($"Invalid radius {radius}: must be non-negative") // a prompt that will be printed out if radius is negative
        {
        }

        public InvalidRadiusException(double radius, double maxRadius)
            : base($"Invalid radius {radius}: must be between 0 and {maxRadius}") // a prompt that will be printed out if radius over max radius
        {
        }
    }
}
