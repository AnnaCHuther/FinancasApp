﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface de repositório generico
    /// </summary>
    /// <typeparam name="T">Tipo generico</typeparam>
    public interface IBaseRepository <T> 
        where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T? GetById(Guid id);
    }
}