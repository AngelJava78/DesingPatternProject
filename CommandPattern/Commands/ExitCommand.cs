using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class ExitCommand : AbstractCommand
    {
        public ExitCommand()
        {
            CommandName = "exit";
        }
        public override void Execute(string[] args, TextWriter stream)
        {
            stream.WriteLine("Exit from command line...");
            Environment.Exit(0);
        }
    }
}
