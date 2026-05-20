using ClassLib_Shelter.Registers;
using ClassLib_Shelter.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

public class ShelterConfirmModel : PageModel
{
    private readonly BookingRegister _bookings;

    public ShelterConfirmModel(BookingRegister bookings)
    {
        _bookings = bookings;
    }

    public Booking Booking { get; set; }

    public IActionResult OnGet(int id)
    {
        Booking = _bookings.GetById(id);
        if (Booking == null) return NotFound();
        return Page();
    }
}