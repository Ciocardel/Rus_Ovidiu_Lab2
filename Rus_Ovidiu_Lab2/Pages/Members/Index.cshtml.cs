using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rus_Ovidiu_Lab2.Data;
using Rus_Ovidiu_Lab2.Models;

namespace Rus_Ovidiu_Lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Rus_Ovidiu_Lab2.Data.Rus_Ovidiu_Lab2Context _context;

        public IndexModel(Rus_Ovidiu_Lab2.Data.Rus_Ovidiu_Lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
