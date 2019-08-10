using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientView
{
    public class ClientHelper
    {
        public string EnviarDadosAoServidor(string mensagem) => ExecuteClient(mensagem);

        private string ExecuteClient(string mensagem)
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
                    var messageSent = Encoding.UTF8.GetBytes($"{mensagem}<EOF>");
                    var byteSent = sender.Send(messageSent);

                    // Data buffer
                    var messageReceived = new byte[1024];

                    // We receive the messagge using
                    // the method Receive(). This
                    // method returns number of bytes
                    // received, that we'll use to
                    // convert them to string
                    var byteRecv = sender.Receive(messageReceived);
                    var retorno = Encoding.UTF8.GetString(messageReceived, 0, byteRecv);

                    // Close Socket using
                    // the method Close()
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                    return retorno;
                }

                // Manage of Socket's Exceptions
                catch (ArgumentNullException ane)
                {
                    return $"ArgumentNullException : {ane}";
                }
                catch (SocketException se)
                {
                    return $"SocketException : {se}";
                }
                catch (Exception e)
                {
                    return $"Unexpected exception : {e}";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}