// A C# program for Client

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public class Program
    {
        // Main Method
        private static void Main(string[] args)
        {
            ExecuteClient();
        }

        // ExecuteClient() Method
        private static void ExecuteClient()
        {
            try
            {
                // Establish the remote endpoint
                // for the socket. This example
                // uses port 11111 on the local
                // computer.
                var ipHost = Dns.GetHostEntry(Dns.GetHostName());
                var ipAddr = ipHost.AddressList[0];
                var localEndPoint = new IPEndPoint(ipAddr, 11111);

                // Creation TCP/IP Socket using
                // Socket Class Costructor
                var sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    // Connect Socket to the remote
                    // endpoint using method Connect()
                    sender.Connect(localEndPoint);

                    // We print EndPoint information
                    // that we are connected
                    Console.WriteLine("Socket connected to -> {0} ", sender.RemoteEndPoint);

                    // Creation of messagge that
                    // we will send to Server
                    var messageSent = Encoding.UTF8.GetBytes("Test Client<EOF>");
                    var byteSent = sender.Send(messageSent);

                    // Data buffer
                    var messageReceived = new byte[1024];

                    // We receive the messagge using
                    // the method Receive(). This
                    // method returns number of bytes
                    // received, that we'll use to
                    // convert them to string
                    var byteRecv = sender.Receive(messageReceived);
                    Console.WriteLine("Message from Server -> {0}", Encoding.UTF8.GetString(messageReceived, 0, byteRecv));

                    // Close Socket using
                    // the method Close()
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }

                // Manage of Socket's Exceptions
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane);
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}