using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardTest.Inerface
{
    internal interface IEngine
    {
    }

    interface IEngineICE : IEngine
    {
        int I { get; }
        double[] M { get; }
        double[] V { get; }
        int tCrit { get;}
        double Hm { get;}
        double Hv { get;}
        double C { get;}
    }
    interface IEngineElectric : IEngine
    {}
}
