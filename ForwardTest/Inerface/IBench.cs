using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardTest.Inerface
{
    internal interface IBench
    {
        int startBench();
    }

    internal interface IBenchICE_TempCrit : IBench
    {
        double getA(double m, int i);
        double Vh(double m, double Hm, double V, double Hv);
        double Vc(double C, double T, double tEng);
        double getM(double[] M, double[] V, double Vx);
    }
}
