using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace stream
{
    class SaveAsThread
    {
        private int[] array;
        private string fileName;
        

        public SaveAsThread(int[] array, string fileName)
        {
            this.array = array;
            this.fileName = fileName;
        }

        public void SaveArrayToFile()
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                
                foreach(int element in array)
                {
                    writer.WriteLine(element);
                }
                                       
                    
            }
        }

        public void Start()
        {
            Thread thread = new Thread(SaveArrayToFile);
            thread.Start();
        }
    }
}
