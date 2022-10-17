namespace verwaltungsapp.view;

public interface ICommand
{
    string Name();

    string[] Aliases() => Array.Empty<string>();

    void Execute(string[] args);
}