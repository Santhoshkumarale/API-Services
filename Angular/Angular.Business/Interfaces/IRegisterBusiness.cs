using Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Business.Interfaces
{
    public interface IRegisterBusiness
    {
        Task<List<RegisterVM>> GetAllRegisters();
        Task<RegisterVM> InsertRegister(RegisterVM reg);
       
    }
}
