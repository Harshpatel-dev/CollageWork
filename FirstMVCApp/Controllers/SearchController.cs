using FirstMVCApp;
using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstMVCApp.data;

namespace FirstMVCApp.Controllers
{
    public class SearchController : Controller
    {

        public readonly ApplicationDbContext _db;

        public SearchController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var subjects = from t in _db.Subject
                           select t;
            if (!String.IsNullOrEmpty(searchString))
            {
                subjects = subjects.Where(s => s.Subject_Name!.Contains(searchString));
            }

            return View(await subjects.ToListAsync());
        }


    }
}
