using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Fileloggertest
{
    class Filelogger:IDisposable
    {
        protected  readonly FileStream fileStream;

        public Filelogger(string filePath)
        {
            fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            
        }
       

        public virtual void Log(string message)
        {
            // Implement the file logging. Every line should follow the format:
            // <current date and time> - <message>
            // e.g.
            // 2018-11-09T14:46:55.345 - This is a sample message
            // Hint: use StreamWriter

                using (StreamWriter writer = new StreamWriter(fileStream,Encoding.ASCII,1024,true))
                {
                    writer.WriteLine($"{DateTime.Now.ToLocalTime()} - {message}");
                    //fileStream.Flush();
                }
            

            // fileStream.Dispose();
        }

        public virtual void Dispose(bool manualDispossing)
        {
            if (manualDispossing)
            {
                fileStream.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
