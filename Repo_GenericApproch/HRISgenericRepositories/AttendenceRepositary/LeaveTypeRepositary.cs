using HRIS.DatabaseContext;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.AttendenceInformation;
using HRISgenericInterfaces.AttendenceInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericRepositories.AttendenceRepositary
{
    public class LeaveTypeRepositary:GenericRepository<LeaveType>,ILeaveTypeRepositary
    {
        public LeaveTypeRepositary(HRISdbContext dbContext):base(dbContext)
        {

        }
        public async Task<bool> AddEntity(LeaveType entity)
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

        public override async Task<bool> DeleteEntity(int id)
        {
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.LeaveTypeId == id);
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

        public Task<List<LeaveType>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<LeaveType> GetAsync(int id)
        {
            var leaveType = await dbSet.FirstOrDefaultAsync(item => item.LeaveTypeId == id);
            return leaveType;
        }

        public override async Task<bool> UpdateEntity(LeaveType entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.LeaveTypeId == entity.LeaveTypeId);

                if (existdata != null)
                {

                    existdata.TypeName = entity.TypeName;
                    existdata.LeaveTypeCode = entity.LeaveTypeCode;
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
    }
}
