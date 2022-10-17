using verwaltungsapp.model;

namespace verwaltungsapp.util;

public interface IPersonListener
{
    public void OnPersonAdd(Person person);

    public void OnPersonRemove(Person person);
}