using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public interface ICommand
    {
        string CommandName { get; set; }
        void Execute(string [] args, TextWriter stream);
    }
}
