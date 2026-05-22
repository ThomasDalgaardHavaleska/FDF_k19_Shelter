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
    private string _errorMessage;
    private string _fullName;
    private DateTime _checkInDate;
    private DateTime _checkOutDate;
    private int _noOfCampers;

	public ShelterBookModel(ShelterRegister shelters, BookingRegister bookings, DistrictRegister districts)
    {
        _shelters = shelters;
        _bookings = bookings;
        _districts = districts;
        _errorMessage = string.Empty;
        _checkInDate = DateTime.Now;
        _checkOutDate = DateTime.Now;
        _fullName = string.Empty;
        _noOfCampers = 0;

    }

    [BindProperty]
    public Shelter Shelter { get; set; }

    //[BindProperty]
    //public Booking Booking { get; set; }

    [BindProperty]
    public string FullName
    {
        get { return _fullName; }
        set { _fullName = value; }
	}
    [BindProperty]
    public DateTime CheckInDate
    {
        get { return _checkInDate; }
        set { _checkInDate = value; }
    }
    [BindProperty]
    public DateTime CheckOutDate
    {
    get { return _checkOutDate; }
    set { _checkOutDate = value; }
    }
    [BindProperty]
    public int NoOfCampers
    {
    get { return _noOfCampers ; }
    set { _noOfCampers = value;}
    }

	[BindProperty]
    public int SelectedDistrictId { get; set; }

    [BindProperty]
    public string SelectedAgeGroup { get; set; }

    public List<District> AllDistricts { get; set; }
    public string ErrorMessage
    {
        get { return _errorMessage; }
        set { _errorMessage = value; }
    }

    public IActionResult OnGet(int id)
    {
        Shelter = _shelters.GetById(id);
        if (Shelter == null) return NotFound();
        FullName = string.Empty;
        CheckInDate= DateTime.Now.AddDays(1);
        CheckOutDate = DateTime.Now.AddDays(2);
        AllDistricts = _districts.GetAll();
        ErrorMessage = string.Empty;
        NoOfCampers = 0;
        return Page();
    }

    public IActionResult OnPost()
    {
        try
        {
            Booking booking = new Booking();
            booking.ShelterToBook = _shelters.GetById(Shelter.ShelterId);
            // Assign selected district and age group
            if (SelectedDistrictId != 0)
            {
                booking.DistrictOfUser = _districts.GetById(SelectedDistrictId);
            }
            booking.AgeGroup = SelectedAgeGroup;
            booking.FullName = FullName;
            booking.CheckInDate = CheckInDate;
            booking.CheckoutDate = CheckOutDate;
            booking.NoOfCampers= NoOfCampers;
            AllDistricts = _districts.GetAll();
            _bookings.Add(booking);
            return RedirectToPage("/BookingConfirmation", new { id = booking.BookingId });
        }
        catch (ArgumentException E)
        {
            ErrorMessage = @$"{E.Message}";
            return Page();
        }
    }
}