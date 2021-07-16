using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreWebApi.Controllers
{
    
    [ApiController]
    [Route("[controller]s")]
    public class BookController:ControllerBase
    {
          private static List<Book> BookList = new List<Book>(){
          new Book{
               Id=1,
               Title="Lean Starup",
               GenereId=1 ,//personal Grwtn
               PageCount=200,
               PublishDate= new DateTime(2001,6,12)
                  },
                   new Book{
               Id=2,
               Title="İnce Mehmet",
               GenereId=2 ,//personal Grwtn
               PageCount=710,
               PublishDate= new DateTime(1990,7,20)
                  },
                   new Book{
               Id=3,
               Title="Dune",
               GenereId=3 ,//personal Grwtn
               PageCount=540,
               PublishDate= new DateTime(2018,5,10)
                  }
        };


        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
            return bookList;
        }

        

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            var book = BookList.Where(book =>book.Id ==id).SingleOrDefault();
            return book;
        }
    }
}