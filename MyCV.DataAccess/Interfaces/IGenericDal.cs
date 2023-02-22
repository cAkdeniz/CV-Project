using MyCV.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.DataAccess.Interfaces
{
    public interface IGenericDal<TEntity> where TEntity: class, IEntity ,new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
