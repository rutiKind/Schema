using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Service
{
    public class userService
    {
        private readonly MydbContext _dbContext;

        public userService(MydbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Adduser(User user)
        {
            _dbContext.users.InsertOne(user);
        }

        public User GetUserByfirstName(string firstName)
        {
            return _dbContext.users.Find(c => c.firstName == firstName).FirstOrDefault();
        }
    }

}
