using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormObserver
{
    public class User : IUserObserver
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public void Update(Product product)
        {
            Form1 f = (Form1)Application.OpenForms[0];
            f.Notify($"The usuer: {Name} {LastName} received the notification of product: {product}");
        }
    }
}
