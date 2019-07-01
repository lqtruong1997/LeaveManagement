using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagementSPA.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSPA.Repositories
{
    public class UserRepository
    {
        private readonly LeaveManagementDBContext _db = new LeaveManagementDBContext();

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
