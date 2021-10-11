using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Items
{
   public  interface IComponent<T>
    {
        T Name { get; set; }
        void Add(IComponent<T> item);
        IComponent<T> Find(T item);
        IComponent<T> Delete(T item);
        string Show(int deep);


    }
}
