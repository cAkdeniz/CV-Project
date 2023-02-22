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
    public class DpAppUserRepository: DpGenericRepository<AppUser>, IAppUserDal
    {
        private IDbConnection _dbConnection;
        public DpAppUserRepository(IDbConnection dbConnection): base(dbConnection)
        {
            _dbConnection = dbConnection;
        }


        public bool CheckUser(string userName, string password)
        {
            var user = _dbConnection.Query<AppUser>("select * from AppUsers where UserName=@userName and Password=@password",
                new
                {
                    userName = userName,
                    password = password
                }).FirstOrDefault();

            if(user!=null)
            {
                return true;
            }
                return false;
        }

        public AppUser FindByUserName(string userName)
        {
            var user = _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where UserName=@userName", new
            {
                userName = userName
            });
            return user;
        }
    }
}
