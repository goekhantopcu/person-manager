namespace verwaltungsapp.util;

public static class ConsoleReader
{
    public static void Read0(Action<string> action)
    {
        while (true)
        {
            var line = Console.ReadLine();
            if (line == null)
            {
                continue;
            }
            action.Invoke(line);
        }
    }
}