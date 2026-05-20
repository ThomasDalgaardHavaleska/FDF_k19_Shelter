using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

public class ShelterBookModel : PageModel
{
    private readonly ShelterRegister _shelters;
    private readonly BookingRegister _bookings;

    public ShelterBookModel(ShelterRegister shelters, BookingRegister bookings)
    {
        _shelters = shelters;
        _bookings = bookings;
    }

    [BindProperty]
    public Shelter Shelter { get; set; }

    [BindProperty]
    public Booking Booking { get; set; }

    public IActionResult OnGet(int id)
    {
        Shelter = _shelters.GetById(id);
        if (Shelter == null) return NotFound();
        Booking = new Booking();
        Booking.ShelterToBook = Shelter;
        Booking.CheckInDate = DateTime.Now.AddDays(1);
        Booking.CheckoutDate = DateTime.Now.AddDays(2);
        return Page();
    }

    public IActionResult OnPost()
    {
        try
        {
            Booking.ShelterToBook = _shelters.GetById(Shelter.ShelterId);
            _bookings.Add(Booking);
            return RedirectToPage("/BookingConfirmation", new { id = Booking.BookingId });
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            return Page();
        }
    }
}