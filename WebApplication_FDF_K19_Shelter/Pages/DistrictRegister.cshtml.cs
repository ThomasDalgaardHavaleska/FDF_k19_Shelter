using ClassLib_Shelter.Registers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_FDF_K19_Shelter.Pages
{
    public class DistrictRegisterModel : PageModel
    {
        private DistrictRegister _districts;

        public DistrictRegisterModel(DistrictRegister districts)
        {
            _districts = districts;
        }

        public DistrictRegister Districts { get { return _districts; } set { _districts = value; } }


        public void OnGet()
        {
        }
    }
}
