using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    interface ISphere
    {
        //метод для записи радиуса
        public void SetRadius(double radius);

        //метод для получения объёма
        public double Volume();
    }
}
