using Dapper;
using MyCV.DataAccess.Interfaces;
using MyCV.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyCV.DataAccess.Concrete.Dapper
{
    public class DpSocialMediaIconRepository: DpGenericRepository<SocialMediaIcon>, ISocialMediaIconDal
    {
        private IDbConnection _dbConnection;

        public DpSocialMediaIconRepository(IDbConnection dbConnection): base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _dbConnection.Query<SocialMediaIcon>("select * from SocialMediaIcons where AppUserId=@id", new
            {
                id = userId
            }).ToList();
        }
    }
}
