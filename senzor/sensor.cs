using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using senzor.ServiceReference1;
using System.Diagnostics;

namespace senzor
{
    public partial class sensor : Form
    {
        // Spajanje na webservis
        Service1Client web_servis = new Service1Client();

        //varijable
        private double longitude, latitude;
        private Socket TCPserver, TCPclient = null;
        private byte[] buffer = new byte[1024];
        private string[] inputdata = new string[101];
        private string username, xname, xdata;
        IPAddress bindAddress;
        int port;
        private DateTime creationMoment;

        //default
        public sensor()
        {
            InitializeComponent();
        }

        //Inicijalizacija
        protected override void OnCreateControl()
        {
            init();
            createSockets();
            creationMoment = DateTime.Now;

            readinputdata();
            //writeinputdata();
        }

        //početna inicijalizacija
        private void init()
        {
            latitude = RandomNumberBetween(45.75, 45.85);
            longitude = RandomNumberBetween(15.87, 16.0);
            creationMoment = DateTime.Now;

        }

        //Funkcija register - inicijalizira konekciju te šalje podatke serveru
        private void register(object sender, EventArgs e)
        {

            if ((username = usernametextbox.Text) != "")
            {
                if (web_servis.register(username, latitude, longitude, bindAddress.ToString(), port))
                {
                    Console.WriteLine("Succesfully registered");
                    setinfobox();
                }
                else MessageBox.Show("Sensor with the same username already exists");

            } else
            {
                MessageBox.Show("Please enter username.");
                return;
            }

        }

        //Stvaranje socketa i postavljanje spajanja - socket(), bind(), listen() metode
        void createSockets()
        {
            bindAddress = IPAddress.Loopback;
            IPEndPoint bindEndPoint = new IPEndPoint(bindAddress, 0);

            TCPserver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            TCPclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            TCPserver.Bind(new IPEndPoint(bindAddress, 0));
            TCPserver.Listen(50);
            port = ((IPEndPoint)TCPserver.LocalEndPoint).Port;
            TCPserver.BeginAccept(new AsyncCallback(Accept), null);
        }

        //Funkcija Accept()
        private void Accept(IAsyncResult AR)
        {
            //napravi novi socket koji dalje sluša
            Socket TCPserverNEW = TCPserver.EndAccept(AR);
            TCPserverNEW.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(Recieve), TCPserverNEW);
            TCPserver.BeginAccept(new AsyncCallback(Accept), null);
        }

        //Funkcija Read()
        private void Recieve(IAsyncResult AR)
        {
            Socket TCPread = (Socket)AR.AsyncState;
            int received = TCPread.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(buffer, dataBuf, received);
            string text = Encoding.ASCII.GetString(dataBuf);
            string resp = String.Empty;

            if (text.ToLower() != "get data")
            {
                resp = "Invalid Request!";
            }
            else
            {
                resp = mydata();
            }
            byte[] data = Encoding.ASCII.GetBytes(resp);

            TCPread.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(Send), TCPread);
            TCPread.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(Recieve), TCPread);
        }

        //Funkcija Write()
        private void Send(IAsyncResult AR)
        {
            Socket TCPwrite = (Socket)AR.AsyncState;
            TCPwrite.EndSend(AR);
        }

        //pronalazi mjerenja u tablici mjerenja
        private string mydata()
        {
            int seconds = (DateTime.Now - creationMoment).Seconds;
            int sequence = (seconds % 100) + 1;
            return inputdata[sequence];
        }

        //Namještanje vizualnog sadržaja nakon registracije serveru
        private void setinfobox()
        {
            registerbutton.Enabled = false;
            latitudetextbox.Text = latitude.ToString();
            longitudetextbox.Text = longitude.ToString();
            IPtextbox.Text = bindAddress.ToString();
            porttextbox.Text = ((IPEndPoint)TCPserver.LocalEndPoint).Port.ToString();
            usernametextbox.Enabled = false;
            latitudelabel.Enabled = true;
            longitudelabel.Enabled = true;
            IPlabel.Enabled = true;
            portlabel.Enabled = true;
            connectbox.Enabled = true;
            this.Text = username + " sensor";
        }

        //Button Find and collect data
        private void measuresend(object sender, EventArgs e)
        {
            userAddress first = web_servis.searchNeighbour(username);
            nexttextbox.Text = first.senzor.username + ": " + first.distance;
            xname = username;

            Connect(first.senzor.port, first.senzor);
            Talk(first.senzor);

        }

        //Komunikacija između dva senzora
        private void Talk(sensorform neighbour)
        {
            byte[] buffer = Encoding.ASCII.GetBytes("get data");
            TCPclient.Send(buffer);
            byte[] recieved = new byte[1024];

            int record = TCPclient.Receive(recieved);
            byte[] input = new byte[record];
            Array.Copy(recieved, input, record);
            string recievedData = Encoding.ASCII.GetString(input);

            string mergedData = mergeData(recievedData);

            outbox.Enabled = true;
            resultbox.Enabled = true;

            connectedto.Text = neighbour.username;

            
            xdata = mergedData;

            resultbox.Items.Clear();
            resultbox.Items.Add("Connected to: " + neighbour.username);
            resultbox.Items.Add("\t"+neighbour.username + " data: " + recievedData);
            resultbox.Items.Add("\tMerged data: " + mergedData);

        }

        //Spaja informacije, dobiva string, vraća string
        private string mergeData(string neighbourData)
        {
            string[] mine = new string[8];
            string[] your = new string[8];
            string[] our = new string[8];

            string mineData = mydata();
            mine = mineData.Split(',');
            your = neighbourData.Split(',');

            for (int i = 0; i < 6; i++)
            {
                if (mine[i] == "") our[i] = your[i];
                
                else if (your[i] == "") our[i] = mine[i];
                
                else our[i] = ((Int32.Parse(mine[i]) + Int32.Parse(your[i])) / 2).ToString();
                
            }

            string result = our[0];
            for (int i = 1 ; i < 6; i++)
            {
                result += ","+our[i];
            }
            return result;
        }

        //Connect dio socketa
        private void Connect(int port, sensorform neighbour)
        {
            while (!TCPclient.Connected)
            {
                try
                {
                    TCPclient.Connect(IPAddress.Loopback, port);
                }
                catch (SocketException)
                {
                    MessageBox.Show("Connecting unsuccessful.");
                    break;
                }
            }
        }

        //Button send to server
        public void store(object sender, EventArgs e)
        {
            web_servis.storeMeasurement(xname, xdata);
        }

        //Dobivanje random double broja
        private double RandomNumberBetween(double min, double max)
        {

            Random random = new Random();
            double randomNum = random.NextDouble();

            return min + (randomNum * (max - min));
        }
        
        //Učitavanje datoteke mjerenja.csv u matricu
        private void readinputdata()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Tijan Tomislav Radoš\Documents\Visual Studio 2015\Projects\senzor\mjerenja.csv"));
            int i = 0;

            while (!reader.EndOfStream)
            {
                
                var line = reader.ReadLine();

                inputdata[i] = line;
                i++;
            }
        }

        //Ispis matrice inputdata[i][j] - provjera unosa mjerenja
        /*private void writeinputdata()
        {
            for (int i = 0; i<101; i++)
            {
                for (int j = 0; j<6; j++)
                {
                    Console.Write(inputdata[i][j]);
                }
                Console.WriteLine();
            }
        }*/
    }

    
}
