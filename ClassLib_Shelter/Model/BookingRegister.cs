using ClassLib_Shelter.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Classes
{
    public class BookingRegister : IRegister<Booking>
    {
        private List<Booking> _bookings;
        private string _name;



        public BookingRegister() 
        { 
            _bookings = new List<Booking>();
            _name = "";
        }

        public BookingRegister(List<Booking> bookings, string name)
        {
            _bookings = bookings;
            _name = name;
        }

        public List<Booking> Bookings 
        { 
            get { return _bookings; }  
            set { _bookings = value; } 
        }
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }





        #region methods
        public List<Booking> GetAll()
        {
            return new List<Booking>(_bookings);
        }

        public void Add(Booking newBooking)
        {
            _bookings.Add(newBooking);
        }


        public void Remove(int bookingId)
        {

            _bookings.Remove(GetById(bookingId));


        }

        public Booking GetById(int bookingId)
        {
            foreach (Booking booking in _bookings)
            {
                if (bookingId == booking.BookingId) { return booking; }
            }
            return null;
        }

        public Booking Update(int bookingId, Booking updatedBooking)
        {
            Booking booking = GetById(bookingId);

            if (booking != null)
            {
                booking.BookingId = updatedBooking.BookingId;
                booking.NoUsers = updatedBooking.NoUsers;
                booking.IsReserved = updatedBooking.IsReserved;
                booking.DistrictOfUser = updatedBooking.DistrictOfUser;
                booking.ReservationDate = updatedBooking.ReservationDate;
                booking.CheckoutDate = updatedBooking.CheckoutDate;
                booking.ChekinDate = updatedBooking.ChekinDate;
            }
            return booking;
        }
        
        // ChangeBookingDate -> Properties?


        public override string ToString()
        {
            string res = " ";
            foreach (Booking booking in _bookings)
            {
                res += booking;
            }
            return res;
        }

        #endregion


    }
}
