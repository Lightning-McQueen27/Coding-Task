using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    class Circle : ICircle
    {
        //свойство класса, куда будет сохраняться радиус
        //его не видно извне, работает только внутри класса
        private double _radius;

        public double Area()
        {
            return _radius * _radius * Math.PI;
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }
    }
}
