using HRIS.DatabaseContext;
using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces.CompanyInterfaces;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Repositories.CompanyRepositories
{
    public class DivisionRepository : GenericRepository<Division>, IDivisionRepository
    {
        public DivisionRepository(HRISdbContext dbContext) : base(dbContext)
        {
        }

        public override Task<List<Division>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<Division> GetAsync(int id)
        {
            var division = await dbSet.FirstOrDefaultAsync(item => item.DivisionId == id);
            return division;
        }



        public override async Task<bool> AddEntity(Division entity)
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


        public override async Task<bool> UpdateEntity(Division entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.DivisionId == entity.DivisionId);

                if (existdata != null)
                {
                    existdata.DivisionName = entity.DivisionName;
                    existdata.DivisionCode = entity.DivisionCode;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.DivisionId == id);
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
