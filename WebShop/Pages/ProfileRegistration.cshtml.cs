using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShop.Classes;
using WebShopBase;

namespace WebShop.Pages
{
    public class ProfileRegistrationModel : PageModel
    {
        private readonly ShopContext _db;
        [BindProperty]
        public Client Client { get; set; }

        public ProfileRegistrationModel(ShopContext db)
        {
            _db = db;

        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _db.Client.AddAsync(Client);
            await _db.SaveChangesAsync();
            return RedirectToPage("Main");
        }
    }
}
