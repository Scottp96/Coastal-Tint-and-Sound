using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFSecurityShell.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
    public class Car
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Brand")]
        public string Brand { get; set; }
        [Required]
        [Display(Name = "Year")]
        public string Year { get; set; }
        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Display(Name = "Color")]
        public string Color { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
    }

}