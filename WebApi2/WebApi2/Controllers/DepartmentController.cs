using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    public class DepartmentController : ApiController
    {
        private DepartmentRepository<Department> repo = new DepartmentRepository<Department>();

        public IEnumerable<Department> GetAllDepartments()
        {
            return repo.GetAll();
        }

        public Department GetDepartment(int id)
        {
            return repo.FindByKey(id);
        }

        [HttpPost]
        public Department CreateDepartment(Department item)
        {
            repo.Add(item);
            repo.SaveChanges();
            return item;
        }

        [HttpPut]
        public bool UpdateDepartment(Department item)
        {
            if (repo.FindByKey(item.Id) != null)
            {
                repo.Update(item);

                repo.SaveChanges();
                return true;
            }
            return false;
        }

        public void DeleteDepartment(int id)
        {
            Department Department = repo.FindByKey(id);
            if (Department != null)
            {
                repo.Delete(Department);
                repo.SaveChanges();
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
