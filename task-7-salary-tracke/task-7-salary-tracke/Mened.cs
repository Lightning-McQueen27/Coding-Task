using System;
using System.Collections.Generic;
using System.Text;

namespace task_7_salary_tracke
{
    class Class_maned : Interface_Mened
    {
        private double zp_baz;
        private double prib;


        public void SetZpbaz(double zpbaz)
        {
            zp_baz = zpbaz;
        }
        public void SetPrib(double prib_perem)
        {
            prib = prib_perem;
        }
        public double Volume()
        {
            return (zp_baz * zp_baz) * 0.25 * Math.Pow(10, -4) + prib * 0.5 * Math.Pow(10, -2);
        }
    }
}
