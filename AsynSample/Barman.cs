using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynSample
{
    public class Barman
    {
        public async Task<bool> CalientaSnack()
        {
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: Mete el snack al horno");
            //Thread.Sleep(5000);
            var client = new HttpClient();
            await client.GetAsync("http://hdeleon.net");
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: Saca el snack del horno");
            return true;
        }

        public void HacerCoctel()
        {
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: Comienza a hacer el cóctel");
            //Thread.Sleep(10000);
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: Termina de hacer el cóctel");
        }
    }
}
