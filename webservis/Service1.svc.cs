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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public static List<sensorform> sensors = new List<sensorform>();
        public static List<string[]> table = new List<string[]>();


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        //Registrira nove senzore
        public bool register(string username, double latitude, double longitude, string IPaddress, int port)
        {
            Debug.WriteLine("Registered");
            if (!sensors.Any(item => item.username == username))
            {

                sensorform senzor = new sensorform();
                senzor.username = username;
                senzor.longitude = longitude;
                senzor.latitude = latitude;
                senzor.port = port;
                senzor.IPaddress = IPaddress;
                sensors.Add(senzor);

                printsensors();
                Debug.WriteLine("All sensors printed.");

                return true;

            }
            else return false;
        }

        //Vraća najbližeg susjeda: kompoziciju senzora i udaljenosti
        public userAddress searchNeighbour(string username)
        {
            userAddress returning = new userAddress();
            sensorform closest = new sensorform();
            double dist = 0;
            double minimalDistance = 1000000;

            foreach (sensorform senzor in sensors)
            {
                if (!(senzor.username == username))
                {
                    dist = distance(senzor.longitude, sensors.Find(item => item.username == username).longitude, senzor.latitude, sensors.Find(item => item.username == username).latitude);
                    Debug.WriteLine("Senzor " + senzor.username + ":" + dist);
                    if (dist < minimalDistance)
                    {
                        minimalDistance = dist;
                        closest = senzor;
                    }
                }
            }

            returning.distance = minimalDistance;
            returning.senzor = closest;
            Debug.WriteLine("Najbliži: " + returning.senzor.username + ":" + returning.distance);
            return returning;

        }

        //Vraća udaljenost između dvije točke
        public double distance(double lon1, double lon2, double lat1, double lat2)
        {
            double R = 6371;
            double dlon = lon2 - lon1;
            double dlat = lat2 - lat1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dlon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = R * c;
            return d;
        }

        //Funkcija koja printa sve senzore do sad
        private void printsensors()
        {
            foreach (sensorform first in sensors)
            {
                Debug.WriteLine(first.username + "; " + first.latitude + "; " + first.longitude + "; " + first.IPaddress + "; " + first.port);
            }
        }

        //Spremanje mjerenja i print mjerenja zadanog senzora
        public bool storeMeasurement(string username, string parameter)
        {
            string[] collection = new string[2];

            collection[0] = username;
            collection[1] = parameter;

            table.Add(collection);

            Debug.WriteLine("From this sensor we recieved this data:");
            foreach (string[] row in table)
            {
                if (row[0] == username)
                {
                    Debug.WriteLine(row[0]+":"+row[1]);
                }
            }
            return true;
        }
    }

}
