// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//
using System.Globalization;
using CustomExceptions.Entities;
using CustomExceptions.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int number = Convert.ToInt16(Console.ReadLine());

    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation:");

    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException ex)
{
    Console.WriteLine("Error in reservation: " + ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Format error: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Unexpected error: " + ex.Message);
}

Console.ReadLine();
