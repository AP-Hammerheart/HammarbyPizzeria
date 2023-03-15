using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HammarbyPizzeria.Data;
using HammarbyPizzeria.Models;

namespace HammarbyPizzeria.Pages.Shared.MenuItems
{
    public class DetailsModel : PageModel
    {
        private readonly HammarbyPizzeria.Data.HammarbyPizzeriaContext _context;

        public DetailsModel(HammarbyPizzeria.Data.HammarbyPizzeriaContext context)
        {
            _context = context;
        }

      public MenuItem MenuItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MenuItems == null)
            {
                return NotFound();
            }

            var menuitem = await _context.MenuItems.FirstOrDefaultAsync(m => m.id == id);
            if (menuitem == null)
            {
                return NotFound();
            }
            else 
            {
                MenuItem = menuitem;
            }
            return Page();
        }
    }
}
