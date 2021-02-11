using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskForSteadyPoint.IRepository;

namespace TaskForSteadyPoint.Supervisors
{
    public partial class Supervisor : ISupervisor
    {
        private IEmployeeRepository _IEmployeeRepository;
        private readonly IMapper _mapper;

        public Supervisor(IEmployeeRepository IEmployeeRepository , IMapper mapper)
        {
            _IEmployeeRepository = IEmployeeRepository;
            _mapper = mapper;
        }
    }
}
