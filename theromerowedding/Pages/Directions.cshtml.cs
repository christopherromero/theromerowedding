using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace theromerowedding.Pages
{
    public class DirectionsModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Directions to The Wedding.";
        }
    }
}
