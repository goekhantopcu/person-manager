using System.Reflection;
using verwaltungsapp.view;

namespace verwaltungsapp.control;

public class CommandManager
{
    private readonly List<ICommand> _commands;

    public CommandManager(PersonManager manager)
    {
        _commands = new List<ICommand> {
            new ExitCommand(),
            new PersonCreateCommand(manager),
            new PersonDeleteCommand(manager),
            new PersonFilterCommand(manager),
            new PersonHelpCommand(),
            new PersonListCommand(manager),
            new PersonLoadCommand(manager),
            new PersonSaveCommand(manager)
        };
    }

    public ICommand? FindCommand(string name)
    {
        return _commands.Find(command => command.Name().ToLower().Equals(name.ToLower()));
    }
}