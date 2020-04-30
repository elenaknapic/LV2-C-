using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos2
{
    //Z4
    class FileLogger : ILogger
    {
        bool append = true;
        private string filePath;


        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public void Log(string message)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, append))
            {
                writer.WriteLine(message);
            }
        }
    }
}
