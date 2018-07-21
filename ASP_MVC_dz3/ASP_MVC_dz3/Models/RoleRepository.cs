using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_dz3.Models
{
    public class RoleRepository : IRepository<Role>
    {
        private static RoleRepository _instanse;

        public static RoleRepository Instanse => _instanse ?? (_instanse = new RoleRepository());
        public RoleRepository() { }

        public List<Role> _role = new List<Role>();
        
        public void Add(Role item)
        {
            _role.Add(item);
        }
        public bool Delete(int id) => _role.Remove(Get(id));
        public Role Get(int id) => _role.Find(role => role.Id == id);
        public void FirstStart()
        {
            string[] role = { "Super Admin", "Administrator", "Editor", "Author", "Subscriber" };
            foreach (var item in role)
            {
                _role.Add(new Role { Id = _role.Count, Name = item });
            }
        }
    }
}