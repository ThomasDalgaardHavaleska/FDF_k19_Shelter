using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Classes
{
    public class BookingRegister
    {
        private List<Booking> _bookings;
        private string _name;



        public BookingRegister() { }

        public List<Booking> Bookings { get { return _bookings; }  set { _bookings = value; } }
        public string Name { get { return _name; } set { _name = value; } }
    }
}
