using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;
using MenaxhimiDitarit.DAL;

namespace MenaxhimiDitarit.BLL
{
    public class ClassBLL : IBaseCRUD<Class>
    {
        private ClassDAL classDAL;

        public ClassBLL()
        {
            classDAL = new ClassDAL();
        }

        public bool Add(Class model)
        {
            return classDAL.Add(model);
        }

        public Class Get(int id)
        {
            return classDAL.Get(id);
        }

        public Class Get(Class model)
        {
            return classDAL.Get(model);
        }

        public List<Class> GetAll()
        {
            return classDAL.GetAll();
        }

        public bool Remove(Class model)
        {
            return classDAL.Remove(model);
        }

        public bool Remove(int id)
        {
            return classDAL.Remove(id);
        }

        public bool Update(Class model)
        {
            return classDAL.Update(model);
        }
    }
}
