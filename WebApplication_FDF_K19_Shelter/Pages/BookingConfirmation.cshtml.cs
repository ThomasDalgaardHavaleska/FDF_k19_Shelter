using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using System.Collections.Generic;

namespace WebApplication_FDF_K19_Shelter.Pages
{
    public class BookingConfirmationModel : PageModel
    {
        private readonly BookingRegister _bookings;

        public BookingConfirmationModel(BookingRegister bookings)
        {
            _bookings = bookings;
        }

        public Booking Booking { get; set; }

        public void OnGet(int id)
        {
            Booking = _bookings.GetById(id);
        }
    }
}