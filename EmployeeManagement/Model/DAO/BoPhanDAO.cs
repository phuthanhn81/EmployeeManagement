using Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Model.DAO
{
    public class BoPhanDAO
    {
        QLNS db = null;

        public BoPhanDAO()
        {
            db = new QLNS();
        }

        public List<BOPHAN> All()
        {
            return db.BOPHANs.ToList();
        }

        public BOPHAN Find(string MABP)
        {
            return db.BOPHANs.Find(MABP);
        }
    }
}
