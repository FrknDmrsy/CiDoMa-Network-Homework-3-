using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CinsDownloadManager
{
    class DownloadHelper
    {
        IPEndPoint ipep;
        Socket server;
        IPEndPoint sender;
        EndPoint Remote;
        public DownloadHelper(int portnumber=9050)
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portnumber);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sender = new IPEndPoint(IPAddress.Any, 0);
            Remote = sender;
        }

        public byte[] GetChunk(string filename, int offset, int chunksize)
        {
            //We are sending download command-- to server with three arguments.
            //download "C:\CiDoMa\Music\m2.mp3" 347000 1000
            byte[] data = Encoding.UTF8.GetBytes("download \"" + filename + "\" " + offset + " "+ chunksize);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[chunksize];
            server.ReceiveFrom(data, ref Remote);

            return data;
        }
        // Getting from server the size of the file we want to download 
        public int GetSize(string filename)
        {
            byte[] data = Encoding.UTF8.GetBytes("size \"" + filename + "\"");
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            server.ReceiveFrom(data, ref Remote);
           
            string retval = Encoding.UTF8.GetString(data, 0, data.Length);

            return int.Parse(retval);
        }

        public void CloseConnection()  
        {
            server.Close();
            server.Dispose();
        }
    }
}
