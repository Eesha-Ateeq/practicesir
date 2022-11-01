using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using WebApplication1.model;
using WebApplication1.services;

namespace Book_Shop.Pages
{
    public class BookListModel : PageModel
    {
        JsonBookFiless BookService;
         public IEnumerable<book> Books;

        public BookListModel(JsonBookFiless bookservice)
        {
            this.BookService = bookservice;
        }
        public void OnGet()
        {
            Books = BookService.getBooksData();
        }
    }
}
