using System.Net.Sockets;

namespace ChatRoom
{
    internal class Cilent
    {
        private Socket socket;


        public Cilent(string ip_str, string port_str)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ip_str, int.Parse(port_str));
        }


        public void Send(string message)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            socket.Send(data);
        }

        public void Close(){socket.Close(); }






    }
}
