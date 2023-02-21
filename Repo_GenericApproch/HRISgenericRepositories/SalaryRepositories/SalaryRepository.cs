using HRIS.DatabaseContext;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.Loan;
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
    public class SalaryRepository : GenericRepository<Salary>, ISalaryRepository
    {
        public SalaryRepository(HRISdbContext dbContext) : base(dbContext)
        {
        }



        public override Task<List<Salary>> GetAllAsync()
        {
            return base.GetAllAsync();
        }



        public override async Task<Salary> GetAsync(int id)
        {
            var salary = await dbSet.FirstOrDefaultAsync(item => item.SalaryId == id);
            return salary;
        }



        public override async Task<bool> AddEntity(Salary entity)
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


        public override async Task<bool> UpdateEntity(Salary entity)
        {
            try
            {
                var existdata = await dbSet.FirstOrDefaultAsync(item => item.SalaryId == entity.SalaryId);

                if (existdata != null)
                {
                    existdata.SalaryId = entity.SalaryId;
                    existdata.EmployeeId = entity.EmployeeId;
                    existdata.SalaryMonthDate = entity.SalaryMonthDate;
                    existdata.EscId = entity.EscId;

                    existdata.GrossPay = entity.GrossPay;
                    existdata.Tax = entity.Tax;
                    existdata.NetPayout = entity.NetPayout;
                    existdata.StateId = entity.StateId;

                    existdata.CreateDate = entity.CreateDate;
                    existdata.CreateBy = entity.CreateBy;
                    existdata.LastUpdateDate = entity.LastUpdateDate;
                    existdata.UpdateBy = entity.UpdateBy;

                    existdata.ApproverId = entity.ApproverId;
                    existdata.ApproveDate = entity.ApproveDate;
                    existdata.CompanyId = entity.CompanyId;
                    existdata.GradeId = entity.GradeId;

                    existdata.DesignationId = entity.DesignationId;
                    existdata.DivisionId = entity.DivisionId;
                    existdata.DepartmentId = entity.DepartmentId;
                    existdata.LocationId = entity.LocationId;

                    existdata.EmployeeTypeId = entity.EmployeeTypeId;
                    existdata.BankAccountNo = entity.BankAccountNo;

                    existdata.SalaryRemarks = entity.SalaryRemarks;
                    existdata.PaymentBy = entity.PaymentBy;
                    existdata.PaymentDate = entity.PaymentDate;
                    existdata.IsBankPayment = entity.IsBankPayment;

                    existdata.BankPaymentBy = entity.BankPaymentBy;
                    existdata.BankPaymentDate = entity.BankPaymentDate;
                    existdata.IsCashPayment = entity.IsCashPayment;
                    existdata.CashPaymentBy = entity.CashPaymentBy;
                    existdata.CashPaymentDate = entity.CashPaymentDate;
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
            var existdata = await dbSet.FirstOrDefaultAsync(item => item.SalaryId == id);
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

        public Task<Salary> GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        //public async Task<Salary> GetAsync(string name)
        //{
        //    var salary = await dbSet.FirstOrDefaultAsync(item => item.Salary == name);
        //    return salary;
        //}
    }
}
