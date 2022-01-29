using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasControle.Data;
using VendasControle.Models;

namespace VendasControle.Services
{
    public class SellerService
    {
        private readonly VendasControleContext _context;

        public SellerService(VendasControleContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); 
        }
    }
}
