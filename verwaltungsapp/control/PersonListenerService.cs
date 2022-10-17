using verwaltungsapp.util;

namespace verwaltungsapp.control;

public class PersonListenerService
{
    private readonly List<IPersonListener> _listeners;

    public PersonListenerService()
    {
        _listeners = new List<IPersonListener>
        {
            
        };
    }
}