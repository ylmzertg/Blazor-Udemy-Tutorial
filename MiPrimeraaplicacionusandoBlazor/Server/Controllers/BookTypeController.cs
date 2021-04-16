using Microsoft.AspNetCore.Mvc;
using MiPrimeraaplicacionusandoBlazor.Server.Models;
using MiPrimeraaplicacionusandoBlazor.Shared;
using System.Collections.Generic;
using System.Linq;

namespace MiPrimeraaplicacionusandoBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GetBookTypeList")]
        public List<BookTypeCLS> Get()
        {
            List<BookTypeCLS> bookList = new List<BookTypeCLS>();
            using (BlazorLibraryDBContext db = new BlazorLibraryDBContext())
            {

                bookList = (from bookType in db.BookTypes
                            where bookType.Active == 1
                            select new BookTypeCLS
                            {
                                Id = bookType.Id,
                                BookTypeName = bookType.BookTypeName,
                                Description = bookType.Description
                            }).ToList();
            }
            return bookList;
        }

        [HttpGet("Filter/{data?}")]
        public List<BookTypeCLS> Filter(string data)
        {
            List<BookTypeCLS> bookList = new List<BookTypeCLS>();
            using (BlazorLibraryDBContext db = new BlazorLibraryDBContext())
            {
                if (data == null)
                {
                    bookList = (from bookType in db.BookTypes
                                where bookType.Active == 1
                                select new BookTypeCLS
                                {
                                    Id = bookType.Id,
                                    BookTypeName = bookType.BookTypeName,
                                    Description = bookType.Description
                                }).ToList();
                }
                else
                {
                    bookList = (from bookType in db.BookTypes
                                where
                                bookType.Active == 1
                                && bookType.BookTypeName.Contains(data)
                                select new BookTypeCLS
                                {
                                    Id = bookType.Id,
                                    BookTypeName = bookType.BookTypeName,
                                    Description = bookType.Description
                                }).ToList();
                }
            }
            return bookList;
        }

    }
}
