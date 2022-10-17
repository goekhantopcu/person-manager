using verwaltungsapp.control;

namespace verwaltungsapp.view;

public class PersonDeleteCommand: ICommand
{
    private readonly PersonManager _manager;

    public PersonDeleteCommand(PersonManager manager)
    {
        _manager = manager;
    }

    public string Name() => "löschen";

    public void Execute(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("[SYSTEM] Verwende: löschen <Id>");
            return;
        }
        try
        {
            var id = int.Parse(args[0]);
            if (_manager.RemovePerson(id))
            {
                Console.WriteLine("[SYSTEM] Die Person mit der Id '" + id + "' wurde gelöscht");
            }
            else
            {
                Console.WriteLine("[SYSTEM] Es wurde keine Person gelöscht");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("[SYSTEM] Die Eingabe '" + args[0] + "' ist keine Ganzzahl");
        }
        catch (OverflowException)
        {
            Console.WriteLine("[SYSTEM] Die Eingabe '" + args[0] + "' ist größer als erlaubt");
        }
    }
}