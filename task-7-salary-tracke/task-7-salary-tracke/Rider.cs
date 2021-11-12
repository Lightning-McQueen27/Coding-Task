using System;
using System.Collections.Generic;
using System.Text;

namespace task_7_salary_tracke
{
    class Class_rider : Interface_Rider
    {
        private double zp_baz;

        public double Area()
        {
            return zp_baz * 0.85;
        }

        public void SetZpbaz(double zpbaz)
        {
            zp_baz = zpbaz;
        }
    }
}
