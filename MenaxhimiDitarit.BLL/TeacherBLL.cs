using System.Collections.Generic;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;
using MenaxhimiDitarit.DAL;

namespace MenaxhimiDitarit.BLL
{
    public class TeacherBLL : IBaseCRUD<Teacher>
    {
        private TeacherDAL teacherDAL;

        public TeacherBLL()
        {
            teacherDAL = new TeacherDAL();
        }

        public bool Add(Teacher model)
        {
            return teacherDAL.Add(model);
        }

        public Teacher Get(int id)
        {
            return teacherDAL.Get(id);
        }

        public List<Teacher> GetAll()
        {
            return teacherDAL.GetAll();
        }

        public bool Remove(int id)
        {
            return teacherDAL.Remove(id);
        }

        public bool Update(Teacher model)
        {
            return teacherDAL.Update(model);
        }
    }
}
