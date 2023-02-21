using HRIS.DatabaseContext;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.SalaryInformation;
using HRISgenericInterfaces.SalaryIntercaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericRepositories.SalaryRepositories
{
    public class BonusPaymentRepository : GenericRepository<BonusPayment>, IBonusPaymentRepository
    {
        public BonusPaymentRepository(HRISdbContext dbContext) : base(dbContext)
        {

        }
        public override Task<List<BonusPayment>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<BonusPayment> GetAsync(int id)
        {
            var bonusPayment = await dbSet.FirstOrDefaultAsync(item => item.BonusPaymentId == id);
            return bonusPayment;
        }



        public override async Task<bool> AddEntity(BonusPayment entity)
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


        public override async Task<bool> UpdateEntity(BonusPayment entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.BonusPaymentId == entity.BonusPaymentId);

                if (existdata != null)
                {
                    existdata.BonusPaymentId = entity.BonusPaymentId;
                    existdata.EmployeeId = entity.EmployeeId;
                    existdata.ScId = entity.ScId;
                    existdata.ScAmount = entity.ScAmount;

                    existdata.NetPayout = entity.NetPayout;
                    existdata.PaymentMonthDate = entity.PaymentMonthDate;
                    existdata.GenerateBy = entity.GenerateBy;
                    existdata.GenerateDate = entity.GenerateDate;

                    existdata.ApproveBy = entity.ApproveBy;
                    existdata.ApproveDate = entity.ApproveDate;
                    existdata.PaymentBy = entity.PaymentBy;
                    existdata.PaymentDate = entity.PaymentDate;

                    existdata.StatusId = entity.StatusId;
                    existdata.BankId = entity.BankId;
                    existdata.BranchId = entity.BranchId;
                    existdata.AccountNo = entity.AccountNo;

                    existdata.CompanyId = entity.CompanyId;
                    existdata.LocationId = entity.LocationId;

                    existdata.DepartmentId = entity.DepartmentId;
                    existdata.DesignationId = entity.DesignationId;
                    existdata.EmployeeTypeId = entity.EmployeeTypeId;
                    existdata.BankAccountNo = entity.BankAccountNo;

                    existdata.GradeId = entity.GradeId;
                    existdata.DivisionId = entity.DivisionId;
                    existdata.Remarks = entity.Remarks;
                    existdata.CutOffDate = entity.CutOffDate;
                    existdata.PaymentConfirmationDate = entity.PaymentConfirmationDate;

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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.BonusPaymentId == id);
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

        public Task<BonusPayment> GetAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
