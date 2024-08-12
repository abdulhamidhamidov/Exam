using task1;

EventService k = new EventService();
Event a1=new Event();
a1.title="Madara";
a1.description="qwertyujyrgfhbvadg";
DateTime a2=new DateTime(2020,10,13);
a1.startTime = a2;
DateTime a3=new DateTime(2020,12,13);
a1.endTime = a3;
k.AddEvent(a1);
Event a4=new Event();
a4.title="Naruto";
a4.description="rewqwertyujyrgfhbvadg";
DateTime a=new DateTime(2021,11,23);
a4.startTime = a;
DateTime a5=new DateTime(2022,3,4);
a4.endTime = a5;
k.AddEvent(a4);
k.RemoveEvent("Madara");
k.SaerchEvent(new DateTime(2021,11,23));

