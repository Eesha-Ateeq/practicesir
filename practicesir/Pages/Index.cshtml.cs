using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.model;
using WebApplication1.services;

namespace practicesir.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<book> Books { get ; private set; }
        public JsonBookFiless BookService;
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonBookFiless bookService)
        {
            _logger = logger;
            BookService = bookService;
        }

        public void OnGet()
        {
            Books = BookService.getBooksData();
        }
    }
}
