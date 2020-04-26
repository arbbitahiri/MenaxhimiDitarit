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
    public class TopicBLL : IBaseCRUD<Topics>
    {
        private TopicsDAL topicsDAL;

        public TopicBLL()
        {
            topicsDAL = new TopicsDAL();
        }

        public bool Add(Topics model)
        {
            return topicsDAL.Add(model);
        }

        public Topics Get(int id)
        {
            throw new NotImplementedException();
        }

        public Topics Get(Topics model)
        {
            throw new NotImplementedException();
        }

        public List<Topics> GetAll()
        {
            return topicsDAL.GetAll();
        }

        public bool Remove(Topics model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            return topicsDAL.Remove(id);
        }

        public bool Update(Topics model)
        {
            throw new NotImplementedException();
        }
    }
}
