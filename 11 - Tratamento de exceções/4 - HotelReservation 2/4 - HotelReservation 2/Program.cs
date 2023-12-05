using _4___HotelReservation_2.Entities.cs;
using _4___HotelReservation_2.Entities.cs.Exceptions;
using System;

namespace _4___HotelReservation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());
                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine(reservation);
                Console.WriteLine();
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro in reservation: " + e.Message);
                Console.WriteLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
                Console.WriteLine();
            }
        }
    }
}