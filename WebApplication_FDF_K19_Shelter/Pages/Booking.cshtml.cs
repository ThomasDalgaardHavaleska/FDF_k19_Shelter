using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_FDF_K19_Shelter.Pages
{
    public class BookingModel : PageModel
    {
        private static BookingRegister _bookings = new BookingRegister();

        [BindProperty]
        public Booking newBooking { get; set; }

        public List<Booking> Bookings { get; set; }
        public void OnGet()
        {
            Bookings = _bookings.GetAll();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Bookings = _bookings.GetAll();
                return Page();
            }

            int nyId = _bookings.GetAll().Count + 1;
            newBooking.BookingId = nyId;
            _bookings.Add(newBooking);

            return RedirectToPage("BookingBekraeftelse");
        }
    }
}