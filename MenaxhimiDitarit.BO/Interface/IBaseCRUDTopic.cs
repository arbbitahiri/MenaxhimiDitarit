﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseCRUDTopic<T>
    {
        bool AddTopic(T model);
        bool UpdateTopic(T model);
        bool RemoveTopic(int id);

        List<T> GetAllTopic();
        T GetTopic(int id);

        bool AddAbsence(T model);
        bool UpdateAbsence(T model);

        List<T> GetAllAbsence();
        T GetAbsence(int id);

        bool AddComment(T model);
        bool UpdateComment(T model);

        List<T> GetAllComment();
        T GetComment(int id);
    }
}
