using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRISgenericInterfaces.SalaryIntercaces
{
    public interface ISalaryRepository:IGenericRepository<Salary>
    {
        Task<Salary> GetAsync(string name);
    }
}
