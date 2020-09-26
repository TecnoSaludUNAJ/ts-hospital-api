﻿using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TP_AccessData.Commands
{
    public class GenericsRepository: IGenericsRepository
    {           
        private readonly TemplateDbContext _context;
        

        public GenericsRepository(TemplateDbContext templateDbContext)
        {
            _context = templateDbContext;        
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
       
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
     
    }
}
