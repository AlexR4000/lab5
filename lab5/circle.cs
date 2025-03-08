using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Circle
    {
        // constants
        private double radius;
        private const double MAX_RADIUS = 20; // defines what is the max radius

        //constructor
        public Circle(double newRadius)
        {
            if (newRadius < 0)
            {
                throw new InvalidRadiusException(newRadius); // ensures no negative radius
            }
            else if (newRadius > MAX_RADIUS)
            {
                throw new InvalidRadiusException(newRadius, MAX_RADIUS); // ensures no over max radius
            }
            else
            {
                radius = newRadius; // no errors keeps the new radius
            }
        }

        // method
        public override string ToString()
        {
            return $"Circle[radius={radius}]";
        }
    }

}
