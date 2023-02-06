using HRIS.DatabaseContext;
using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces.CompanyInterfaces;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Repositories.CompanyRepositories
{
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        public LocationRepository(HRISdbContext dbContext) : base(dbContext)
        {
        }


        public override Task<List<Location>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<Location> GetAsync(int id)
        {
            var locations = await dbSet.FirstOrDefaultAsync(item => item.LocationId == id);
            return locations;
        }



        public override async Task<bool> AddEntity(Location entity)
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


        public override async Task<bool> UpdateEntity(Location entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.LocationId == entity.LocationId);

                if (existdata != null)
                {
                    existdata.LocationName = entity.LocationName;
                    existdata.LocationAddress = entity.LocationAddress;
                    existdata.DepartmentId = entity.DepartmentId;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.LocationId == id);
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
