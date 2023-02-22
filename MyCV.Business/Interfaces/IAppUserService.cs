using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.Interfaces
{
    public interface IAppUserService: IGenericService<AppUser>
    {
        bool CheckUser(string userName, string password);
        AppUser FindByUserName(string userName);
    }
}
