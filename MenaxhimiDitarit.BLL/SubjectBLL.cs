using System.Collections.Generic;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;
using MenaxhimiDitarit.DAL;

namespace MenaxhimiDitarit.BLL
{
    public class SubjectBLL : IBaseCRUD<Subject>
    {
        private SubjectDAL subjectDAL;

        public SubjectBLL()
        {
            subjectDAL = new SubjectDAL();
        }

        public bool Add(Subject model)
        {
            return subjectDAL.Add(model);
        }

        public Subject Get(int id)
        {
            return subjectDAL.Get(id);
        }

        public List<Subject> GetAll()
        {
            return subjectDAL.GetAll();
        }

        public bool Remove(int id)
        {
            return subjectDAL.Remove(id);
        }

        public bool Update(Subject model)
        {
            return subjectDAL.Update(model);
        }
    }
}
