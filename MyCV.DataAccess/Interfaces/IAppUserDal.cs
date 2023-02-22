using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.DataAccess.Interfaces
{
    public interface IAppUserDal: IGenericDal<AppUser>
    {
        bool CheckUser(string userName, string password);
        AppUser FindByUserName(string userName);
    }
}
