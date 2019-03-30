using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_TonGiao
    {
        private DAL_TonGiao tonGiao = new DAL_TonGiao();

        public DAL_TonGiao TonGiao { get => tonGiao; set => tonGiao = value; }

        public bool Insert(TonGiao tonGiao)
        {
            return this.TonGiao.Insert(tonGiao);
        }

        public bool Delete(int tonGiaoId)
        {
            return this.TonGiao.Delete(tonGiaoId);
        }

        public bool Update(TonGiao tonGiao)
        {
            return this.TonGiao.Update(tonGiao);
        }

        public DataTable GetData()
        {
            return this.TonGiao.GetData();
        }
    }
}
