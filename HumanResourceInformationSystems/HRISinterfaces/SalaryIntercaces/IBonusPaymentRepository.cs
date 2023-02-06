using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericInterfaces.SalaryIntercaces
{
    public interface IBonusPaymentRepository:IGenericRepository<BonusPayment>
    {
        Task<BonusPayment> GetAsync(string name);
    }
}
