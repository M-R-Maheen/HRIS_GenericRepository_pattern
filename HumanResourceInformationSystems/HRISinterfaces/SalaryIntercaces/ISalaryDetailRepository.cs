using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericInterfaces.SalaryIntercaces
{
    public interface ISalaryDetailRepository:IGenericRepository<SalaryDetail>
    {
        Task<SalaryDetail> GetAsync(string name);

    }
}
