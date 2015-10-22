using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repository
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
        Department GetbyId(int id);
        void AddDepartment(Department department);
    }
}
