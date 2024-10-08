﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using InterfacesImplementReview.Entities;
using InterfacesImplementReview.Services;
using System.Globalization;

//
Console.WriteLine("Enter rental data:");
Console.Write("Car model: ");
string? model = Console.ReadLine();

Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine());

Console.Write("Enter price per day: ");
double day = double.Parse(Console.ReadLine());

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day, new PortugalTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine();
Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);

Console.ReadLine();
