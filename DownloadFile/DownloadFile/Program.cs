using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace DownloadFile
{
    class Program
    {
        

       public static int Upload(String remoteFileName, String localFileName)
        {
            int bytesProcessed = 0;
            Stream remoteStream = null;
            Stream localStream = null;
            WebResponse response = null;

            try
            {
                WebRequest request = WebRequest.Create(remoteFileName);
                if(request != null)
                {
                    response = request.GetResponse();

                    if(response != null)
                    {
                        remoteStream = response.GetResponseStream();

                        localStream = File.Create(localFileName);

                        byte[] buffer = new byte[1024];
                        int bytesRead;

                        do
                        {
                            bytesRead = remoteStream.Read(buffer, 0, buffer.Length);
                            localStream.Write(buffer, 0, bytesRead);
                            bytesProcessed += bytesRead;
                        } while (bytesRead > 0);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (remoteStream != null) remoteStream.Close();
                if (localStream != null) localStream.Close();
                if (response != null) response.Close();
            }
            return bytesProcessed;
        }

        static void Main(string[] args)
        {
            int read = Upload("https://apkpure.com/free-samples/com.freesamplesus.myapp/download?from=details", "C:/Users/nilesh/Downloads/Sample.apk");
            Console.WriteLine("{0} bytes written", read);

            string url = "http://google.com/xrds/xrds.xml";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            XDocument doc;
            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    doc = XDocument.Load(stream);
                }
            }
            
            Console.WriteLine(doc);

            Console.ReadKey();
        }
    }
}
