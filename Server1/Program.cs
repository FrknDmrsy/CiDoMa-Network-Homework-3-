using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9051);
            Socket newsock = new Socket(AddressFamily.InterNetwork,
            SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = sender;

            //Above, We create Udp Server on port 9051. This code taken from the book.
            while (true)
            {
                data = new byte[1024];
                recv = newsock.ReceiveFrom(data, ref Remote);

                string receiveData = Encoding.UTF8.GetString(data, 0, recv);

                Console.WriteLine(receiveData);

                if (receiveData.Contains("download")) //When "download" command taken, split the command and take argument.
                {
                    string[] splitedCommand = receiveData.Split(' ');

                    string filename = splitedCommand[1];
                    filename = filename.Replace("\"", "");
                    string offset = splitedCommand[2];
                    string chunksize = splitedCommand[3];

                    int _chunksize = int.Parse(chunksize);
                    int _offset = int.Parse(offset);
                    //when arguments assigned to variables, starts reading the file.
                    byte[] bytes = File.ReadAllBytes(filename);

                    newsock.SendTo(bytes.Skip(_offset).Take(_chunksize).ToList().ToArray(), _chunksize, SocketFlags.None, Remote);
                    //we skip redundant bytes and take bytes about chuncksize and sent this bytes
                }
                else if (receiveData.Contains("size")) // if a command including size, that means requesting size of file.
                {
                    string[] splitedCommand = receiveData.Split(' ');

                    string filename = splitedCommand[1];

                    filename= filename.Replace("\"", "");

                    byte[] bytes = File.ReadAllBytes(filename);

                    var size = Encoding.UTF8.GetBytes(bytes.Length.ToString());
                    //convert size data to text, after that converting to bytes for sending process.
                    newsock.SendTo(size, size.Length, SocketFlags.None, Remote);
                }
                else
                {
                    newsock.SendTo(data, recv, SocketFlags.None, Remote);
                }
            }
        }
    }
}
