using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HammarbyPizzeria.Data;
using HammarbyPizzeria.Models;

namespace HammarbyPizzeria.Pages.Shared.MenuItems
{
    public class CreateModel : PageModel
    {
        private readonly HammarbyPizzeria.Data.HammarbyPizzeriaContext _context;

        public CreateModel(HammarbyPizzeria.Data.HammarbyPizzeriaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MenuItem MenuItem { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MenuItems.Add(MenuItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
