using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using ClassLib_Shelter.Model;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

public class ShelterBookModel : PageModel
{
    private readonly ShelterRegister _shelters;
    private readonly BookingRegister _bookings;
    private readonly DistrictRegister _districts;

    public ShelterBookModel(ShelterRegister shelters, BookingRegister bookings, DistrictRegister districts)
    {
        _shelters = shelters;
        _bookings = bookings;
        _districts = districts;
    }

    [BindProperty]
    public Shelter Shelter { get; set; }

    [BindProperty]
    public Booking Booking { get; set; }

    [BindProperty]
    public int SelectedDistrictId { get; set; }

    [BindProperty]
    public string SelectedAgeGroup { get; set; }

    public List<District> AllDistricts { get; set; }

    public IActionResult OnGet(int id)
    {
        Shelter = _shelters.GetById(id);
        if (Shelter == null) return NotFound();
        Booking = new Booking();
        Booking.ShelterToBook = Shelter;
        Booking.CheckInDate = DateTime.Now.AddDays(1);
        Booking.CheckoutDate = DateTime.Now.AddDays(2);
        AllDistricts = _districts.GetAll();
        return Page();
    }

    public IActionResult OnPost()
    {
        try
        {
            Booking.ShelterToBook = _shelters.GetById(Shelter.ShelterId);
            // Assign selected district and age group
            if (SelectedDistrictId != 0)
            {
                Booking.DistrictOfUser = _districts.GetById(SelectedDistrictId);
            }
            Booking.AgeGroup = SelectedAgeGroup;
            AllDistricts = _districts.GetAll();
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