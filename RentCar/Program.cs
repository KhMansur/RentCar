// See https://aka.ms/new-console-template for more information
using RentCar;
using RentCar.Models;

Console.WriteLine("Hello, World!");

Mashina mashina = new Mashina();
EntityForCars db = new EntityForCars();

Console.WriteLine("Model(str) : "); mashina.Model = Console.ReadLine();
Console.WriteLine("Nomer(str) : "); mashina.Nomer = Console.ReadLine();
Console.WriteLine("Narxi(int) : "); mashina.Narxi = int.Parse(Console.ReadLine());
Console.WriteLine("Yili(int) : ");  mashina.Yili  = int.Parse(Console.ReadLine());
Console.WriteLine("Rangi(str) : "); mashina.Rangi = Console.ReadLine();

db.Add(mashina);

Console.WriteLine("\n\n\n\nDone");