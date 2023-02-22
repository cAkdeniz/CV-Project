using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.DataAccess.Interfaces
{
    public interface ISocialMediaIconDal: IGenericDal<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
