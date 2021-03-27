using System.Linq;
using CommandPattern.Commands;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly ICommandFactory commandFactory;

        public CommandInterpreter()
        {
            commandFactory = new CommandFactory();
        }

        public string Read(string args)
        {
            string[] parts = args.Split();

            string commandType = parts[0];
            string[] commandArgs = parts.Skip(1).ToArray();

            ICommand command = commandFactory.CreateCommand(commandType);

            return command.Execute(commandArgs);
        }
    }
}
