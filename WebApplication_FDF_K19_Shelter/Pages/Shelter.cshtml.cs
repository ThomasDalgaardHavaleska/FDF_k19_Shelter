using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_FDF_K19_Shelter.Pages
{
    public class ShelterModel : PageModel
    {
    private ShelterRegister _shelters;

        public ShelterModel(ShelterRegister shelters)
        {
            _shelters = shelters;
        }
        public ShelterRegister Shelters { get { return _shelters; } set { _shelters = value; } }

		public void OnGet()
        {
        }
    }
}
