using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Users
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string LoginName { get; set; }
        public bool IsActive { get; set; }
    }
}
