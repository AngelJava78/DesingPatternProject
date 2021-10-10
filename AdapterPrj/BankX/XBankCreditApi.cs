using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPrj.BankX
{
    public class XBankCreditApi
    {
        public XBankCreditResponse SendCreditRequest(XBankCreditRequest request)
        {
            var response = new XBankCreditResponse();
            if(request.ReqestAmount <= 5000)
            {
                response.Approval = true;
            }
            else
            {
                response.Approval = false;
            }
            return response;

        }
    }
}
