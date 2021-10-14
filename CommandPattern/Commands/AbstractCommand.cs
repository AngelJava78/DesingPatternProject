using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public abstract class AbstractCommand : ICommand
    {
        public string CommandName { get; set; }

        public abstract void Execute(string[] args, TextWriter stream);

        public void Write(TextWriter stream, string message)
        {
            try
            {
                stream.Write(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.GetType()}");
                Console.WriteLine("Message: ");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
