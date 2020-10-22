using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Networking
{
    class SocketClientStarter
    {
        public static void Main(String[] args)
        {
            Socket client = null;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ip_adddress = null;
            try
            {
                Console.WriteLine("Welcome totstarter ");

                Console.WriteLine("Pease type valid IP adress");
                String string_ip = Console.ReadLine();

                Console.WriteLine("please provide the valid port number ");
                string string_port_number = Console.ReadLine();

                int port_input = 0;
                if(!IPAddress.TryParse(string_ip,out ip_adddress))
                {
                    Console.WriteLine("invalid port number");
                    return;
                }
                if (!int.TryParse(string_port_number.Trim(), out port_input))
                {
                    Console.WriteLine("invalid port number");
                    return;
                }
                if(port_input<=0 || port_input>65535)
                {
                    Console.WriteLine("Port number must be between 0 to 65535");
                    return;
                }

                Console.WriteLine(("IP address : "+ip_adddress.ToString()+" and port number : "+ port_input.ToString()));

                client.Connect(ip_adddress,port_input);

                Console.WriteLine("the connection is created");

                String message = "";
                
                while(true)
                {
                    message = Console.ReadLine();
                    if (message.Equals("exit"))
                        break;
                    byte[] bufferSend = Encoding.ASCII.GetBytes(message);

                    client.Send(bufferSend);

                    byte[] buffer_rec = new byte[128];
                    int num_recieved =   client.Receive(buffer_rec);

                    Console.WriteLine("data recieved "+Encoding.ASCII.GetString(buffer_rec,0,num_recieved));
                 }
            } 
            catch (Exception exp)
            {

                Console.WriteLine(exp.ToString());

            }
            finally
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                client.Dispose();
            }

            Console.WriteLine("please  enter to exit");
            Console.ReadKey();  
        }

    }
}
