using HRIS.DatabaseContext;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.SalaryInformation;
using HRISgenericInterfaces.SalaryIntercaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericRepositories.SalaryRepositories
{
    public class SalaryDetailRepository : GenericRepository<SalaryDetail>, ISalaryDetailRepository
    {
        public SalaryDetailRepository(HRISdbContext dbContext) : base(dbContext)
        {

        }


        public override Task<List<SalaryDetail>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<SalaryDetail> GetAsync(int id)
        {
            var salaryDetail = await dbSet.FirstOrDefaultAsync(item => item.SalaryDetailsId == id);
            return salaryDetail;
        }



        public override async Task<bool> AddEntity(SalaryDetail entity)
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


        public override async Task<bool> UpdateEntity(SalaryDetail entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.SalaryDetailsId == entity.SalaryDetailsId);

                if (existdata != null)
                {
                    existdata.SalaryDetailsId = entity.SalaryDetailsId;
                    existdata.SalaryId = entity.SalaryId;
                    existdata.ScId = entity.ScId;
                    existdata.ScAmount = entity.ScAmount;

                    existdata.ScType = entity.ScType;
                    existdata.SalaryMonthDate = entity.SalaryMonthDate;
                    existdata.LoanScheduleId = entity.LoanScheduleId;
                    existdata.Arear = entity.Arear;

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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.SalaryDetailsId == id);
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

        public Task<SalaryDetail> GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        //public async Task<SalaryDetail> GetAsync(string name)
        //{
        //    var salaryDetail = await dbSet.FirstOrDefaultAsync(item => item.SalaryDetail == name);
        //    return salaryDetail;
        //}
    }
}
