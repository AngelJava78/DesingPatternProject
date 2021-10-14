using CommandPattern.Commands;
using CommandPattern.Util;
using System;
using System.Collections.Generic;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandManager = CommandManager.Instance;
            while (true)
            {
                var newLine = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(newLine))
                {
                    continue;
                }
                var commandArgs = CommandUtil.TokenizerArgs(newLine);
                var commandName = commandArgs[0];
                string[] commandArgs2 = new string[commandArgs.Count - 1];
                if (commandArgs.Count > 1)
                {
                    for (var i = 1; i < commandArgs.Count; i++)
                    {
                        commandArgs2[i - 1] = commandArgs[i];
                    }
                }
                ICommand command = commandManager.GetCommand(commandName);
                command.Execute(commandArgs2, System.Console.Out);
            }
        }
    }
}
