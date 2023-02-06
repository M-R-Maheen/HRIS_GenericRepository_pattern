using HRIS.DatabaseContext;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.CompanyInformation;
using HRISgenericInterfaces.CompanyInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericRepositories.CompanyRepositories
{
    public class RosterRepository : GenericRepository<Roster>, IRosterRepository
    {
        public RosterRepository(HRISdbContext dbContext) : base(dbContext)
        {


        }

        public override Task<List<Roster>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<Roster> GetAsync(int id)
        {
            var roster = await dbSet.FirstOrDefaultAsync(item => item.RosterId == id);
            return roster;
        }



        public override async Task<bool> AddEntity(Roster entity)
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


        public override async Task<bool> UpdateEntity(Roster entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.RosterId == entity.RosterId);

                if (existdata != null)
                {
                    existdata.RosterMonth = entity.RosterMonth;
                    existdata.LocationId = entity.LocationId;
                    existdata.RosterIntime = entity.RosterIntime;
                    existdata.RosterOuttime = entity.RosterOuttime;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.RosterId == id);
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
