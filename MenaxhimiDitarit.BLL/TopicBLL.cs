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

        #region Absence
        public bool AddAbsence(Topic model)
        {
            return topicsDAL.AddAbsence(model);
        }

        public bool UpdateAbsence(Topic model)
        {
            throw new NotImplementedException();
        }

        public Topic GetAbsence(int id)
        {
            throw new NotImplementedException();
        }

        public List<Topic> GetAllAbsence()
        {
            return topicsDAL.GetAllAbsence();
        }

        public List<Topic> GetAllReview()
        {
            return topicsDAL.GetAllReview();
        }
        #endregion

        #region Comment
        public bool AddComment(Topic model)
        {
            return topicsDAL.AddComment(model);
        }

        public bool UpdateComment(Topic model)
        {
            return topicsDAL.UpdateComment(model);
        }

        public Topic GetComment(int id)
        {
            throw new NotImplementedException();
        }

        public List<Topic> GetAllComment()
        {
            return topicsDAL.GetAllComment();
        }
        #endregion

        #region Topic
        public bool AddTopic(Topic model)
        {
            return topicsDAL.AddTopic(model);
        }

        public bool UpdateTopic(Topic model)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTopic(int id)
        {
            return topicsDAL.RemoveTopic(id);
        }

        public Topic GetTopic(int id)
        {
            throw new NotImplementedException();
        }

        public List<Topic> GetAllTopic()
        {
            return topicsDAL.GetAllTopic();
        }
        #endregion
    }
}
