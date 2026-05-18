using ClassLib_Shelter.Registers;
using ClassLib_Shelter.Model;
using ClassLib_Shelter.Filters;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_FDF_K19_Shelter.Pages
{
    public class DistrictModel : PageModel
    {

        private DistrictRegister _districts;

        public DistrictModel(DistrictRegister districts)
        {
            _districts = districts;
        }

        public DistrictRegister Districts { get { return _districts; } set { _districts = value; } }


    public void OnGet()
        {
        }

    

    }
}
