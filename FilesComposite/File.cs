using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesComposite
{
    public class File : Component
    {
        int size;
        public File(string name, int size): base(name)
        {
            this.size = size;
        }
        public int Size
        {
            get
            {
                return size;
            }
        }
        public override void AddChild(Component child)
        {
            
        }

        public override IList<Component> GetChildren()
        {
            return null;
        }

        public override int GetSize()
        {
            return size;
        }
    }
}
