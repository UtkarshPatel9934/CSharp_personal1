using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace W0785541.Pages
{
    public class Hobbies : PageModel
    {
        private readonly ILogger<Hobbies> _logger;

        public Hobbies(ILogger<Hobbies> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
