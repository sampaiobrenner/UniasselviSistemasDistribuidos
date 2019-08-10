using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Socket_Cliente
{
    public class FTCliente
    {
        public static string mensagemCliente = "em espera";

        public static void EnviarArquivo(string nomeArquivo)
        {
            try
            {
                string strEnderecoIP = "192.168.1.11";
                IPEndPoint ipEnd_cliente = new IPEndPoint(IPAddress.Parse(strEnderecoIP), 5656);
                Socket clientSock_cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string caminhoArquivo = "";
                nomeArquivo = nomeArquivo.Replace("\\", "/");

                while (nomeArquivo.IndexOf("/") > -1)
                {
                    caminhoArquivo += nomeArquivo.Substring(0, nomeArquivo.IndexOf("/") + 1);
                    nomeArquivo = nomeArquivo.Substring(nomeArquivo.IndexOf("/") + 1);
                }

                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(nomeArquivo);
                if (nomeArquivoByte.Length > 5000 * 1024)
                {
                    mensagemCliente = "O tamanho do arquivo é maior que 5Mb, tente um arquivo menor.";
                    return;
                }

                string caminhoCompleto = caminhoArquivo + nomeArquivo;

                byte[] fileData = File.ReadAllBytes(caminhoCompleto);
                byte[] clientData = new byte[4 + nomeArquivoByte.Length + fileData.Length];
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);

                nomeArquivoLen.CopyTo(clientData, 0);
                nomeArquivoByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + nomeArquivoByte.Length);
                clientSock_cliente.Connect(ipEnd_cliente);
                clientSock_cliente.Send(clientData, 0, clientData.Length, 0);
                clientSock_cliente.Close();
                mensagemCliente = "Arquivo [" + caminhoCompleto + "] transferido.";
            }
            catch (Exception ex)
            {
                mensagemCliente = ex.Message + " " + "\nFalha, pois o Servidor não esta atendendo....";
            }
        }
    }
}