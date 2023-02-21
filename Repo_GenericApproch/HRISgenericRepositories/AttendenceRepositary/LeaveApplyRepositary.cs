using HRIS.DatabaseContext;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.AttendenceInformation;
using HRISgenericInterfaces.AttendenceInterfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericRepositories.AttendenceRepositary
{
    public class LeaveApplyRepositary:GenericRepository<LeaveApply>,ILeaveApplyRepositary
    {
        public LeaveApplyRepositary(HRISdbContext dbContext):base(dbContext)
        {

        }
        public async Task<bool> AddEntity(LeaveApply entity)
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.EmployeeLeaveId == id);
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

        public Task<List<LeaveApply>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<LeaveApply> GetAsync(int id)
        {
            var leaveApply = await dbSet.FirstOrDefaultAsync(item => item.EmployeeLeaveId == id);
            return leaveApply;
        }

        public override async Task<bool> UpdateEntity(LeaveApply entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.EmployeeLeaveId == entity.EmployeeLeaveId);

                if (existdata != null)
                {
                    existdata.EmployeeId = entity.EmployeeId;
                    existdata.Year = entity.Year;
                    existdata.LeaveTypeId = entity.LeaveTypeId;
                    existdata.LeaveApplyDate = entity.LeaveApplyDate;
                    existdata.LeaveReason = entity.LeaveReason;
                    existdata.LeaveApprovedBy = entity.LeaveApprovedBy;
                    existdata.Status = entity.Status;
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
