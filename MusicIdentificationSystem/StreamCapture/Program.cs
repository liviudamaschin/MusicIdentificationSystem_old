using MusicIdentificationSystem.EF.Context;
using MusicIdentificationSystem.EF.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCapture
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var db = new Db())
            {



                //var entity = new StreamStationEntity();
                //entity.Description = "A";
                //entity.StationName = "A";
                //entity.IsActive = false;
                //entity.Url = "A";

                //db.StreamStations.Add(entity);
                //db.SaveChanges();



                //paralel processing
                Parallel.ForEach(db.StreamStations, station =>
                {
                    if (station.IsActive.HasValue && station.IsActive.Value)
                    {
                        Capture capture = new Capture();
                        Console.WriteLine("Start capture station {0}", station.StationName);
                        capture.StartCapture2(5, station.Url, station.LocalPath);
                        Console.WriteLine("End capture station {0}", station.StationName);

                        ////Process process = new Process();
                        //ProcessStartInfo startInfo = new ProcessStartInfo();
                        ////startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        //startInfo.FileName = "ffmpeg.exe";
                        //startInfo.Arguments = String.Format(@"-y -t 60 -i {0} {1}DefaultRadio.mp3",station.Url, station.LocalPath);
                        ////process.StartInfo = startInfo;
                        ////process.Start();
                        //try
                        //{
                        //    // Start the process with the info we specified.
                        //    // Call WaitForExit and then the using statement will close.
                        //    using (Process exeProcess = Process.Start(startInfo))
                        //    {
                        //        exeProcess.WaitForExit();
                        //    }
                        //}
                        //catch
                        //{
                        //    // Log error.
                        //}

                        //string path = "ffmpeg.exe";
                        //string cmd_args = string.Format(@"-y -t 60 -i {0} {1}test1.mp3", station.Url, station.LocalPath);
                        //ProcessStartInfo procInfo = new ProcessStartInfo(path, cmd_args);
                        ////procInfo.CreateNoWindow = false;
                        //procInfo.UseShellExecute = true;
                        ////procInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        //Process procRun = Process.Start(procInfo);
                        //procRun.WaitForExit();

                    }
                });

                ////instance processing
                //int stationId = Convert.ToInt32(args[0]);
                //Capture capture = new Capture();
                //var station = db.StreamStations.SingleOrDefault(e => e.Id == stationId);
                //capture.StartCapture(5, station.Url, station.LocalPath);

                Console.WriteLine("Done!!!");
                Console.ReadLine();
            }
        }
    }
}
