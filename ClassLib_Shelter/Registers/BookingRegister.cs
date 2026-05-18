using ClassLib_Shelter.Filters;
using ClassLib_Shelter.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Registers
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
            if (newBooking == null)
                throw new ArgumentNullException("item");

            foreach (Booking booking in _bookings)
            {
                if (booking.BookingId == booking.BookingId)
                {
                    throw new Exception("Booking with this ID already exists.");
                }
            }
            _bookings.Add(newBooking);
        }


        public void Remove(int bookingId)
        {
            Booking bookingToDelete = GetById(bookingId);
            if (bookingToDelete == null)
            {
                throw new Exception("Booking not found.");
            }
            _bookings.Remove(bookingToDelete);


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
                booking.NoOfCampers = updatedBooking.NoOfCampers;
                booking.IsReserved = updatedBooking.IsReserved;
                booking.DistrictOfUser = updatedBooking.DistrictOfUser;
                booking.ReservationDate = updatedBooking.ReservationDate;
                booking.CheckoutDate = updatedBooking.CheckoutDate;
                booking.CheckInDate = updatedBooking.CheckInDate;
                return booking;
            }
            throw new Exception("Booking not found.");
        }

        // ChangeBookingDate -> Properties?




        public List<Booking> BookingsWithFilter(BookingFilter filter)
        {
            List<Booking> resultBooking = GetAll();

            List<Booking> allBookingsWithFilter = new List<Booking>();

            if (filter.BookingId != null)
            {
                foreach (var booking in resultBooking)
                {

                    if (booking.BookingId == filter.BookingId)
                    {
                        allBookingsWithFilter.Add(booking);
                    }
                }

                resultBooking = allBookingsWithFilter;
                allBookingsWithFilter = new List<Booking>();

            }

            if (filter.NoUsers != null)
            {
                foreach (var booking in resultBooking)
                {
                    if (booking.NoOfCampers == filter.NoUsers)
                    {
                        allBookingsWithFilter.Add(booking);
                    }
                }

                resultBooking = allBookingsWithFilter;
                allBookingsWithFilter = new List<Booking>();
            }

            if (filter.IsReserved != null)
            {
                foreach (var booking in resultBooking)
                {
                    if (booking.IsReserved == filter.IsReserved)
                    {
                        allBookingsWithFilter.Add(booking);
                    }
                }

                resultBooking = allBookingsWithFilter;
                allBookingsWithFilter = new List<Booking>();

            }
            if (filter.DistrictOfUser != null)
            {
                foreach (var booking in resultBooking)
                {
                    if (booking.DistrictOfUser == filter.DistrictOfUser)
                    {
                        allBookingsWithFilter.Add(booking);
                    }
                }

                resultBooking = allBookingsWithFilter;
                allBookingsWithFilter = new List<Booking>();
            }

            if (filter.ReservationDate != null)
            {
                foreach (var booking in resultBooking)
                {
                    if (booking.ReservationDate == filter.ReservationDate)
                    {
                        allBookingsWithFilter.Add(booking);
                    }
                }

                resultBooking = allBookingsWithFilter;
                allBookingsWithFilter = new List<Booking>();
            }

            if (filter.CheckInDate != null)
            {
                foreach (var booking in resultBooking)
                {
                    if (booking.CheckInDate == filter.CheckInDate)
                    {
                        allBookingsWithFilter.Add(booking);
                    }
                }

                resultBooking = allBookingsWithFilter;
                allBookingsWithFilter = new List<Booking>();
            }

            if (filter.CheckOutDate != null)
            {
                foreach (var booking in resultBooking)
                {
                    if (booking.CheckoutDate == filter.CheckOutDate)
                    {
                        allBookingsWithFilter.Add(booking);
                    }
                }

                resultBooking = allBookingsWithFilter;
                allBookingsWithFilter = new List<Booking>();
            }

            return resultBooking;

        }

        public override string ToString()
        {
            string res = "[ ";
            foreach (Booking booking in _bookings)
			{
				res += booking + " ";
			}
			return res + " ]";
		}

        #endregion


    }
}
