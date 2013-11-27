using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "timeService" in both code and config file together.
    public class timeService : ItimeService
    {
        public string DoWork()
        {
            string s = DateTime.Now.ToString();
            Console.WriteLine(s);

            return s;
        }
    }
}
