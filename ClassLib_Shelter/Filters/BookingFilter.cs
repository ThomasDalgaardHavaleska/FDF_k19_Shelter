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
        private string? _ageGroup;
        private District? _districtOfUser;
        private DateTime? _reservationDate;
        private DateTime? _checkInDate;
        private DateTime? _checkOutDate;
        private Shelter? _shelterToBook;


        #endregion

        #region Constructor
        public BookingFilter()
        {
            _bookingId = null;
            _noUsers = null;
            _isReserved = null;
            _ageGroup = null;
            _districtOfUser = null;
            _reservationDate = null;
            _checkInDate = null;
            _checkOutDate = null;
            _shelterToBook = null;
          

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

        public string? AgeGroup
        {
            get { return _ageGroup; }
            set { _ageGroup = value; }
        }

        public District? DistrictOfUser
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



        #endregion

        #region Methods

   
        
       
    }
}
#endregion


                               
