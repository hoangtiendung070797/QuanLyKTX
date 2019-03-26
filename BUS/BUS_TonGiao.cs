using DAL;
using DTO;

namespace BUS
{
    public class BUS_TonGiao
    {
        DAL_TonGiao tonGiao = new DAL_TonGiao();
        public bool Insert(TonGiao tonGiao)
        {
            return this.tonGiao.Insert(tonGiao);
        }

        public bool Delete(int tonGiaoId)
        {
            return this.tonGiao.Delete(tonGiaoId);
        }

        public bool Update(TonGiao tonGiao)
        {
            return this.tonGiao.Update(tonGiao);
        }

    }
}
