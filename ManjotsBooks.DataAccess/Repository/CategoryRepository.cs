﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManjotsBooks.DataAccess.Repository.IRepository;
using ManjotsBooks.Models;
using ManjotsBookStore.DataAccess.Data;

namespace ManjotsBooks.DataAccess.Repository
{
  public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
