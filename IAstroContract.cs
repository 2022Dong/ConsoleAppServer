using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppServer
{
    [ServiceContract]
    public interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double x, double y);

        [OperationContract]
        double StarDistance(double x);

        [OperationContract]
        double TemperatureConversion(double x);

        [OperationContract]
        double BlackholeEventHorizon(double x);
    }
}
