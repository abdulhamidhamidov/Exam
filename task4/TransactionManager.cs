namespace task4;

public class TransactionManager
{
    private List<Transaction> _list = [];
    public void Add(Transaction transaction) => _list.Add(transaction);
    public void SearchTransaction(DateTime dateTime)
    {
        int cnt = 0;
        foreach (var a in _list)
        {
            if (a.dateTime.Year == dateTime.Year)
            {
                Console.WriteLine($"id {a.id} , Date time {a.dateTime}, Amount {a.amount} , TransactionType {a.transactionType}");
                cnt++;
            }
        }

        if (cnt == 0) Console.WriteLine("We don't came than year");
    }
    public void SumOfAmount()
    {
        decimal sum = 0;
        foreach (var a in _list)
        {
            sum += a.amount;
        }
        Console.WriteLine("sum of all time "+ sum);
    }
    public void PrintFirstAndLastTransaction()
    {
       Console.WriteLine(_list[0].dateTime+ " "+_list[0].id+" "+_list[0].transactionType+" "+_list[0].amount);    
       Console.WriteLine(_list[_list.Count-1].dateTime+ " "+_list[_list.Count-1].id+" "+_list[_list.Count-1].transactionType+" "+_list[_list.Count-1].amount);    
    }
}