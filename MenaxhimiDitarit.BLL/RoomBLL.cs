using System.Collections.Generic;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;
using MenaxhimiDitarit.DAL;

namespace MenaxhimiDitarit.BLL
{
    public class RoomBLL : IBaseCRUD<Room>
    {
        private RoomDAL roomDAL;

        public RoomBLL()
        {
            roomDAL = new RoomDAL();
        }

        public bool Add(Room model)
        {
            return roomDAL.Add(model);
        }

        public Room Get(int id)
        {
            return roomDAL.Get(id);
        }

        public List<Room> GetAll()
        {
            return roomDAL.GetAll();
        }

        public bool Remove(int id)
        {
            return roomDAL.Remove(id);
        }

        public bool Update(Room model)
        {
            return roomDAL.Update(model);
        }
    }
}
