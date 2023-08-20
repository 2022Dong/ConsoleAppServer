using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace ConsoleAppServer
{
    public class AstroContract: IAstroContract
    {
        Formulas formulas = new Formulas();

        // Implmentations
        public double StarVelocity(double x, double y)
        {
            return formulas.StarVelocity(x, y);
        }

        public double StarDistance(double x)
        {
            return formulas.StarDistance(x);
        }

        public double TemperatureConversion(double x)
        {
            return formulas.TemperatureConversion(x);
        }

        public double BlackholeEventHorizon(double x)
        {
            return formulas.BlackholeEventHorizon(x);
        }
    }
}
