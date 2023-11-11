// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Singleton instance1 = Singleton.Instance;
Singleton instance2 = Singleton.Instance;

Console.WriteLine(instance1 == instance2);