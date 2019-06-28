using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class UserDataAccessLayer
    {
        private readonly TestDBContext _db = new TestDBContext();

        public Users GetUserById(string id)
        {
            try
            {
                var guid = Guid.Parse(id);
                return _db.Users.Find(guid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
