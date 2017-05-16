using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Diagnostics;

namespace webservis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        bool register(string username, double latitude, double longitude, string IPaddress, int port);

        [OperationContract]
        double distance(double lon1, double lon2, double lat1, double lat2);

        [OperationContract]
        userAddress searchNeighbour(string username);

        [OperationContract]
        bool storeMeasurement(string username, string parameter);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    /*[DataContract]
    public class sensorform
    {
        public string username, IPaddress;
        public double latitude, longitude;
        public int port;
    }

    [DataContract]
    public class userAddress
    {
        public double distance;
        public sensorform senzor;
    }*/
}
