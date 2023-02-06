using HRIS.DatabaseContext;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.SalaryStructure;
using HRISgenericInterfaces.SalaryStructureInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericRepositories.SalaryStructureRepositories
{
    public class EmployeeSalaryStructureDetailRepo: GenericRepository<EmployeeSalaryStructureDetails>, IEmployeeSalaryStructureDetails
    {
        public EmployeeSalaryStructureDetailRepo(HRISdbContext dbContext) : base(dbContext)
        {

        }
        public override Task<List<EmployeeSalaryStructureDetails>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<EmployeeSalaryStructureDetails> GetAsync(int id)
        {
            var ess = await dbSet.FirstOrDefaultAsync(item => item.EscDetailsId == id);
            return ess;
        }



        public override async Task<bool> AddEntity(EmployeeSalaryStructureDetails entity)
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


        public override async Task<bool> UpdateEntity(EmployeeSalaryStructureDetails entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.EscDetailsId == entity.EscDetailsId);

                if (existdata != null)
                {
                    existdata.EssId = entity.EssId;
                    existdata.ScId = entity.ScId;
                    existdata.ScValue = entity.ScValue;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.EscDetailsId == id);
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
