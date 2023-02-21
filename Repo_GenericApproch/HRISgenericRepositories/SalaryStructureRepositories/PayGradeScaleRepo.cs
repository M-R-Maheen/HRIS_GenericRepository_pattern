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
    public class PayGradeScaleRepo: GenericRepository<PayGradeScale>, IPayGradeScale
    {
        public PayGradeScaleRepo(HRISdbContext dbContext) : base(dbContext)
        {

        }
        public override Task<List<PayGradeScale>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<PayGradeScale> GetAsync(int id)
        {
            var pay = await dbSet.FirstOrDefaultAsync(item => item.PayGradeScaleId == id);
            return pay;
        }



        public override async Task<bool> AddEntity(PayGradeScale entity)
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


        public override async Task<bool> UpdateEntity(PayGradeScale entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.PayGradeScaleId == entity.PayGradeScaleId);

                if (existdata != null)
                {
                    existdata.GradeId = entity.GradeId;
                    existdata.ScId = entity.ScId;
                    existdata.ScAmount = entity.ScAmount;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.PayGradeScaleId == id);
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
