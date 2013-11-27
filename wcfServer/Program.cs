using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace wcfServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ServiceHost host = new ServiceHost(typeof(timeService)))
                {
                    // you may add service end point at run time.
                    //host.AddServiceEndpoint(typeof(ItimeService),
                    //    //new NetNamedPipeBinding(),
                    //                        new NetTcpBinding(),
                    //                        "Service1");

                    host.Open();

                    Console.WriteLine("Time Service is available. " +
                                      "Press <ENTER> to exit.");
                    Console.ReadLine();

                    host.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.ReadLine();
            }

        }
    }
}
