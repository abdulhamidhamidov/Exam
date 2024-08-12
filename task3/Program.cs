using task3;

ClientManager<Client> clientManager = new ClientManager<Client>();
CorporateClient corporateClient=new CorporateClient();
corporateClient.clientId=12345;
corporateClient.name="HD.hamid";
corporateClient.contactInfo = "213435ffdfd";
corporateClient.taxId = 23234;
clientManager.Create(corporateClient);
IndividualClient individualClient=new IndividualClient();
individualClient.clientId=12345;
individualClient.name="HD.hamid";
individualClient.contactInfo = "213435ffdfd";
individualClient.gender=Gender.Female;
clientManager.Update(corporateClient);
clientManager.Delate(individualClient);
foreach (var a in clientManager.Read())
{
  Console.WriteLine($"Name {a.name} , clientId {a.clientId}, contactInfo {a.contactInfo}");   
}

