using verwaltungsapp.util;
using verwaltungsapp.control;

var personManager = new PersonManager();
var commandManager = new CommandManager(personManager);

Console.WriteLine("Herzlich Willkommen beim PersonManager");
Console.WriteLine("Eine Übersicht aller Befehle findest du unter 'hilfe'");

/*
 * ToDo: Observer Pattern
 * ToDo: Klassendiagramm
 */

ConsoleReader.Read0(line =>
{
    // Console Input Arguments containing command name
    var inputArguments = line.Split(" ");
    if (inputArguments.Length <= 0)
    {
        return;
    }
    
    // Copy InputArguments without first argument
    var copied = new string[inputArguments.Length - 1];
    Array.Copy(inputArguments, 1, copied, 0, inputArguments.Length - 1);
    
    // Find Command based on first argument of inputArguments
    var command = commandManager.FindCommand(inputArguments[0]);
    if (command == null)
    {
        Console.WriteLine("[SYSTEM] Dieser Befehl existiert nicht. Nutze 'hilfe' um alle Befehle einzusehen");
        return;
    }
    
    // Execute Command
    command.Execute(copied);
});