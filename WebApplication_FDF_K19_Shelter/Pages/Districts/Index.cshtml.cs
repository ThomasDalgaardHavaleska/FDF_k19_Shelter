using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using ClassLib_Shelter.Model;

public class DistrictListModel : PageModel
{
    private readonly DistrictRegister _districts;

    public DistrictListModel(DistrictRegister districts)
    {
        _districts = districts;
    }

    public List<District> Districts { get; set; }

    public void OnGet()
    {
        Districts = _districts.GetAll();
    }
}