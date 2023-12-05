using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    internal class Reservation
    {
        public string ClientName  { get; set; }
        public string ClienteCPF { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public List<Room> Rooms { get; set; } = new List<Room>();

        public Reservation()
        {
        }

        public Reservation(string clientName, string clienteCPF, DateTime checkin, DateTime checkout)
        {
            ClientName = clientName;
            ClienteCPF = clienteCPF;
            Checkin = checkin;
            Checkout = checkout;
        }

     

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public int Duration()
        {
            TimeSpan days = Checkout - Checkin;
            return (int)days.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout) 
        {
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append("Reservation: " + ClientName + ", document: " + ClienteCPF + ", Room: " );
            foreach(Room room in Rooms) { sb.Append(room.Number); }         
            sb.Append(", check-in: " + Checkin.ToString("dd/MM/yyyy") + ", check-out: " + Checkout.ToString("dd/MM/yyyy") + ", Stay: " + Duration()); 
            
            return sb.ToString();

        }

    }
}
