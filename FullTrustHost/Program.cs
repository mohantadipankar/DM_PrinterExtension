using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;


namespace FullTrustHost
{
    class Program
    {
        static void Main()
        {
            
       

            try
            {
                // Log the launch to a text file
                File.AppendAllText(@"C:\Temp\FullTrustHostLog.txt",
                    $"FullTrustHost launched at {DateTime.Now}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                // Log any errors
                File.AppendAllText(@"C:\Temp\FullTrustHostLog.txt",
                    $"Logging failed: {ex.Message}{Environment.NewLine}");
            }

            // Keep the process alive
            Thread.Sleep(Timeout.Infinite);

        }
    }
}
