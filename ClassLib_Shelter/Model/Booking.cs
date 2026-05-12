using ClassLib_Shelter.Registers;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLib_Shelter.Model
{
	public class Booking
	
	
	{
# region Instancefields
		private int _bookingId;
		private int _noUsers;
		private bool _isReserved;
		private string _districtOfUser;
		private DateTime _reservationDate;
		private DateTime _checkInDate;
		private DateTime _checkOutDate;
		private Shelter _shelterToBook;


        #endregion

        #region Constructors

        public Booking()
		{
			BookingId = 0;
			NoUsers = 1;
			IsReserved = false;
			DistrictOfUser = "Placeholder";
			ReservationDate = DateTime.Now;
			CheckInDate = DateTime.Now;
			CheckoutDate = DateTime.Now;
			ShelterToBook = null;
        }
		public Booking(int bookingId, int noUsers, bool isReserved, string districtOfUser, DateTime chekinDate, DateTime checkoutDate, Shelter shelterToBook)
		{
			BookingId = bookingId;
			NoUsers = noUsers;
			IsReserved = isReserved;
			DistrictOfUser = districtOfUser;
			ReservationDate = DateTime.Now;
			CheckInDate = chekinDate;
			CheckoutDate = checkoutDate;
			ShelterToBook = shelterToBook;
        }
#endregion

# region Properties

		public int BookingId
		{
			get { return _bookingId; }
			set { _bookingId = value; }
		}

	public int NoUsers
		{
			get { return _noUsers; }
			set 
			{ 
				if (value < 0)
				{
					throw new ArgumentException("Number of users cannot be negative.");
                }
				if (value > ShelterToBook.MaximumCapacity)
				{ 
					throw new ArgumentException("Number of campers cannot exceed shelter capacity.");
                }

                _noUsers = value; 
			}
		}

	public bool IsReserved
		{
			get { return _isReserved; }
			set 
			{
				_isReserved = value; 
			}
		}

	public string DistrictOfUser
		{
			get { return _districtOfUser; }
			set 
			{ 
				if(string.IsNullOrWhiteSpace(value) || value.Length == 0)
				{
					throw new ArgumentException("District of user cannot be empty.");
				}
				_districtOfUser = value; 
			
			}
		}

	public DateTime ReservationDate
		{
			get { return _reservationDate; }
			set 
			{
                if (value < DateTime.Now)
                {
                    throw new ArgumentException(
                        "Reservation date cannot be in the past.");
                }
                _reservationDate = value; 
			}
		}

	public DateTime CheckInDate
		{
			get { return _checkInDate; }
			set 
			{
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Check-in date cannot be in the past.");
                }
                _checkInDate = value; 			
			}
		}

	public DateTime CheckoutDate
		{
			get { return _checkOutDate; }
			set 
			{
                if (value < CheckInDate)
                {
                    throw new ArgumentException("Check-out date cannot be earlier than check-in date.");
                }
                _checkOutDate = value; 
			
			}

		}

		public Shelter ShelterToBook
		{
			get { return _shelterToBook; }
			set 
			{
				if (value == null)
				{
					throw new ArgumentException("Shelter cannot be null.");
				}
				_shelterToBook = value; 
			}
        }
        #endregion

        #region Methods



        public override string ToString()
		{
			return "BookingId: " + _bookingId + "NoUsers: " + _noUsers +  "IsReserved: " + _isReserved + "DistrictOfUser: " + _districtOfUser +  
					"ReservationDate: " + _reservationDate + "ChekinDate: " + _checkInDate + "CheckoutDate: " + _checkOutDate;
		}
#endregion
	}
}
