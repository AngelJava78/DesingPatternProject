using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentFacade.Subsystems.Email
{
    public class EmailSystem
    {
        public void SendEmail(Dictionary<string, object> values)
        {
            var template = "\n**************************************\n"
                   + "|To: $name\n"
                   + "|from: FacadeSystem\n"
                   + "|\n"
                   + "|Muchas gracias por utilizar el servicio en \n"
                   + "|linea para realizar sus pagos.\n"
                   + "|\n"
                   + "|Hace un momento acabamos de recibir un pago:\n"
                   + "|\n"
                   + "|Monto del pago: $amount.\n"
                   + "|Nuevo Saldo: $newBalance.\n"
                   + "|Tarjeta terminación: $cardNumber\n"
                   + "|Referencia de pago: $reference\n"
                   + "|Nuevos status: $newStatus\n"
                   + "|\n"
                   + "|Gracias por su preferencia.\n"
                   + "|\n"
                   + "|Este correo no deberá ser contestado ya que \n"
                   + "|ha sido enviado por un proceso automático"
                   + "\n**************************************";
            foreach (var item in values.Keys)
            {
                template = template.Replace(item, values[item].ToString());
            }
            Console.WriteLine(template);
        }

    }
}
