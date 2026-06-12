using HR_LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_LeaveManagement.Domain
{
    public class LeaveAllocation: BaseDomainEntity
    {       
        public int NumberOfDays { get; set; }       
        public LeaveType LeaveType { get; set; } = null!;
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
