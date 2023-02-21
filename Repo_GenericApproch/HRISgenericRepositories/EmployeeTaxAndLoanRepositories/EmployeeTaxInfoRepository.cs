using HRIS.DatabaseContext;
using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.EmployeeTaxInformation;
using HRISgenericInterfaces.LoanInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericRepositories.EmployeeTaxAndLoanRepositories
{
    public class EmployeeTaxInfoRepository:GenericRepository<EmployeeTaxInfo>,IEmployeeTaxInfoRepository
    {
        public EmployeeTaxInfoRepository(HRISdbContext dbContext):base (dbContext) 
        {

        }
        public override Task<List<EmployeeTaxInfo>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<EmployeeTaxInfo> GetAsync(int id)
        {
            var employeeTaxInfo = await dbSet.FirstOrDefaultAsync(item => item.EmployeeTaxInfoId == id);
            return employeeTaxInfo;
        }



        public override async Task<bool> AddEntity(EmployeeTaxInfo entity)
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


        public override async Task<bool> UpdateEntity(EmployeeTaxInfo entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.EmployeeTaxInfoId == entity.EmployeeTaxInfoId);

                if (existdata != null)
                {
                    existdata.EmployeeTaxInfoId = entity.EmployeeTaxInfoId;
                    existdata.TaxAmount = entity.TaxAmount;
                    existdata.EffectiveDate = entity.EffectiveDate;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.EmployeeTaxInfoId == id);
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
