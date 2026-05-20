using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using ClassLib_Shelter.Model;

public class ShelterListModel : PageModel
{
    private readonly ShelterRegister _shelters;

    public ShelterListModel(ShelterRegister shelters)
    {
        _shelters = shelters;
    }

    public List<Shelter> Shelters { get; set; }

    public void OnGet()
    {
        Shelters = _shelters.GetAll();
    }
}