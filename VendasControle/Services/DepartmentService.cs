using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasControle.Data;
using VendasControle.Models;

namespace VendasControle.Services
{
    public class DepartmentService
    {
        private readonly VendasControleContext _context;
        public DepartmentService(VendasControleContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
