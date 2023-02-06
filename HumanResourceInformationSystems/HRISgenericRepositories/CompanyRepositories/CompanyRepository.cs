using HRIS.DatabaseContext;
using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces.CompanyInterfaces;
using HRISdatabaseModels.DatabaseModels.CompanyInformation;
using HRISgenericInterfaces.CompanyInterfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HRIS.Repositories.CompanyRepositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(HRISdbContext dbContext) : base(dbContext)
        {
        }



        public override Task<List<Company>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<Company> GetAsync(int id)
        {
            var company = await dbSet.FirstOrDefaultAsync(item => item.CompanyId == id);           
            return company;
        }



        public override async Task<bool> AddEntity(Company entity)
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


        public override async Task<bool> UpdateEntity(Company entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.CompanyId == entity.CompanyId);

                if (existdata != null)
                {
                    existdata.CompanyName = entity.CompanyName;
                    existdata.CompanyAlias = entity.CompanyAlias;
                    existdata.Address = entity.Address;
                    existdata.Phone = entity.Phone;
                    existdata.Fax = entity.Fax;
                    existdata.Email = entity.Email;
                    existdata.Website = entity.Website;
                    existdata.CompanyRegisterNo = entity.CompanyRegisterNo;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.CompanyId == id);
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

        public async Task<Company> GetAsync(string name)
        {
            var company = await dbSet.FirstOrDefaultAsync(item => item.CompanyName == name);
            return company;
        }
    }
}
