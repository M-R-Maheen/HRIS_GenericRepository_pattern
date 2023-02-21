using HRIS.DatabaseContext;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.Loan;
using HRISgenericInterfaces.EmployeeTaxAndLoanInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericRepositories.EmployeeTaxAndLoanRepositories
{
    public class LoanScheduleRepository:GenericRepository<LoanSchedule>,ILoanScheduleRepository
    {
        public LoanScheduleRepository(HRISdbContext dbContext) : base(dbContext)
        {

        }
        public override Task<List<LoanSchedule>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<LoanSchedule> GetAsync(int id)
        {
            var loanSchedule = await dbSet.FirstOrDefaultAsync(item => item.LoanScheduleId == id);
            return loanSchedule;
        }



        public override async Task<bool> AddEntity(LoanSchedule entity)
        {
            try
            {
                await dbSet.AddAsync(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public override async Task<bool> UpdateEntity(LoanSchedule entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.LoanScheduleId == entity.LoanScheduleId);

                if (existdata != null)
                {
                    existdata.LoanScheduleId = entity.LoanScheduleId;
                    existdata.LoanInformationId = entity.LoanInformationId;
                    existdata.EmiDate = entity.EmiDate;
                    existdata.EmiAmount = entity.EmiAmount;
                    existdata.PaidDate = entity.PaidDate;
                    existdata.IsPaid = entity.IsPaid;                    
                    existdata.CreateBy = entity.CreateBy;
                    existdata.CreateDate = entity.CreateDate;
                    existdata.UpdateBy = entity.UpdateBy;
                    existdata.UpdateDate = entity.UpdateDate;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }



        public override async Task<bool> DeleteEntity(int id)
        {
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.LoanScheduleId == id);
            if (existdata != null)
            {
                dbSet.Remove(existdata);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
