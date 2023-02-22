using MyCV.Business.Interfaces;
using MyCV.DataAccess.Interfaces;
using MyCV.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        private IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public void Delete(TEntity entity)
        {
            _genericDal.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _genericDal.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public void Insert(TEntity entity)
        {
            _genericDal.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _genericDal.Update(entity);
        }
    }
}
