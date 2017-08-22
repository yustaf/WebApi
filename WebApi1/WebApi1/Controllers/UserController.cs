using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi1.Models;

namespace WebApi1.Controllers
{
    public class UserController : ApiController
    {

        private UserRepository<User> repo = new UserRepository<User>();

        public IEnumerable<User> GetAllUsers()
        {
            return repo.GetAll();
        }

        public User GetUser(int id)
        {
            return repo.FindByKey(id);
        }

        [HttpPost]
        public User CreateUser(User item)
        {
            repo.Add(item);
            repo.SaveChanges();
            return item;
        }

        [HttpPut]
        public bool UpdateUser(User item)
        {
            if (repo.FindByKey(item.Id) != null)
            {
                repo.Update(item);

                repo.SaveChanges();
                return true;
            }
            return false;
        }

        public void DeleteUser(int id)
        {
            User User = repo.FindByKey(id);
            if (User != null)
            {
                repo.Delete(User);
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

