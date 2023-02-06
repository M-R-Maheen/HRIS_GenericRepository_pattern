using HRIS.DatabaseContext;
using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces.CompanyInterfaces;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Repositories.CompanyRepositories
{
    public class GradeRepository : GenericRepository<Grade>, IGradeRepository
    {
        public GradeRepository(HRISdbContext dbContext) : base(dbContext)
        {
        }


        public override Task<List<Grade>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<Grade> GetAsync(int id)
        {
            var Grade = await dbSet.FirstOrDefaultAsync(item => item.GradeId == id);
            return Grade;
        }



        public override async Task<bool> AddEntity(Grade entity)
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


        public override async Task<bool> UpdateEntity(Grade entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.GradeId == entity.GradeId);

                if (existdata != null)
                {
                    existdata.GradeName = entity.GradeName;
                    existdata.CompanyId = entity.CompanyId;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.GradeId == id);
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
