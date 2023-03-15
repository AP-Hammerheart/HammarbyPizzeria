using HammarbyPizzeria.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HammarbyPizzeria.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        private readonly HammarbyPizzeriaContext _context;

        public IndexModel( ILogger<IndexModel> logger, HammarbyPizzeriaContext context ) {
            _logger = logger;
            _context = context;
        }

        public IList<Models.MenuItem> MenuItems {
            get; set;
        }

        public async Task OnGetAsync() {
            MenuItems = await _context.MenuItems.ToListAsync();
        }
    }
}