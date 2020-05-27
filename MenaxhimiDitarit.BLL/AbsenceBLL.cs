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
    public class AbsenceBLL : IBaseCRUD<Absence>
    {
        AbsencesDAL absencesDAL;

        public AbsenceBLL()
        {
            absencesDAL = new AbsencesDAL();
        }

        public bool Add(Absence model)
        {
            return absencesDAL.Add(model);
        }

        public List<Absence> GetAll()
        {
            return absencesDAL.GetAll();
        }

        public bool Remove(int id)
        {
            return absencesDAL.Remove(id);
        }

        public bool Update(Absence model)
        {
            throw new NotImplementedException();
        }

        public Absence Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
