using System;
using _4___HotelReservation_2.Entities.cs.Exceptions;

namespace _4___HotelReservation_2.Entities.cs
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set;}

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkin < DateTime.Now || checkout < DateTime.Now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkin > checkout)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan resp = Checkout - Checkin;
            return (int)resp.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            if (checkin < DateTime.Now || checkout < DateTime.Now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkin > checkout)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Reservation: Room " + RoomNumber + ", check-in: " + Checkin.ToString("dd/MM/yyyy") + ", check-out: " + Checkout.ToString("dd/MM/yyyy") + ", " + Duration() + " nights";
        }


    }
}
