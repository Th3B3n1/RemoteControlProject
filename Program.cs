TV tv = new TV();
RemoteControl<TV> tvRemote = new RemoteControl<TV>(tv);
tvRemote.PowerOn();
tvRemote.VolumeDown();
tvRemote.VolumeUp();
tvRemote.ChangeChannel(5);
tvRemote.PowerOff();

HIFI hifi = new HIFI();
RemoteControl<HIFI> hifiRemote = new RemoteControl<HIFI>(hifi);
hifiRemote.PowerOn();
hifiRemote.VolumeDown();
hifiRemote.VolumeUp();
hifiRemote.ChangeChannel(5);
hifiRemote.PowerOff();


Student student = new Student { Id = 1, Name = "John Doe", Age = 20 };
Book book = new Book { Id = 101, Title = "C# Programming", Author = "Jane Smith" };
Employee employee = new Employee { Id = 1001, Name = "Alice Johnson", Position = "Software Engineer" };
DatabaseManager<object> databaseManager = new DatabaseManager<object>();
databaseManager.AddRecord(student);
databaseManager.AddRecord(book);
databaseManager.AddRecord(employee);
databaseManager.PrintDatabase();
databaseManager.RemoveRecord(1);
Console.WriteLine("\nDatabase after removing record:");
databaseManager.PrintDatabase();