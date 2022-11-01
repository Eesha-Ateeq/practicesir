using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.model;
using WebApplication1.services;

namespace Book_Shop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        JsonBookFiless BookService { get; }
        public BooksController(JsonBookFiless bookservice)
        {
            this.BookService= bookservice;
        }

        public IEnumerable<book> Get()
        {
           return  BookService.getBooksData();
        }
    }
}
