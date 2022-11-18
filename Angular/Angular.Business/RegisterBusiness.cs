using Angular.Business.Interfaces;
using Angular.Models;
using Angular.Repository.Interfaces;
using Angular.Repository.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Business
{
    public class RegisterBusiness : IRegisterBusiness
    {
        private readonly IRegsiterRepository _registerRepository;
        private readonly IMapper _mapper;
        public RegisterBusiness(IRegsiterRepository regRepository , IMapper mapper)
        {
            _registerRepository = regRepository;
            _mapper = mapper;

        }

        public async Task< List<RegisterVM>> GetAllRegisters()
        {
            var registers =await _registerRepository.GetRegisters();
            
            return _mapper.Map<List<RegisterVM>>(registers);
        }

        public async Task<RegisterVM> InsertRegister(RegisterVM reg)
        {
           
            var result = await _registerRepository.InsertRegister(_mapper.Map<RegisterUser>(reg));
            
            return _mapper.Map<RegisterVM>(result);
            
        }
    }
}
