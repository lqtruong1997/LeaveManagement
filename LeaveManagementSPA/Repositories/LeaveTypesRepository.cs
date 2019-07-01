using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagementSPA.Models;

namespace LeaveManagementSPA.Repositories
{
    public class LeaveTypesRepository
    {
        private readonly LeaveManagementDBContext _db = new LeaveManagementDBContext();

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
