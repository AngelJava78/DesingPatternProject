using AdapterPrj.BankX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPrj.Implementation
{
    public class XBankCreditAdapter : IBankAdapter
    {
        public BankCreditResponse SendCreditRequestAsync(BankCreditRequest request)
        {
            var result = new BankCreditResponse
            {
                Approved = false
            };
            var api = new XBankCreditApi();
            var xRequest = new XBankCreditRequest
            {
                CustomerName = request.Customer,
                ReqestAmount = request.Amount
            };
            var yResponse = api.SendCreditRequest(xRequest);
            result.Approved = yResponse.Approval;
            return result;
        }
    }
}
