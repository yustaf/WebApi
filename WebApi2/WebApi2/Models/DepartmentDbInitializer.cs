using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApi2.Models;


namespace WebApi2.Models
{
    public class DepartmentDbInitializer : DropCreateDatabaseAlways<DepartmentContext>
    {
        protected override void Seed(DepartmentContext context)
        {
            context.department.Add(new Department { Title = "Marketing" });
            context.department.Add(new Department { Title = "IT department" });
            base.Seed(context);
        }

    }
}