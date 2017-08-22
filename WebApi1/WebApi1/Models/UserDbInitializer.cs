using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApi1.Models;


namespace WebApi1.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.user.Add(new User { Name = "name1" , DepartmentId = 1});
            context.user.Add(new User { Name = "name2", DepartmentId=2 });
            base.Seed(context);
        }

    }
}