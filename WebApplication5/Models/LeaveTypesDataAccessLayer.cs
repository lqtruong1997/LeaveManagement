using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class LeaveTypesDataAccessLayer
    {
        private readonly TestDBContext _db = new TestDBContext();

        public IEnumerable<LeaveTypes> GetLeaveTypes()
        {
            try
            {
                return _db.LeaveTypes;
            }
            catch
            {
                throw;
            }
        }

        public LeaveTypes GetLeaveTypesById(int id)
        {
            try
            {
                return _db.LeaveTypes.Find(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string GetLeaveTypeName(int id)
        {
            try
            {
                return _db.LeaveTypes.Find(id).Code;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
