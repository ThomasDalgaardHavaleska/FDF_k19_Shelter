using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_FDF_K19_Shelter.Pages
{
    public class BookingModel : PageModel
    {
        private static BookingRegister _bookings = new BookingRegister();
        private static ShelterRegister _shelters = new ShelterRegister();

        [BindProperty]
        public Booking newBooking { get; set; }

		public BookingRegister Bookings => _bookings;
        public ShelterRegister Shelters => _shelters;
        public void OnGet()
        {
          
        }

        public IActionResult OnPost()
        {
        newBooking.ShelterToBook = _shelters.GetById(1);
        newBooking.IsReserved = true;
        newBooking.DistrictOfUser = new District(0, "Syd", "Puslinge", "København S", "m@m.m", "123"); 
			if (!ModelState.IsValid)
            {
            
                return Page();
            }
            _bookings.Add(newBooking);

            return RedirectToPage("BookingConfirmation");
        }

        
    }
}