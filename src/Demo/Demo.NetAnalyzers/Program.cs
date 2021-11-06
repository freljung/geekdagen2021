// See https://aka.ms/new-console-template for more information
using Demo.NetAnalyzers;
using System.Reflection;

Console.WriteLine("Hello, World!");

// CA1812 - Ta bort kommenterad kod för att se exempel på när en klass kan
// användas och ändå trigga CA1812.
//
//MyGeneric<MyClass> mc = new MyGeneric<MyClass>();
//mc.Create();