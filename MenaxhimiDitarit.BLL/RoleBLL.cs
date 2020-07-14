using System.Collections.Generic;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.DAL;
using MenaxhimiDitarit.BO.Interface;

namespace MenaxhimiDitarit.BLL
{
    public class RoleBLL : IBaseCRUD<Role>
    {
        private readonly RoleDAL rolesDAL;

        public RoleBLL()
        {
            rolesDAL = new RoleDAL();
        }

        public bool Add(Role model)
        {
            return rolesDAL.Add(model);
        }

        public Role Get(int id)
        {
            return rolesDAL.Get(id);
        }

        public List<Role> GetAll()
        {
            return rolesDAL.GetAll();
        }

        public bool Remove(int id)
        {
            return rolesDAL.Remove(id);
        }

        public bool Update(Role model)
        {
            return rolesDAL.Update(model);
        }
    }
}
