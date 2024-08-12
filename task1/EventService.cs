namespace task1;

public class EventService
{
    private List<Event> _list = [];
    public void AddEvent(Event _event)=>_list.Add(_event);
    public void RemoveEvent(string title)
    {
        Event? a = _list.Find(x=>x.title==title);
        if (a != null)
        {
            Console.WriteLine("We delet your envet");
            _list.Remove(a);
        }
        else
        {
            Console.WriteLine("Erorr: We don't have this event ");
        }
    }
    public void SaerchEvent(DateTime a)
    {
        int cnt = 0;
        foreach (var b in _list)
        {
            if (b.startTime.Day == a.Day && b.startTime.Month == a.Month && b.startTime.Year == a.Year)
            {
                cnt++;
                Console.WriteLine($"Title : {b.title} ,Description : {b.description} ,Start date time {b.startTime} , End date time {b.endTime}");
            }
        }

        if (cnt == 0)
        {
            Console.WriteLine("Sorry we don't have event's for your date time ");
        }
        else
        {
            Console.WriteLine("We find "+cnt+" event for your date time");
        }
    }
}