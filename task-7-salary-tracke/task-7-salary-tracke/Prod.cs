using System;
using System.Collections.Generic;
using System.Text;

namespace task_7_salary_tracke
{
    class Class_prodavez : Interface_Prod
    {
        private double zp_baz;

        public double Area()
        {
            return zp_baz;
        }

        public void SetZpbaz(double zpbaz)
        {
            zp_baz = zpbaz;
        }
    }
}
