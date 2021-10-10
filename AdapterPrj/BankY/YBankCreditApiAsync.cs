using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdapterPrj.BankY
{
    public class YBankCreditApiAsync
    {
        public async Task<YBankCreditResponse> SendCreditRequest(YBankCreditRequest request)
        {
            var response = new YBankCreditResponse();
            var approved = await ValidateCreditRequest(request);
            response.Approved = approved;
            return response;
        }

        private async Task<string> ValidateCreditRequest(YBankCreditRequest request)
        {
            var task = new Task<string>(() => request.Credit <= 1500 ? "YES" : "NO");
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: Start of: ValidareCreditRequest");
            task.Start();
            Thread.Sleep(1000 * 30);
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: End of: ValidareCreditRequest");
            string result = await task;
            return result;
        }

    }
}
