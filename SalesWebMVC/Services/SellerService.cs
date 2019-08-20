﻿using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService()
        {}

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() =>
            _context.Seller.ToList();

        public void Insert(Seller obj)
        {
            obj.Departament = _context.Departament.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
