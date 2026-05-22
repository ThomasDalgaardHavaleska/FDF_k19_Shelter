using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using ClassLib_Shelter.Model;

public class BookingListModel : PageModel
{
    private readonly BookingRegister _bookings;

    public BookingListModel(BookingRegister bookings)
    {
        _bookings = bookings;
    }

    public List<Booking> Bookings { get; set; }

    public void OnGet()
    {
        Bookings = _bookings.GetAll();
    }
}