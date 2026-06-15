using HR_LeaveManagement.Application.DTOs;
using HR_LeaveManagement.Application.Features.LeaveTypes.Requests;
using HR_LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR_LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository)
        {
           this._leaveTypeRepository = leaveTypeRepository;
        }
        public Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            // TODO: implement using your repository / mapper
            throw new NotImplementedException();
        }
    }
}
