using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceLib
{

    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        string GetBook(string Id);
    }
}
