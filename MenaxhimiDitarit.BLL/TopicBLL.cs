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
    public class TopicBLL : IBaseCRUD<Topic>
    {
        private TopicsDAL topicsDAL;

        public TopicBLL()
        {
            topicsDAL = new TopicsDAL();
        }

        public bool Add(Topic model)
        {
            return topicsDAL.Add(model);
        }

        public Topic Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Topic> GetAll()
        {
            return topicsDAL.GetAll();
        }

        public bool Remove(int id)
        {
            return topicsDAL.Remove(id);
        }

        public bool Update(Topic model)
        {
            throw new NotImplementedException();
        }
    }
}
