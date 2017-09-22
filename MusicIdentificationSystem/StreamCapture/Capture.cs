using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StreamCapture
{
    public class Capture
    {
        String serverPath = "/";

        public void StartCapture(int minutes, string server, string destinationPath)
        {
            HttpWebRequest request = null; // web request
            HttpWebResponse response = null; // web response

            int metaInt = 0; // blocksize of mp3 data
            int count = 0; // byte counter
            int metadataLength = 0; // length of metadata header

            byte[] buffer = new byte[512]; // receive buffer

            Stream socketStream = null; // input stream on the web request
            Stream byteOut = null; // output stream on the destination file

            // create web request
            request = (HttpWebRequest)WebRequest.Create(server);

            // clear old request header and build own header to receive ICY-metadata
            request.Headers.Clear();
            request.Headers.Add("GET", serverPath + " HTTP/1.0");
            request.Headers.Add("Icy-MetaData", "1"); // needed to receive metadata informations
            request.UserAgent = "WinampMPEG/5.09";

            // execute request
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            // read blocksize to find metadata header
            metaInt = Convert.ToInt32(response.GetResponseHeader("icy-metaint"));
            DateTime startTime = DateTime.Now;
            DateTime endTime = DateTime.Now.AddMinutes(minutes);
            try
            {
                // open stream on response
                socketStream = response.GetResponseStream();
                byteOut = createNewFile(destinationPath, "defaultStream");
                // rip stream in an endless loop
                //while (byteOut.Length < 1024000) // 23650000 ~ 30 min     
                while (endTime > DateTime.Now)
                {
                    // read byteblock
                    int bufLen = socketStream.Read(buffer, 0, buffer.Length);
                    if (bufLen < 0)
                        return;

                    for (int i = 0; i < bufLen; i++)
                    {
                        if (count++ < metaInt) // write bytes to filestream
                        {
                            if (byteOut != null) // as long as we don't have a songtitle, we don't open a new file and don't write any bytes
                            {
                                byteOut.Write(buffer, i, 1);
                                if (count % 100 == 0)
                                    byteOut.Flush();
                            }
                        }
                        else // get headerlength from lengthbyte and multiply by 16 to get correct headerlength
                        {
                            metadataLength = Convert.ToInt32(buffer[i]) * 16;
                            count = 0;
                        }
                    }
                }
            }
            //try
            //{
            //    // open stream on response
            //    socketStream = response.GetResponseStream();
            //    byteOut = createNewFile(destinationPath, "defaultStream");
            //    // rip stream in an endless loop
            //    while (endTime > DateTime.Now)
            //    {
            //        // read byteblock
            //        int bufLen = socketStream.Read(buffer, 0, buffer.Length);
            //        if (bufLen < 0)
            //            return;

            //        for (int i = 0; i < bufLen; i++)
            //        {

            //            if (byteOut != null) // as long as we don't have a songtitle, we don't open a new file and don't write any bytes
            //            {
            //                byteOut.Write(buffer, i, 1);
            //                //if (count % 100 == 0)
            //                    byteOut.Flush();
            //            }

            //        }
            //    }
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (byteOut != null)
                    byteOut.Close();
                if (socketStream != null)
                    socketStream.Close();
            }
        }

        public void StartCapture2(int minutes, string server, string destinationPath) {
            HttpWebRequest req;
            Stream s = null;
            Stream fs = null;
            try
            {
                req = (HttpWebRequest)WebRequest.Create(server);

                //var fileName = Path.Combine(destinationPath, "DefaultStream.mp3"); 
                WebResponse resp = req.GetResponse();
                s = resp.GetResponseStream();

                fs = createNewFile(destinationPath, "defaultStream");
                //FileStream fs = File.Exists(fileName)
                //    ? new FileStream(fileName, FileMode.Append)
                //    : new FileStream(fileName, FileMode.Create);

                byte[] buffer = new byte[4096];
                var total = 0;
                DateTime startTime = DateTime.Now;
                DateTime endTime = DateTime.Now.AddMinutes(minutes);
                //while (s.CanRead)
                while (endTime > DateTime.Now)
                {
                    int bytesRead = s.Read(buffer, 0, buffer.Length);
                    fs.Write(buffer, 0, bytesRead);
                    total += bytesRead;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
                if (s != null)
                    s.Close();
            }
                 }
        /// <summary>
		/// Create new file without overwritin existing files with the same filename.
		/// </summary>
		/// <param name="destPath">destination path of the new file</param>
		/// <param name="filename">filename of the file to be created</param>
		/// <returns>an output stream on the file</returns>
		private static Stream createNewFile(String destPath, String filename)
        {
            // replace characters, that are not allowed in filenames. (quick and dirrrrrty ;) )
            filename = filename.Replace(":", "");
            filename = filename.Replace("/", "");
            filename = filename.Replace("\\", "");
            filename = filename.Replace("<", "");
            filename = filename.Replace(">", "");
            filename = filename.Replace("|", "");
            filename = filename.Replace("?", "");
            filename = filename.Replace("*", "");
            filename = filename.Replace("\"", "");

            try
            {
                // create directory, if it doesn't exist
                if (!Directory.Exists(destPath))
                    Directory.CreateDirectory(destPath);

                // create new file
                if (!File.Exists(destPath + filename + ".mp3"))
                {
                    return File.Create(destPath + filename + ".mp3");
                }
                else // if file already exists, don't overwrite it. Instead, create a new file named <filename>(i).mp3
                {
                    for (int i = 1; ; i++)
                    {
                        if (!File.Exists(destPath + filename + "(" + i + ").mp3"))
                        {
                            return File.Create(destPath + filename + "(" + i + ").mp3");
                        }
                    }
                }
            }
            catch (IOException)
            {
                return null;
            }
        }

        public void record()
        {
            // http://relay.pandora.radioabf.net:9000
            String server = "http://radio.mosaiquefm.net:8000/mosalive";
            String serverPath = "/";

            String destPath = "A:\\";           // destination path for saved songs
            String fname = "test";
            HttpWebRequest request = null; // web request
            HttpWebResponse response = null; // web response

            int metaInt = 0; // blocksize of mp3 data
            int count = 0; // byte counter
            int metadataLength = 0; // length of metadata header

            byte[] buffer = new byte[512]; // receive buffer

            Stream socketStream = null; // input stream on the web request
            Stream byteOut = null; // output stream on the destination file

            // create web request
            request = (HttpWebRequest)WebRequest.Create(server);

            // clear old request header and build own header to receive ICY-metadata
            request.Headers.Clear();
            request.Headers.Add("GET", serverPath + " HTTP/1.0");
            request.Headers.Add("Icy-MetaData", "1"); // needed to receive metadata informations
            request.UserAgent = "WinampMPEG/5.09";

            // execute request
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            // read blocksize to find metadata header
            metaInt = Convert.ToInt32(response.GetResponseHeader("icy-metaint"));

            try
            {
                // open stream on response
                socketStream = response.GetResponseStream();
                byteOut = createNewFile(destPath, fname);
                // rip stream in an endless loop
                while (byteOut.Length < 1024000) // 23650000 ~ 30 min     
                {
                    // read byteblock
                    int bufLen = socketStream.Read(buffer, 0, buffer.Length);
                    if (bufLen < 0)
                        return;

                    for (int i = 0; i < bufLen; i++)
                    {
                        if (count++ < metaInt) // write bytes to filestream
                        {
                            if (byteOut != null) // as long as we don't have a songtitle, we don't open a new file and don't write any bytes
                            {
                                byteOut.Write(buffer, i, 1);
                                if (count % 100 == 0)
                                    byteOut.Flush();
                            }
                        }
                        else // get headerlength from lengthbyte and multiply by 16 to get correct headerlength
                        {
                            metadataLength = Convert.ToInt32(buffer[i]) * 16;
                            count = 0;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (byteOut != null)
                    byteOut.Close();
                if (socketStream != null)
                    socketStream.Close();
            }
        }
    }
}
