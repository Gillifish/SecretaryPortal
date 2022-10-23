using System.Net;

namespace SinfonianAttendance.Data
{
    public class IPData
    {
        public static void PrintIP()
        {
            string hostname = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(hostname);

            foreach (var item in ip)
            {
                Console.WriteLine(item);
            }
        }
    }
}