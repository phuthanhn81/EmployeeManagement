using Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Model.DAO
{
    public class ChucVuDAO
    {
        QLNS db = null;

        public ChucVuDAO()
        {
            db = new QLNS();
        }

        public List<CHUCVU> All()
        {
            return db.CHUCVUs.ToList();
        }

        public CHUCVU Find(string MACV)
        {
            return db.CHUCVUs.Find(MACV);
        }
    }
}
