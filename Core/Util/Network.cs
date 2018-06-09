using System;
using System.Net;
using System.Net.Sockets;

namespace Core.Util
{
    public static class Network
    {
        public static string LocalIPAddress
        {
            get
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                throw new Exception("No network adapters with an IPv4 address in the system!");
            }
        }
    }
}
