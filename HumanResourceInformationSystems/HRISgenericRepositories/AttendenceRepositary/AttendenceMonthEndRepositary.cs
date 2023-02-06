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
    public class AttendenceMonthEndRepositary:GenericRepository<AttendenceMonthEnd>,IAttendenceMonthEndRepositary
    {
        public AttendenceMonthEndRepositary(HRISdbContext dbContext):base(dbContext)
        {

        }
        public async Task<bool> AddEntity(AttendenceMonthEnd entity)
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.AttendanceMonthEndId == id);
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

        public Task<List<AttendenceMonthEnd>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<AttendenceMonthEnd> GetAsync(int id)
        {
            var attendenceMonthEnd = await dbSet.FirstOrDefaultAsync(item => item.AttendanceMonthEndId == id);
            return attendenceMonthEnd;
        }

        public override async Task<bool> UpdateEntity(AttendenceMonthEnd entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.AttendanceMonthEndId == entity.AttendanceMonthEndId);

                if (existdata != null)
                {
                    existdata.EmployeeId = entity.EmployeeId;
                    existdata.CompanyId = entity.CompanyId;
                    existdata.GradeId = entity.GradeId;
                    existdata.DesignationId = entity.DesignationId;
                    existdata.DivisionId = entity.DivisionId;
                    existdata.DepartmentId = entity.DepartmentId;
                    existdata.LocationId = entity.LocationId;
                    existdata.RosterId = entity.RosterId;
                    existdata.AttendanceMonth = entity.AttendanceMonth;
                    existdata.DaysOfMonth = entity.DaysOfMonth;
                    existdata.AbsentDays = entity.AbsentDays;
                    existdata.LeaveDays = entity.LeaveDays;
                    existdata.Holiday = entity.Holiday;
                    existdata.LateDeduction = entity.LateDeduction;
                    existdata.FinalDeductionDays = entity.FinalDeductionDays;
                    existdata.AcumulatedDays = entity.AcumulatedDays;
                    existdata.Status = entity.Status;
                    existdata.CreateBy = entity.CreateBy;
                    existdata.CreateDate = entity.CreateDate;
                    existdata.ApprovedBy = entity.ApprovedBy;
                    existdata.ApprovedDate = entity.ApprovedDate;
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
