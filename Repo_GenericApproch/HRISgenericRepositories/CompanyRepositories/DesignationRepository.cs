using HRIS.DatabaseContext;
using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces.CompanyInterfaces;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Repositories.CompanyRepositories
{
    public class DesignationRepository : GenericRepository<Designation>, IDesignationRepository
    {
        public DesignationRepository(HRISdbContext dbContext) : base(dbContext)
        {
        }


        public override Task<List<Designation>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<Designation> GetAsync(int id)
        {
            var designation = await dbSet.FirstOrDefaultAsync(item => item.DesignationId == id);
            return designation;
        }



        public override async Task<bool> AddEntity(Designation entity)
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


        public override async Task<bool> UpdateEntity(Designation entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.DesignationId == entity.DesignationId);

                if (existdata != null)
                {
                    existdata.DesignationName = entity.DesignationName;
                    existdata.GradeId = entity.GradeId;
                    existdata.IsActive = entity.IsActive;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.DesignationId == id);
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
