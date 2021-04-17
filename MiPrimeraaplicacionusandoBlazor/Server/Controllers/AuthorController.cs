using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiPrimeraaplicacionusandoBlazor.Server.Models;
using MiPrimeraaplicacionusandoBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimeraaplicacionusandoBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {

        [HttpGet("deletedata/{data?}")]
        public int DeleteData(string data)
        {
            int changeRow = 0;
            try
            {
                using (var db = new BlazorLibraryDBContext())
                {
                    Author aut = db.Authors.Where(p => p.Id == Convert.ToInt32(data)).First();
                    aut.Active = 0;
                    db.SaveChanges();
                    return changeRow = 1;
                }
            }
            catch (Exception ex)
            {
                return changeRow = 0;
            }
        }

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
                              where author.Active == 1
                              select new AuthorCLS
                              {
                                  Id = author.Id,
                                  Fullname = author.Username,
                                  CountryName = country.CountryName,
                                  SexTypeName = gender.SexTypeName,
                                  Description = author.Description
                              }).ToList();
            }
            return listAuthor;
        }

        [HttpGet("listcountry")]
        public List<CountryCLS> CountryList()
        {
            List<CountryCLS> listCountry = new List<CountryCLS>();
            using (var db = new BlazorLibraryDBContext())
            {
                listCountry = (from country in db.Countries
                               where country.Active == 1
                               select new CountryCLS
                               {
                                   Id = country.Id,
                                   CountryName = country.CountryName
                               }).ToList();
            }
            return listCountry;
        }


        [HttpGet("filterauthor/{data?}")]
        public List<AuthorCLS> FilterAuthor(string data)
        {
            List<AuthorCLS> listAuthor = new List<AuthorCLS>();
            using (var db = new BlazorLibraryDBContext())
            {
                if (data != null || data == "--Selected One Item--")
                {
                    listAuthor = (from author in db.Authors
                                  join country in db.Countries
                                  on author.CountryId equals country.Id
                                  join gender in db.SexTypes
                                  on author.SexTypeId equals gender.Id
                                  where author.Active == 1 && author.Id == Convert.ToInt32(data)
                                  select new AuthorCLS
                                  {
                                      Id = author.Id,
                                      Fullname = author.Username,
                                      CountryName = country.CountryName,
                                      SexTypeName = gender.SexTypeName,
                                      Description = author.Description
                                  }).ToList();
                }
                return listAuthor;
            }
        }

    }
}
