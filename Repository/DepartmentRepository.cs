using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        HrmDataModelDataContext Context { get; set; }

        public DepartmentRepository()
        {
            Context = new HrmDataModelDataContext();
        }

        public List<Department> GetAll()
        {
            return Context.Departments.Select(dep=> new Department()
            {
                Id = dep.Id,
                Name = dep.Name,
                D_Description = dep.D_Description
            }).ToList();
        }

        public Department GetbyId(int id)
        {
            return Context.Departments.Select(dep => new Department()
            {
                Id = dep.Id,
                Name = dep.Name,
                D_Description = dep.D_Description
            }).FirstOrDefault(dep=>dep.Id==id);
        }

        public void AddDepartment(Department department)
        {
            //Context.Departments.;
           
        }

        public void Save()
        {
           
        }
    }
}
