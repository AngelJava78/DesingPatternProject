using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Items
{
    public class Composite<T> : IComponent<T>
    {
        List<IComponent<T>> items;
        public T Name { get; set; }
        public Composite(T name)
        {
            Name = name;
            items = new List<IComponent<T>>();
        }
        public void Add(IComponent<T> item)
        {
            items.Add(item);
        }

        public IComponent<T> Delete(T item)
        {
            IComponent<T> foundItem = Find(item);
            if(foundItem != null)
            {
                (this as Composite<T>).items.Remove(foundItem);
            }
            return this;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public IComponent<T> Find(T item)
        {
            if (Name.Equals(item))
                return this;
            IComponent<T> located = null;
            foreach(IComponent<T> i in items)
            {
                located = i.Find(item);
                if (located != null)
                    break;
            }
            return located;
        }

        public string Show(int deep)
        {
            var infoItem = new StringBuilder();
            infoItem.AppendLine($"- {deep}");
            infoItem.AppendLine($"Composite: {Name}. Items: {items.Count}");
            foreach(IComponent<T> item in items)
            {
                infoItem.AppendLine(item.Show(deep + 1));
            }
            return infoItem.ToString();

        }
    }
}
