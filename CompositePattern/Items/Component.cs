using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Items
{
    public class Component<T> : IComponent<T>
    {
        public T Name { get; set; }
        public Component(T name)
        {
            Name = name;
        }
        public void Add(IComponent<T> item)
        {
            Console.WriteLine("You can add to the composite, not to the components");
        }

        public IComponent<T> Delete(T item)
        {
            Console.WriteLine("You can't delete directly");
            return this;
        }

        public IComponent<T> Find(T item)
        {
            if (item.Equals(Name))
                return this;
            else
                return null;
        }

        public string Show(int deep)
        {
            return $"- {deep} {Name} \r\n";
        }
    }
}
