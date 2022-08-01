using System;
using System.Collections.Generic;
using Task1CuredOperationAPI.Data.Model;

namespace Task1CuredOperationAPI.Repository
{
    public interface IEmployeeRep
    {
        bool Add(EmployeeViewModel employee);
        IEnumerable<EmployeeViewModel> GetAll();
        EmployeeViewModel GetById(Guid Id);
        bool Update(Guid Id, EmployeeViewModel employee);
        bool Delete(Guid Id);

    }
}
