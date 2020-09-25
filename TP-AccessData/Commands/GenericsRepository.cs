using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Commands;
using TP_Domain.Entities;

namespace TP_AccessData.Commands
{
    public class GenericsRepository:IGenericRepository
    {           
        private readonly TemplateDbContext _context;

        public GenericsRepository(TemplateDbContext templateDbContext)
        {
            _context = templateDbContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add<T>(entity);
            _context.SaveChanges();
        }
       
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(Guid id) where T : class
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
