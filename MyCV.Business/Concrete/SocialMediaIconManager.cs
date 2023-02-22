using MyCV.Business.Interfaces;
using MyCV.DataAccess.Interfaces;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCV.Business.Concrete
{
    public class SocialMediaIconManager: GenericManager<SocialMediaIcon>, ISocialMediaService
    {
        private IGenericDal<SocialMediaIcon> _genericDal;
        private ISocialMediaIconDal _socialMediaDal;
        public SocialMediaIconManager(IGenericDal<SocialMediaIcon> genericDal, ISocialMediaIconDal socialMediaDal)
            :base(genericDal)
        {
            _genericDal = genericDal;
            _socialMediaDal = socialMediaDal;
        }

        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _socialMediaDal.GetByUserId(userId);
        }
    }
}
