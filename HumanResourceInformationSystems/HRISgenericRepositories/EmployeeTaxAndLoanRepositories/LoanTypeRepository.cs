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
    public class LoanTypeRepository : GenericRepository<LoanType>, ILoanTypeRepository
    {
        public LoanTypeRepository(HRISdbContext dbContext) : base(dbContext)
        {

        }
        public override Task<List<LoanType>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<LoanType> GetAsync(int id)
        {
            var loanType = await dbSet.FirstOrDefaultAsync(item => item.LoanTypeId == id);
            return loanType;
        }



        public override async Task<bool> AddEntity(LoanType entity)
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


        public override async Task<bool> UpdateEntity(LoanType entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.LoanTypeId == entity.LoanTypeId);

                if (existdata != null)
                {
                    existdata.LoanTypeId = entity.LoanTypeId;
                    existdata.LoanTypeName = entity.LoanTypeName;
                    existdata.MaximumLoanAmount = entity.MaximumLoanAmount;
                    existdata.TermsAndCondition = entity.TermsAndCondition;
                    existdata.LoanPurposeIsText = entity.LoanPurposeIsText;
                    existdata.JobLength = entity.JobLength;
                    existdata.Status = entity.Status;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.LoanTypeId == id);
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
