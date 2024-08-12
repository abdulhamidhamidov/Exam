

using task2;
using Type = task2.Type;


Inventory<Item> inventory=new Inventory<Item>();
Item a=new Item();
a.name="Madara";
a.category="first catigory";
a.type=Type.HomeItem;
inventory.AddItem(a);
Item a1=new Item();
a1.name="Naruto";
a1.category="Second catigory";
a1.type=Type.WorkItem;
inventory.AddItem(a1);
inventory.RemoveItem(a);
inventory.GetItemsByCategory("Second catigory");
inventory.GetItemsByType(Type.HomeItem);
inventory.GetAllItems();
