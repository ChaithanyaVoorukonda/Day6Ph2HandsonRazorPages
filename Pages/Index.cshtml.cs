﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExampleRazor.Models;

namespace ExampleRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ExampleRazor.Models.AppDbContext _context;

        public IndexModel(ExampleRazor.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
