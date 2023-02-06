using HRIS.DatabaseContext;
using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces.CompanyInterfaces;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Repositories.CompanyRepositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(HRISdbContext dbContext) : base(dbContext)
        {
        }

        public override Task<List<Department>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<Department> GetAsync(int id)
        {
            var department = await dbSet.FirstOrDefaultAsync(item => item.DepartmentId == id);
            return department;
        }



        public override async Task<bool> AddEntity(Department entity)
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


        public override async Task<bool> UpdateEntity(Department entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.DepartmentId == entity.DepartmentId);

                if (existdata != null)
                {
                    existdata.DepartmentName = entity.DepartmentName;
                    existdata.DepartmentCode = entity.DepartmentCode;                
                    existdata.DivisionId = entity.DivisionId;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.DepartmentId == id);
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
