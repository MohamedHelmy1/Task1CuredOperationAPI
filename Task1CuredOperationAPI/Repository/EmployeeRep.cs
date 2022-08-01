using System;
using System.Collections.Generic;
using System.Linq;
using Task1CuredOperationAPI.Data;
using Task1CuredOperationAPI.Data.Model;

namespace Task1CuredOperationAPI.Repository
{
    public class EmployeeRep : IEmployeeRep
    {
        private readonly AplicationDbContext db;

        public EmployeeRep(AplicationDbContext db)
        {
            this.db = db;
        }
        public bool Add(EmployeeViewModel employee)
        {
            try
            {
                Employee obj = new Employee();
                obj.Id = new Guid();
                obj.Name = employee.Name;
                obj.City = employee.City;
                obj.SSN = employee.SSN;
                db.Employees.Add(obj);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            
            throw new NotImplementedException();
        }

        public bool Delete(Guid Id)
        {
            try
            {
                var data = db.Employees.Find(Id);
                db.Employees.Remove(data);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public IEnumerable<EmployeeViewModel> GetAll()
        {
            return db.Employees.Select(x => new EmployeeViewModel
            {
                Id = x.Id,
                Name = x.Name,
                City = x.City,
                SSN = x.SSN,

            });
        }

        public EmployeeViewModel GetById(Guid Id)
        {
            return db.Employees.Where(x=>x.Id==Id).Select(x => new EmployeeViewModel
            {
                Id = x.Id,
                Name = x.Name,
                City = x.City,
                SSN = x.SSN,

            }).FirstOrDefault();
        }

        public bool Update(Guid Id, EmployeeViewModel employee)
        {
            try
            {
                var data = db.Employees.Where(x => x.Id == Id).FirstOrDefault();
                data.Name = employee.Name;
                data.City = employee.City;
                data.SSN = employee.SSN;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;

            }

        }
    }
}
