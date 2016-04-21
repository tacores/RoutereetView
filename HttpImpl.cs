using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutereetView
{
    class HttpImpl : Http
    {
        public byte[] Download(string url)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            return client.DownloadData(url);
        }
    }
}
