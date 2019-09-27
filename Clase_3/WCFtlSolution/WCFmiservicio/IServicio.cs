using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFmiservicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicio" in both code and config file together.
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        int GetSuma(int num1, int num2);
    }
}
