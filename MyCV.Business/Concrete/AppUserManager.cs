using MyCV.Business.Interfaces;
using MyCV.DataAccess.Interfaces;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.Concrete
{
    public class AppUserManager: GenericManager<AppUser>, IAppUserService
    {
        private IGenericDal<AppUser> _genericDal;
        private IAppUserDal _appUserDal;
        public AppUserManager(IGenericDal<AppUser> genericDal, IAppUserDal appUserDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _appUserDal = appUserDal;
        }

        public bool CheckUser(string userName, string password)
        {
            return _appUserDal.CheckUser(userName, password);
        }

        public AppUser FindByUserName(string userName)
        {
            return _appUserDal.FindByUserName(userName);
        }
    }
}
