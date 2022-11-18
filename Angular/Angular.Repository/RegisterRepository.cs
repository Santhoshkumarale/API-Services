using Angular.Repository.Interfaces;
using Angular.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Repository
{
    public class RegisterRepository : IRegsiterRepository
    {
        private readonly rardbContext myContext;

        public RegisterRepository(rardbContext context)
        {
            myContext = context;

        }

        public async Task< List<RegisterUser>> GetRegisters()
        {
            return await myContext.RegisterUsers.ToListAsync();
        }

        public  async Task<RegisterUser> InsertRegister(RegisterUser reg)
        {
            var result = await myContext.AddAsync(reg);
            await myContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
