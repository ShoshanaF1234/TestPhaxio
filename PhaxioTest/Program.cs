using Phaxio;
using System;
using System.IO;

namespace Faxio
{
    class Program
    {
        static void Main(string[] args)
        {
            var status = SendFax();
            Console.WriteLine("Status:" + status);
        }

        public static string SendFax()
        {
            string key = "mvq51ug24yh1kxis5isibys6xrrkbswomlf5m1de";
            string secret = "rxfuoya6txil0ax3eg7fiq5sg2220ptu0snf7xbr";

            var phaxio = new PhaxioClient(key, secret);
            var fax = phaxio.Fax.Create(toNumbers: new string[] { "215-689-3122" }, contentUrl: "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf");
            return fax.Status;
        }
    }
}