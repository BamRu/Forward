using ForwardTest.Inerface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardTest.Engine
{
    internal class EngineICE : IEngineICE
    {
        public int I { get; set; }
        public double[] M { get; set; }
        public double[] V { get; set; }
        public int tCrit { get; set; }
        public double Hm { get; set; }
        public double Hv { get; set; }
        public double C { get; set; }

        public EngineICE(int i, double[] m, double [] v, int tCrit, double hm, double hv, double c)
        {
            I = i;
            M = m;
            V = v;
            this.tCrit = tCrit;
            Hm = hm;
            Hv = hv;
            C = c;
        }
 
    }
}
