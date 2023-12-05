using System;

namespace _4___HotelReservation_2.Entities.cs.Exceptions
{
    internal class DomainException : ApplicationException    
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
