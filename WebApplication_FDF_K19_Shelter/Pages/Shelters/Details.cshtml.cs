using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ClassLib_Shelter.Model;

public class ShelterDetailsModel : PageModel
{
    private readonly ShelterRegister _shelters;

    public ShelterDetailsModel(ShelterRegister shelters)
    {
        _shelters = shelters;
    }

    [BindProperty]
    public Shelter Shelter { get; set; }

    public IActionResult OnGet(int id)
    {
        Shelter = _shelters.GetById(id);
        if (Shelter == null) return NotFound();
        return Page();
    }
}