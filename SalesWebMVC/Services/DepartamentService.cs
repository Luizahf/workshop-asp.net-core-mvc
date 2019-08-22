using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartamentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public  async Task<List<Departament>> findAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
