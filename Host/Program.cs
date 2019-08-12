using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DerivativesCalculatorService;
using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {

        static void Main(string[] args)
        {
            Type serviceType = typeof(Calculator);
            using (ServiceHost host = new ServiceHost(serviceType))
            {
                host.Open();
                Console.WriteLine("The derivatives calculator seervice is available.");
                Console.ReadLine();
            }
        }

    }
}
