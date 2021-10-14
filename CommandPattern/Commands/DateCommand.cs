using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class DateCommand : AbstractCommand
    {
        public DateCommand()
        {
            CommandName = "date";
        }
        public override void Execute(string[] args, TextWriter stream)
        {
            var date = string.Empty;
            if (args == null || args.Length == 0)
            {
                date = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            }
            else
            {
                date = DateTime.Now.ToString(args[0]);
            }
            stream.WriteLine(date);
        }
    }
}
