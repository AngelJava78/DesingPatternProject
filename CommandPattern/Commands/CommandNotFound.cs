using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CommandNotFound : AbstractCommand
    {
        public CommandNotFound()
        {
            CommandName = "notFound";
        }
        public override void Execute(string[] args, TextWriter stream)
        {
            stream.WriteLine("Command not found...");
        }
    }
}
