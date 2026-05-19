using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_FDF_K19_Shelter.Pages
{
    public class BookingModel : PageModel
    {

        
        private BookingRegister _bookings;
        private Booking _newbooking;
        private Shelter _shelter;

        public BookingModel(BookingRegister bookings, Shelter shelter)
        {
            _bookings = bookings;
            _shelter = shelter;
        }
        public BookingRegister Bookings { get { return _bookings; } set { _bookings = value; } }
        public Shelter Shelter { get { return _shelter; } set { _shelter = value; } }

        [BindProperty]
        public Booking NewBooking { get { return _newbooking; } set { _newbooking = value; } }

        public void OnGet()
        {
          
        }

        public IActionResult OnPost()
        {
            Shelter shelterToBook = new Shelter();
            shelterToBook = _shelter;
            District districtOfBooking = new District(0, "Syd", "Puslinge", "København S", "m@m.m", "123");
            Booking newBooking = new Booking();
            newBooking.NoOfCampers = NewBooking.NoOfCampers;
            newBooking.IsReserved = true;
            newBooking.AgeGroup = NewBooking.AgeGroup;
            newBooking.DistrictOfUser = districtOfBooking;
            newBooking.CheckInDate = NewBooking.CheckInDate;
            newBooking.CheckoutDate = NewBooking.CheckoutDate;
            newBooking.ShelterToBook = shelterToBook;
            newBooking.FullName = NewBooking.FullName;
 
			//if (!ModelState.IsValid)
   //         {
            
   //             return Page();
   //         }
            _bookings.Add(newBooking);

            return RedirectToPage("BookingConfirmation");
        }

        
    }
}
