using HPSocketCS;
using SocketData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServerConsole
{
    class Program
    {
        static public TcpPullServer<MsgInfo> tcpPullServer = null;
        static void Main(string[] args)
        {
            tcpPullServer = new TcpPullServer<MsgInfo>();
            tcpPullServer.OnAccept += TcpPullServer_OnAccept;
            tcpPullServer.OnHandShake += TcpPullServer_OnHandShake;
            tcpPullServer.OnReceive += TcpPullServer_OnReceive;
            tcpPullServer.OnClose += TcpPullServer_OnClose;
            tcpPullServer.Port = (ushort)8992;
            tcpPullServer.KeepAliveTime = 0;
            tcpPullServer.KeepAliveInterval = 0;
            tcpPullServer.MaxConnectionCount = 100000;


            Console.WriteLine("end");
            Console.ReadLine();
        }

        private static HandleResult TcpPullServer_OnClose(IServer sender, IntPtr connId, SocketOperation enOperation, int errorCode)
        {
            Console.WriteLine("TcpPullServer_OnClose");
            throw new NotImplementedException();
        }

        private static HandleResult TcpPullServer_OnReceive(IServer sender, IntPtr connId, int length)
        {
            Console.WriteLine("TcpPullServer_OnReceive");
            throw new NotImplementedException();
        }

        private static HandleResult TcpPullServer_OnHandShake(IServer sender, IntPtr connId)
        {
            Console.WriteLine("TcpPullServer_OnHandShake");
            throw new NotImplementedException();
        }

        private static HandleResult TcpPullServer_OnAccept(IServer sender, IntPtr connId, IntPtr pClient)
        {
            Console.WriteLine("TcpPullServer_OnAccept");

            var b = System.Text.Encoding.Default.GetBytes("");

            tcpPullServer.Send(connId, b, b.Length);

            throw new NotImplementedException();
        }
    }
}
