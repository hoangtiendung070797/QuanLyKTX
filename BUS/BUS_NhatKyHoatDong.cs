using DAL;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class BUS_NhatKyHoatDong
    {
        DAL_NhatKyHoatDong nhatKyHoatDong = new DAL_NhatKyHoatDong();

        public DAL_NhatKyHoatDong NhatKyHoatDong { get => nhatKyHoatDong; set => nhatKyHoatDong = value; }

        public bool Insert(NhatKyHoatDong nhatKyHoatDong)
        {
            return this.NhatKyHoatDong.Insert(nhatKyHoatDong);
        }

        public bool Delete(int nhatKyHoatDongId)
        {
            return this.NhatKyHoatDong.Delete(nhatKyHoatDongId);
        }

        public bool Update(NhatKyHoatDong nhatKyHoatDong)
        {
            return this.NhatKyHoatDong.Update(nhatKyHoatDong);
        }
        public DataTable GetData()
        {
            return this.NhatKyHoatDong.GetData();
        }
        public DataTable GetDataByUser(string userName)
        {
            return this.NhatKyHoatDong.GetDataByUser(userName);
        }
        public DataTable GetDataByDate(DateTime date)
        {
            return this.NhatKyHoatDong.GetDataByDate(date);
        }
        public DataTable GetDataByAction(string action)
        {
            return this.NhatKyHoatDong.GetDataByAction(action);
        }

        public DataTable PrintfAllInfor()
        {
            return this.NhatKyHoatDong.PrintfAllInfor();
        }
        public DataTable GetDataByFunction(string fun)
        {
            return this.NhatKyHoatDong.GetDataByFunction(fun);
        }
        public DataTable GetDataByAllCondition(string userName, DateTime date, string action, string fun)
        {
            return this.NhatKyHoatDong.GetDataByAllCondition(userName,date,action,fun);
        }
    }
}
