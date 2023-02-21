using HRIS.DatabaseContext;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.EmployeeTaxInformation;
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
    public class LoanInfoRepository:GenericRepository<LoanInformation>,ILoanInformationRepository
    {
        public LoanInfoRepository(HRISdbContext dbContext) : base(dbContext)
        {

        }
        public override Task<List<LoanInformation>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<LoanInformation> GetAsync(int id)
        {
            var loanInfo = await dbSet.FirstOrDefaultAsync(item => item.LoanInformationId == id);
            return loanInfo;
        }



        public override async Task<bool> AddEntity(LoanInformation entity)
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


        public override async Task<bool> UpdateEntity(LoanInformation entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.LoanInformationId == entity.LoanInformationId);

                if (existdata != null)
                {
                    existdata.LoanInformationId = entity.LoanInformationId;
                    existdata.LoanAmount = entity.LoanAmount;
                    existdata.InstalmentAmount = entity.InstalmentAmount;
                    existdata.TotalPaid = entity.TotalPaid;
                    existdata.DueAmount = entity.DueAmount;
                    existdata.Remarks = entity.Remarks;
                    existdata.LoanStartDate = entity.LoanStartDate;
                    existdata.CreateBy = entity.CreateBy;
                    existdata.CreateDate = entity.CreateDate;
                    existdata.ApproveBy = entity.ApproveBy;
                    existdata.ApproveDate = entity.ApproveDate;
                    existdata.Recomendation = entity.Recomendation;
                    existdata.RejectedBy = entity.RejectedBy;
                    existdata.RejectDate = entity.RejectDate;
                    existdata.Reason = entity.Reason;
                    existdata.DownpaymentAmount = entity.DownpaymentAmount;
                    existdata.LastUpdateDate = entity.LastUpdateDate;
                    existdata.UpdateBy = entity.UpdateBy;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.LoanInformationId == id);
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
