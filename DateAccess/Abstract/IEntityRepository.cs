﻿using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DateAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        //generic constrain filtereleme sistemi 
        List<T> GetAll(Expression<Func<T,bool>> filter=null); 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
