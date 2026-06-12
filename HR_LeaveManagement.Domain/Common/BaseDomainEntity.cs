using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_LeaveManagement.Domain.Common
{
    public class BaseDomainEntity
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; } = "";
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; } = "";
    }
}