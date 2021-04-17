using Microsoft.AspNetCore.Mvc;
using MiPrimeraaplicacionusandoBlazor.Server.Models;
using MiPrimeraaplicacionusandoBlazor.Shared;
using System.Collections.Generic;
using System.Linq;
namespace MiPrimeraaplicacionusandoBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {
        [HttpGet("listauthor")]
        public List<AuthorCLS> Index()
        {
            List<AuthorCLS> listAuthor = new List<AuthorCLS>();
            using (var db = new BlazorLibraryDBContext())
            {
                listAuthor = (from author in db.Authors
                              join country in db.Countries
                              on author.CountryId equals country.Id
                              join gender in db.SexTypes
                              on author.SexTypeId equals gender.Id
                              select new AuthorCLS
                              {
                                 Id = author.Id,
                                 Fullname = author.Username,
                                 CountryName = country.CountryName,
                                 SexTypeName =gender.SexTypeName,
                                 Description = author.Description
                              }).ToList();
            }
            return listAuthor;
        }
    }
}
