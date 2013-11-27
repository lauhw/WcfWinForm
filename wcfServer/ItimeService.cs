using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ItimeService" in both code and config file together.
    [ServiceContract]
    public interface ItimeService
    {
        [OperationContract]
        string DoWork();
    }
}
