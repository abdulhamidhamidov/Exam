namespace task3;

public class ClientManager<T> where T:Client
{
     List<T> _list=[];
     public void Create(T client)=>_list.Add(client);
     public List<T> Read() => _list;
     public void Update(T client)
     {
          T? a = _list.Find(x=>x==client);
          if (a != null)
          {
               foreach (var b in _list)
               {
                    if (b == a)
                    {
                         b.name = client.name;
                         b.clientId = 54326;
                         b.contactInfo = """
                                         qwerty:
                                         hamid: 
                                         wewqe:
                                         """;
                    }
               }
          }
          else
          {
               Console.WriteLine("We haven't got this client");
          }
     }
     public void Delate(T client)
     {
          T? a = _list.Find(x=>x==client);
          if (a != null) _list.Remove(a);
          else Console.WriteLine("We haven't got this client");
     }
}