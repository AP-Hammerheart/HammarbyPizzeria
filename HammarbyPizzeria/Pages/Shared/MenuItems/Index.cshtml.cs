﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly HammarbyPizzeria.Data.HammarbyPizzeriaContext _context;

        public IndexModel(HammarbyPizzeria.Data.HammarbyPizzeriaContext context)
        {
            _context = context;
        }

        public IList<MenuItem> MenuItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.MenuItems != null)
            {
                MenuItem = await _context.MenuItems.ToListAsync();
            }
        }
    }
}
