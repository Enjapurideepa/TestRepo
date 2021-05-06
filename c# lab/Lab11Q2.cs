using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Lab11Q2
    {
        public delegate void DownloadCompeteHandler(int perc);
        public class FileDownloader
        {
            protected string resourceUrl;
            protected string resourceSavePath;
            public event DownloadCompeteHandler DownLoadComplete;
            public FileDownloader(string url, string savepath)
            {
                this.resourceUrl = url;
                this.resourceSavePath = savepath;
            }
            public void DownLoadResource()
            {
                for (int i = 1; i <= 4; i++)
                {

                    OnDownLoadComplete(i * 25);
                }
            }
            public void OnDownLoadComplete(int i)
            {
                if (DownLoadComplete != null)
                    fd_DownLoadComplete(i);
            }
        }
        static void Main()
        {
            FileDownloader fd = new FileDownloader("http://www.microsoft.com/vstudio/expressv10.zip", "d:\\setups");
            //Register Event Handler
            fd.DownLoadComplete += fd_DownLoadComplete;
            //Start the task...
            fd.DownLoadResource();
            Console.ReadKey();
        }
        static void fd_DownLoadComplete(int perc)
        {
            Console.SetCursorPosition(10, 10);
            Console.Write("Downloading {0} Percent Complete", perc);
        }
    }
}
