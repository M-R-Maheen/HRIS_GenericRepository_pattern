using HRIS.DatabaseContext;
using HRIS.Interfaces;
using HRISgenericInterfaces.AttendenceInterfaces;
using HRISdatabaseModels.DatabaseModels.AttendenceInformation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Repositories;

namespace HRISgenericRepositories.AttendenceRepositary
{
    public class DailyAttendencesRepositary : GenericRepository<DailyAttendence>, IDailyAttendenceRepositary

    {

        public DailyAttendencesRepositary(HRISdbContext dbContext):base(dbContext)
        {

        }

        public async Task<bool> AddEntity(DailyAttendence entity)
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.AttendanceId == id);
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

        public Task<List<DailyAttendence>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override async Task<DailyAttendence> GetAsync(int id)
        {
            var dailyAttendence = await dbSet.FirstOrDefaultAsync(item => item.AttendanceId == id);
            return dailyAttendence;
        }

        public override async Task<bool> UpdateEntity(DailyAttendence entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.AttendanceId == entity.AttendanceId);

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
                    existdata.AttendanceDate = entity.AttendanceDate;
                    existdata.LoginTime = entity.LoginTime;
                    existdata.LogoutTime = entity.LogoutTime;
                    existdata.Status = entity.Status;
                    existdata.IsHoliDay = entity.IsHoliDay;
                    existdata.RosterIntime = entity.RosterIntime;
                    existdata.RosterOutTime = entity.RosterOutTime;
                    existdata.GraceIn = entity.GraceIn;
                    existdata.GraceOut = entity.GraceOut;
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

        

