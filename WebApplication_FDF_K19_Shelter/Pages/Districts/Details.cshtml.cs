using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

public class DistrictDetailsModel : PageModel
{
    private readonly DistrictRegister _districts;

    public DistrictDetailsModel(DistrictRegister districts)
    {
        _districts = districts;
    }

    public District District { get; set; }

    public IActionResult OnGet(int id)
    {
        District = _districts.GetById(id);
        if (District == null) return NotFound();
        return Page();
    }
}