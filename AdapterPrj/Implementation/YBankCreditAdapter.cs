using AdapterPrj.BankY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPrj.Implementation
{
    public class YBankCreditAdapter : IBankAdapter
    {
        YBankCreditResponse yResponse = null;

        public BankCreditResponse SendCreditRequestAsync(BankCreditRequest request)
        {
        //    var result = new BankCreditResponse
        //    {
        //        Approved = false
        //    };

        //    var yRequest = new YBankCreditRequest
        //    {
        //        Name = request.Customer,
        //        Credit = (float)request.Amount
        //    };
        //    var task = new Task(() =>
        //    {
        //        SendCreditRequest(yRequest);
        //    });
        //    task.Start();
        //    await task;

        //    result.Approved = yResponse.Approved == "YES";
        //    return result;
        //}

        //private Task<YBankCreditResponse> SendCreditRequest(YBankCreditRequest request)
        //{
        //    var apiAsync = new YBankCreditApiAsync();
        //    var task = new Task<>
        //    var yResponse = await apiAsync.SendCreditRequest(request);
        //    return yResponse;
        //}


    }

}
