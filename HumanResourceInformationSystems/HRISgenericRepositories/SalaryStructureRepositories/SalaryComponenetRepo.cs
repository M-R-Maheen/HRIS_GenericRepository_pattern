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
    public class SalaryComponenetRepo: GenericRepository<SalaryComponent>, ISalaryComponent
    {

        public SalaryComponenetRepo(HRISdbContext dbContext) : base(dbContext)
        {

        }
        public override Task<List<SalaryComponent>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<SalaryComponent> GetAsync(int id)
        {
            var sc = await dbSet.FirstOrDefaultAsync(item => item.ScId == id);
            return sc;
        }



        public override async Task<bool> AddEntity(SalaryComponent entity)
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


        public override async Task<bool> UpdateEntity(SalaryComponent entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.ScId == entity.ScId);

                if (existdata != null)
                {
                    existdata.ScCode = entity.ScCode;
                    existdata.ScName = entity.ScName;
                    existdata.ScType = entity.ScType;
                    existdata.IsActive = entity.IsActive;
                    existdata.CreateBy = entity.CreateBy;
                    existdata.CreateDate = entity.CreateDate;
                    existdata.UpdateBy = entity.UpdateBy;
                    existdata.UpdateDate = entity.UpdateDate;
                    existdata.IsBonus = entity.IsBonus;
                    existdata.BonusEligibility = entity.BonusEligibility;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.ScId == id);
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
