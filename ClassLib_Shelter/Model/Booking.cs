using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLib_Shelter.Classes
{
	public class Booking
	
	
	{
# region Instancefields
		private int _bookingId;
		private int _noUsers;
		private bool _isReserved;
		private string _districtOfUser;
		private DateTime _reservationDate;
		private DateTime _chekinDate;
		private DateTime _checkoutDate;
		#endregion

		#region Constructors

		public Booking()
		{
			_bookingId = 0;
			_noUsers = 0;
			_isReserved = false;
			_districtOfUser = "";
			_reservationDate = DateTime.Now;
			_chekinDate = DateTime.Now;
			_checkoutDate = DateTime.Now;
		}
	public Booking (int bookingId, int noUsers, bool isReserved, string districtOfUser, DateTime chekinDate, DateTime checkoutDate)

		{
			_bookingId = bookingId;
			_noUsers = noUsers;
			_isReserved = isReserved;
			_districtOfUser = districtOfUser;
			_reservationDate = DateTime.Now;
			_chekinDate = chekinDate;
			_checkoutDate = checkoutDate;
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
			set { _noUsers = value; }
		}

	public bool IsReserved
		{
			get { return _isReserved; }
			set { _isReserved = value; }
		}

	public string DistrictOfUser
		{
			get { return _districtOfUser; }
			set { _districtOfUser = value; }
		}

	public DateTime ReservationDate
		{
			get { return _reservationDate; }
			set { _reservationDate = value; }
		}

	public DateTime ChekinDate
		{
			get { return _chekinDate; }
			set { _chekinDate = value; }
		}

	public DateTime CheckoutDate
		{
			get { return _checkoutDate; }
			set { _checkoutDate = value; }
		}
		#endregion

# region Methods

		

		public override string ToString()
		{
			return "BookingId: " + _bookingId + "NoUsers: " + _noUsers +  "IsReserved: " + _isReserved + "DistrictOfUser: " + _districtOfUser +  
					"ReservationDate: " + _reservationDate + "ChekinDate: " + _chekinDate + "CheckoutDate: " + _checkoutDate;
		}
		#endregion
	}
}
