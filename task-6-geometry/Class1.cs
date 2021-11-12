using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    class Cylinder1 : ICylinder
    {
        private double _radius;
        private double _height;


        public void SetRadius(double radius)
        {
            _radius = radius;
        }
        public void SetHeight(double height)
        {
            _height = height;
        }
        public double Volume()
        {
            return _height * _radius * _radius * Math.PI;
        }
    }
}
