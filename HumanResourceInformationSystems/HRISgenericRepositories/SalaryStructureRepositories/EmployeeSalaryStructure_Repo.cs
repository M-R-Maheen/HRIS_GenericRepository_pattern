using HRIS.DatabaseContext;
using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces.CompanyInterfaces;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.SalaryStructure;
using HRISgenericInterfaces.SalaryStructureInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericRepositories.SalaryStructureRepositories
{
    public class EmployeeSalaryStructureRepo : GenericRepository<EmployeeSalaryStructure>, IEmployeeSalaryStructure
    {
        public EmployeeSalaryStructureRepo(HRISdbContext dbContext) : base(dbContext)
        {

        }
        public override Task<List<EmployeeSalaryStructure>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<EmployeeSalaryStructure> GetAsync(int id)
        {
            var ess = await dbSet.FirstOrDefaultAsync(item => item.EssId == id);
            return ess;
        }



        public override async Task<bool> AddEntity(EmployeeSalaryStructure entity)
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


        public override async Task<bool> UpdateEntity(EmployeeSalaryStructure entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.EssId == entity.EssId);

                if (existdata != null)
                {
                    existdata.EmployeeId = entity.EmployeeId;
                    existdata.EmployeeTypeId = entity.EmployeeTypeId;
                    existdata.GradeId = entity.GradeId;
                    existdata.GrossPay = entity.GrossPay;
                    existdata.NetTaxPayable = entity.NetTaxPayable;
                    existdata.EscApprobedBy = entity.EscApprobedBy;
                    existdata.EscApproveDate = entity.EscApproveDate;
                    existdata.Status = entity.Status;
                    existdata.CreateBy = entity.CreateBy;
                    existdata.CreateDate = entity.CreateDate;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.EssId == id);
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
