using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;


namespace GymWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "index" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select index.svc or index.svc.cs at the Solution Explorer and start debugging.
    public class index : Iindex
    {
       [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "data/{Name}")]
        public string Getmessage(string Name)
        {
            return "Hello" + Name;
        }
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iindex" in both code and config file together.
    [ServiceContract]
    public interface Iindex
    {
        [OperationContract]
        string Getmessage(string Name);
    }
}
