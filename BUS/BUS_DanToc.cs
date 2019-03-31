using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DanToc
    {
        DAL_DanToc danToc = new DAL_DanToc();

        public DAL_DanToc DanToc { get => danToc; set => danToc = value; }

        public bool Insert(DanToc dan)
        {
            return this.DanToc.Insert(dan);
        }

        public bool Delete(int danTocId)
        {
            return this.DanToc.Delete(danTocId);
        }

        public bool Update(DanToc dan)
        {
            return this.DanToc.Update(dan);
        }
        public DataTable GetData()
        {
            return this.DanToc.GetData();
        }
    }
}
