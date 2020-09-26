using System;
using System.Collections.Generic;
using TP_Domain.Entities;

namespace TP_Domain.Commands
{
    public interface IGenericsRepository
    {
        void Add<T>(T entity) where T : class;     
        void Update<T>(T entity) where T : class;
        void Delete(int id);
    }
}