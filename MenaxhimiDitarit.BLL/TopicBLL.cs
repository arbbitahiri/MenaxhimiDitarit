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
    public class TopicBLL : IBaseCRUDTopic<Topic>
    {
        private TopicsDAL topicsDAL;

        public TopicBLL()
        {
            topicsDAL = new TopicsDAL();
        }


        public bool AddAbsence(Topic model)
        {
            return topicsDAL.AddAbsence(model);
        }

        public bool AddTopic(Topic model)
        {
            return topicsDAL.AddTopic(model);
        }

        public Topic GetAbsence(int id)
        {
            throw new NotImplementedException();
        }

        public List<Topic> GetAllAbsence()
        {
            return topicsDAL.GetAllAbsence();
        }

        public List<Topic> GetAllTopic()
        {
            return topicsDAL.GetAllTopic();
        }

        public Topic GetTopic(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAbsence(int id)
        {
            return topicsDAL.RemoveAbsence(id);
        }

        public bool RemoveTopic(int id)
        {
            return topicsDAL.RemoveTopic(id);
        }

        public bool UpdateAbsence(Topic model)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTopic(Topic model)
        {
            throw new NotImplementedException();
        }
    }
}
