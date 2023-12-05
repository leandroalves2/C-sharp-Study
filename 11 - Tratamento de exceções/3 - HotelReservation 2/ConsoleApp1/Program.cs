using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List< Reservation> reservation = new List<Reservation>();
            List<Room> rooms = new List<Room>(10);
            int roomkey = 101; 

            for (int i = 0; i < 10; i++)
            {
                rooms.Add(new Room(roomkey, false));
                roomkey = roomkey + 1;
                
            }

            Console.Write("\"How many reservations will be made? ");
            int nOfReservation = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0;i < nOfReservation; i++) 
            {
                Console.Write("Customer name: ");
                string clientName = Console.ReadLine();
                Console.Write("Document: ");
                string clienteCPF = Console.ReadLine();
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                bool test = true;
                while (test == true)
                {
                    Console.Write("Room number (101 to 110): ");
                    int rNumber = int.Parse(Console.ReadLine());
                    for (int j = 0; j < 10; j++)
                    {
                        if (rooms[j].Number == rNumber)
                        {
                            if (rooms[j].Reserved == false)
                            {
                                rooms[j].Reserved = true;
                                reservation.Add(new Reservation(clientName, clienteCPF, checkin, checkout));                                
                                test = false;
                            }
                            else 
                            {
                                Console.WriteLine("Room already reserved");
                            }
                        }
                        if (rNumber < 101 || rNumber > 110) 
                        {
                            Console.WriteLine("Room not found");
                        }
                    }
                }
            }

            foreach (Reservation reservations in reservation)
            {
                Console.WriteLine(reservations);
            }

        }
    }

}
