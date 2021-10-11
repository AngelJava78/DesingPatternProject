using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesComposite
{
   public abstract class Component
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void  AddChild(Component child);
        public abstract IList<Component> GetChildren();
        public abstract int GetSize();

    }
}
