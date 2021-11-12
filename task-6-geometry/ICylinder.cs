using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    interface ICylinder
    {
        //нужно сделать класс на основе этого интерфейса

        public void SetRadius(double radius);

        public void SetHeight(double height);

        public double Volume();
    }
}
