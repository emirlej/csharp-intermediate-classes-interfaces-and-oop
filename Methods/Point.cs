using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;
            
        // Initializer
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Method in class
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            // Handle a null input
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            // Runs the method above, less boilerplate
            Move(newLocation.X, newLocation.Y);
        }

    }
}
