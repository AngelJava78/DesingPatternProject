using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesComposite
{
    public class Folder : Component
    {
        public List<Component> children;
        public Folder(string name): base(name)
        {
            children = new List<Component>();
        }
        public override void AddChild(Component child)
        {
            children.Add(child);
        }
        public override IList<Component> GetChildren()
        {
            return children;
        }
        public override int GetSize()
        {
            int result = 0;
            foreach(var item in children)
            {
                result += item.GetSize();
            }
            return result;
        }
       
       


    }
}
