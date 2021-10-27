using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormObserver
{
    public interface ISubjectProduct
    {
        void Add(IUserObserver user);
        void Remove(IUserObserver user);
        void Notify();

    }
}
