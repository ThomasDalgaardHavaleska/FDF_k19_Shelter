using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Filters
{
    public class BookingFilter
    {
        #region Instance fields

        private int? _bookingId;
        private int? _noUsers;
        private bool? _isReserved;
        private string? _districtOfUser;
        private DateTime? _reservationDate;
        private DateTime? _checkInDate;
        private DateTime? _checkOutDate;
        private Shelter? _shelterToBook;
        private BookingRegister _bookings;

        #endregion

        #region Constructor
        public BookingFilter()
        {
            _bookingId = null;
            _noUsers = null;
            _isReserved = null;
            _districtOfUser = null;
            _reservationDate = null;
            _checkInDate = null;
            _checkOutDate = null;
            _shelterToBook = null;
            _bookings = new BookingRegister();

        }

        #endregion

        #region Properties

        public int? BookingId
        {
            get { return _bookingId; }
            set { _bookingId = value; }
        }

        public int? NoUsers
        {
            get { return _noUsers; }
            set { _noUsers = value; }

        }

        public bool? IsReserved
        {
            get { return _isReserved; }
            set { _isReserved = value; }

        }

        public string? DistrictOfUser
        {
            get { return _districtOfUser; }
            set { _districtOfUser = value; }

        }

        public DateTime? ReservationDate
        {
            get { return _reservationDate; }
            set { _reservationDate = value; }

        }


        public DateTime? CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }

        }

        public DateTime? CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }

        }

        public Shelter? ShelterToBook
        {
            get { return _shelterToBook; }
            set { _shelterToBook = value; }

        }

        public BookingRegister Bookings
        {
            get { return _bookings; }
            set { _bookings = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return "Booking Id: " + _bookingId + ", Number of users: " + _noUsers + ", Is reserved: " + _isReserved +
                ", District of user: " + _districtOfUser + ", Reservation date: " + _reservationDate +
                ", Check-in Date: " + _checkInDate + ", Check-out Date: " + _checkOutDate + ", Shelter to book" + _shelterToBook;
        }


        public List<Booking> BookingsWithFilter(BookingFilter filter)
        {
            List<Booking> resultBooking = _bookings.GetAll();

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
    }
}
#endregion


                               
