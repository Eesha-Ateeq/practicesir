using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using WebApplication1.model;
using WebApplication1.services;

namespace Book_Shop.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        JsonBookFiless BookService;

        public FormHandlerController(JsonBookFiless bookservice)
        {
            this.BookService = bookservice;
        }

        [HttpGet]
       public  string Get(int id, string name,string image)
        {
            book obj = new book();
            obj.book_id = id;
            obj.name = name;
            obj.image = image;

           IEnumerable<book> booksData= BookService.getBooksData();
           List<book> listofbooks= booksData.ToList();
            listofbooks.Add(obj);
           return  JsonSerializer.Serialize<List<book>>(listofbooks);
        }
    }


}
