using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebShop.Pages.Currency
{
    public class CurrencyModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnGetRedirectToPage()
        {
            return RedirectToPage("Currency/View", new { id = 5 });
        }
    }
}
