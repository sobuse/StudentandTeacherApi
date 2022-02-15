﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher.Repo.GenericRepository.Interface
{
    public  interface IRepositoryBase<T>
    {
        Task<IQueryable<T>> FindAllAsync(bool trackChanges);
        Task<IQueryable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChanges);
        Task CraeteAsync (T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
