using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVCUI.Services;

namespace SalesWebMVCUI.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerServices _sellerServives;

        public SellersController(SellerServices sellerServices)
        {
            _sellerServives = sellerServices;
        }

        public IActionResult Index()
        {
            var list = _sellerServives.FindAll();
            return View(list);
        }
    }
}