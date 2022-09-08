using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Services;

namespace WebAppDETAug2022.Pages
{
    public class HelloPageModel : PageModel
    {
        public IHello ob { get; set; } 
        public string Msg { get; set; }

        public  HelloPageModel(IHello i)
        {
            ob = i;
        }
        public void OnGet()
        {
            //ob = new Hello1();
            Msg = ob.SayHello("Ani");
        }
    }
}
