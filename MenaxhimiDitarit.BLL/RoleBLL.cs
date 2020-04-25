using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.DAL;
using MenaxhimiDitarit.BO.Interface;

namespace MenaxhimiDitarit.BLL
{
    public class RoleBLL : IBaseCRUD<Roles>
    {
        private readonly RolesDAL rolesDAL;

        public RoleBLL()
        {
            rolesDAL = new RolesDAL();
        }

        public bool Add(Roles model)
        {
            return rolesDAL.Add(model);
        }

        public Roles Get(int id)
        {
            return rolesDAL.Get(id);
        }

        public Roles Get(Roles model)
        {
            return rolesDAL.Get(model);
        }

        public List<Roles> GetAll()
        {
            return rolesDAL.GetAll();
        }

        public bool Remove(Roles model)
        {
            return rolesDAL.Remove(model);
        }

        public bool Remove(int id)
        {
            return rolesDAL.Remove(id);
        }

        public bool Update(Roles model)
        {
            return rolesDAL.Update(model);
        }
    }
}
