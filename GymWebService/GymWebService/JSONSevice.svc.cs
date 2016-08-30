using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace GymWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JSONSevice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JSONSevice.svc or JSONSevice.svc.cs at the Solution Explorer and start debugging.
    public class JSONSevice : IJSONSevice
    {
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "data/{id}")]
        public Person GetData(string id)
        {   
            // lookup person with the requested id 
            return new Person()
            {
                Id = Convert.ToInt32(id),
                Name = "Leo Messi"
            };
        }
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJSONSevice" in both code and config file together.
    [ServiceContract]
    public interface IJSONSevice
    {

        [OperationContract]
        Person GetData(string id);
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
