using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class MydbContext
    {
        public IMongoCollection<User> users { get; set; }
        public IMongoCollection<userType> userTypes { get; set; }


    }
}
