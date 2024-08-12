namespace task2;

public class Inventory<T> where T:Item
{
    private List<Item> _list = [];

    public void AddItem(T item)=>_list.Add(item);
    public void RemoveItem(T item)
    {
        T? a = (T?)_list.Find(x=> x == item);
        if (a!=null) _list.Remove(a);
        else Console.WriteLine("your item is empty my list");
    }
    public void GetItemsByCategory(string category)
    {
        T? a = (T?)_list.Find(x=>x.category==category);
        if (a != null) Console.WriteLine($"Name {a.name} , Category : {a.category}, Type : {a.type}");
        else Console.WriteLine("We haven't got this category");
    }
    public void GetItemsByType(Enum type)
    {
        T? a = (T?)_list.Find(x=>x.type==type);
        if (a != null) Console.WriteLine($"Name {a.name} , Category : {a.category}, Type : {a.type}");
        else Console.WriteLine("We haven't got this type");
        
    }
    public void GetAllItems()
    {
        if (_list.Count > 0)
        {
            foreach (var b in _list)
            {
                Console.WriteLine($"Name {b.name} , Category : {b.category}, Type : {b.type}");
            }
        }
        else
        {
            Console.WriteLine("We haven't got Item");
        }
    }
}