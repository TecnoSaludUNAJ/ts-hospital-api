using System;
using System.Collections.Generic;
using TP_Domain.Entities;

namespace TP_Domain.Commands
{
    public interface IGenericRepository
    {
        IEnumerable<T> GetAll<T>() where T : class;
        T GetById<T>(Guid id) where T : class;
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete(Guid id);
    }
}