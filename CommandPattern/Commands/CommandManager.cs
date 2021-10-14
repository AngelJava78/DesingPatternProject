using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CommandManager
    {
        private static CommandManager instance;
        private Dictionary<string, ICommand> commands;
        private CommandManager()
        {
            commands = new Dictionary<string, ICommand>();
            var exitCommand = new ExitCommand();
            commands.Add(exitCommand.CommandName, exitCommand);
            var dateCommand = new DateCommand();
            commands.Add(dateCommand.CommandName, dateCommand);

        }
        public static CommandManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CommandManager();
                }
                return instance;
            }
        }

        public void Register(string commandName, ICommand command)
        {
            commands.Add(command.CommandName, command);
        }

        public ICommand GetCommand(string commandName)
        {
            ICommand command = null;
            if(commands.ContainsKey(commandName))
            {
                command = commands[commandName];
            }
            else
            {
                command=  new CommandNotFound();
            }
            return command;
        }

    }
}
