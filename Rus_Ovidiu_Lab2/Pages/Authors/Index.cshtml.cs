using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rus_Ovidiu_Lab2.Data;
using Rus_Ovidiu_Lab2.Models;
using Rus_Ovidiu_Lab2.Models.ViewModels;

namespace Rus_Ovidiu_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Rus_Ovidiu_Lab2.Data.Rus_Ovidiu_Lab2Context _context;

        public IndexModel(Rus_Ovidiu_Lab2.Data.Rus_Ovidiu_Lab2Context context)
        {
            _context = context;
        }
       


        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}
