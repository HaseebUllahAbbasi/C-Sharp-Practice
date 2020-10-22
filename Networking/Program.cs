using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Networking
{
    class Program
    {
        static void Main(string[] args)
        {

            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            IPAddress ip_address = IPAddress.Any;

            IPEndPoint ip_endpoint = new IPEndPoint(ip_address,23000);

            socket.Bind(ip_endpoint);



            socket.Listen(5);

            Console.WriteLine("about to accept the client");
            
            Socket client =  socket.Accept();

            Console.WriteLine("CLient connected " +client.ToString()+" ip end point "+ip_endpoint.ToString()+" ip address is  "+ip_address.ToString());

            byte[] buffer = new byte[128];
            int number_of_rec_bytes = 0;

            while (true)
            {
                number_of_rec_bytes = client.Receive(buffer);

                Console.WriteLine("no of bytes " + number_of_rec_bytes);

                Console.WriteLine("data sent by client " + buffer.ToString());

                String recievedText = Encoding.ASCII.GetString(buffer, 0, number_of_rec_bytes);
                Console.WriteLine("recieved text is " + recievedText);

                client.Send(buffer);

                if(recievedText=="x")
                {
                    break;
                }
                Array.Clear(buffer,0,buffer.Length);
                number_of_rec_bytes = 0;

            }
        }
    }
}
