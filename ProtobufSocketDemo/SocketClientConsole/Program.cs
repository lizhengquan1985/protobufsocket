using HPSocketCS;
using SocketData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpPullClient<MsgInfo> client = new TcpPullClient<MsgInfo>();
            client.Connect("127.0.0.1", 8992);

            IntPtr intPtr = new IntPtr(1);
            var b = System.Text.Encoding.Default.GetBytes("");
            client.Send(b, b.Length);


            Console.WriteLine("1");

            Console.Read();
        }
    }
}
