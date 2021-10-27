using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormObserver
{
    public interface IUserObserver
    {
        void Update(Product product);
    }
}
