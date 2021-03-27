using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Commands;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand CreateCommand(string commandType)
        {
           Type type = Assembly.GetEntryAssembly()
                    .GetTypes()
                    .FirstOrDefault(t => t.Name.StartsWith(commandType));

           if (type == null)
           {
               throw new ArgumentException("Invalid command type");
           }

           return (ICommand)Activator.CreateInstance(type);
        }
    }
}
