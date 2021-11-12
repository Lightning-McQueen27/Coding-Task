using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    interface ICircle
    {
        //метод для записи радиуса
        public void SetRadius(double radius);

        //метод для получения площади
        public double Area();
    }
}