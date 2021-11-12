using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    class Sphere1 : ISphere
    {
        private double _radius;

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public double Volume()
        {
            return (4 * _radius * _radius * _radius * Math.PI) / 3;
        }
    }
}
