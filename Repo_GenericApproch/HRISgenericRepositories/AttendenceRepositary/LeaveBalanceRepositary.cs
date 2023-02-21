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
    public class LeaveBalanceRepositary:GenericRepository<LeaveBalance>,ILeaveBalanceRepositary
    {
        public LeaveBalanceRepositary(HRISdbContext dbContext):base(dbContext)
        {

        }
        public async Task<bool> AddEntity(LeaveBalance entity)
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.LeaveBalanceId == id);
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

        public Task<List<LeaveBalance>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<LeaveBalance> GetAsync(int id)
        {
            var leaveBalance = await dbSet.FirstOrDefaultAsync(item => item.LeaveBalanceId == id);
            return leaveBalance;
        }

        public override async Task<bool> UpdateEntity(LeaveBalance entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.LeaveBalanceId == entity.LeaveBalanceId);

                if (existdata != null)
                {
                    existdata.EmployeeId = entity.EmployeeId;
                    existdata.LeaveTypeId = entity.LeaveTypeId;
                    existdata.OpeningLeaveBalance = entity.OpeningLeaveBalance;
                    existdata.SpendedLeave = entity.SpendedLeave;
                    existdata.ClosingBalance = entity.ClosingBalance;
                    existdata.Year = entity.Year;
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
