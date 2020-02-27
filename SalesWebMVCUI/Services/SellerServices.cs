using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVCUI.Data;
using SalesWebMVCUI.Models;

namespace SalesWebMVCUI.Services
{
    public class SellerServices
    {
        private readonly SalesWebMVCUIContext _context;

        public SellerServices(SalesWebMVCUIContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
