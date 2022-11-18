using Angular.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Repository.Interfaces
{
    public interface IRegsiterRepository
    {
        Task<List<RegisterUser>> GetRegisters();
        Task<RegisterUser> InsertRegister(RegisterUser reg);
    }
}
