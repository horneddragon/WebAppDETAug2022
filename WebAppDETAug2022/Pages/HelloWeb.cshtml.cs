using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Msg { get; set; }

        public int Discount { get; set; }
        public void OnGet()
        {
            Msg = "I Am Shock";
            Discount = 15;
        }


    }
}
