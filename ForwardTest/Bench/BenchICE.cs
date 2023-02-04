using ForwardTest.Engine;
using ForwardTest.Inerface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ForwardTest.Bench
{
    internal class BenchICE : IBenchICE_TempCrit
    {
        public IEngineICE engine;
        public int tick;
        public int T;


        public BenchICE(IEngineICE engine,int t)
        {
            this.engine = engine;
            T = t;
        }


        public int startBench()
        {
            tick = 0;
            double Vcrank = 0;
            double tEng = T;
            while (engine.tCrit > tEng)
            {
                double Mdin = getM(engine.M, engine.V, Vcrank);
                double a = getA(Mdin, engine.I);
                double Vhot = Vh(Mdin, engine.Hm, Vcrank, engine.Hv);
                double Vcold = Vc(engine.C, T, tEng);
                tEng = tEng + Vhot + Vcold;
                Vcrank = Vcrank + a;
                         
                tick++;
                if (tick > 31536000)
                {
                    Console.WriteLine("The engine runs for a year without overheating!");
                    break;
                }
                    
            }
            return tick;
        }

        public double getA(double m, int i)
        {
            return m / i;
        }

        public double Vh(double m, double Hm, double V, double Hv)
        {
            return m * Hm + V * V * Hv;
        }

        public double Vc(double C, double T, double tEng)
        {
            return C * (T - tEng);

        }

        public double getM(double[] M,double[] V, double Vx) //линейная интерполяция
        {
            for (int i = 1; i <= M.Length; i++)
            {
                if (Vx < V[i])
                {
                    if (V[i] - V[i - 1] == 0)
                    {
                        return (M[i] + M[i - 1] / 2);
                    }
                    return M[i-1] + (M[i] - M[i - 1]) / (V[i] - V[i - 1]) * (Vx - V[i - 1]);
                }
            }
            return 0;

        }
        
    }
}
