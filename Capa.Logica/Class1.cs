using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class Class1
    {
        public DateTime GetNISTDate()
        {
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
            var response = myHttpWebRequest.GetResponse();

            string[] dt = response.Headers.GetValues("Date");
            DateTime t = Convert.ToDateTime(dt[0]);

            return t;
        }
    }
}