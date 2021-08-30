using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core
{
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        void Add(T entity);
        

    }
}
