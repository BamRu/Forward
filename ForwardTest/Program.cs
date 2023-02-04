using ForwardTest.Inerface;
using ForwardTest.Bench;
using ForwardTest.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace ForwardTest
{
    class ForwardTest
    {
        public static void Main()
        {

            double[] m = { 20, 75, 100, 105, 75, 0 };
            double[] v = { 0, 75, 150, 200, 250, 300 };

            IEngineICE engine = new EngineICE(10, m, v, 110,  0.01,  0.0001,  0.1);

            Console.Write("Temp ambience: ");
            string input = Console.ReadLine();
            
            try
            {
                int tempAmb = Int32.Parse(input);
                IBenchICE_TempCrit benchTest = new BenchICE(engine, tempAmb);
                Console.WriteLine("Run time in seconds: " + benchTest.startBench());

            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }

            
        }

    }
}