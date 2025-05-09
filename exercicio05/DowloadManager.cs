using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    internal class DowloadManager
    {
        public event EventHandler<string> downloadCompleted;

        public void StartDownload(string fileName, int dowloadTimeInSeconds)
        {
            Console.WriteLine($"Iiniciando o download do arquivo: {fileName}");
            Console.WriteLine($"Tempo estimado para o download: {dowloadTimeInSeconds} segundos");

            Thread.Sleep(dowloadTimeInSeconds * 1000);

            OnDownloadCompleted("Download concluído com sucesso!");
        }
        
        public void OnDownloadCompleted(string message)
        {
            downloadCompleted?.Invoke(this, message);
        }

    }
}
