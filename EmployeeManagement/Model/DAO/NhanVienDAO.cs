using Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Model.DAO
{
    public class NhanVienDAO
    {
        QLNS db = null;

        public NhanVienDAO()
        {
            db = new QLNS();
        }

        public NHANVIEN Find(string MANV)
        {
            return db.NHANVIENs.Find(MANV);
        }

        public List<NHANVIEN> All()
        {
            return db.NHANVIENs.Include(n => n.CHUCVU).ToList();
        }

        public bool Delete(NHANVIEN nv)
        {
            try
            {
                db.NHANVIENs.Remove(Find(nv.MANV));
                db.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }
        }

        public NHANVIEN Create(NHANVIEN nv)
        {
            try
            {
                nv.MANV = MANV();
                nv.MATD = "DH";
                nv.TRANGTHAI = "BC";

                db.NHANVIENs.Add(nv);
                db.SaveChanges();

                // FK phải get sau
                nv.CHUCVU = new ChucVuDAO().Find(nv.MACV);
                nv.BOPHAN = new BoPhanDAO().Find(nv.MABP);
                return nv;
            }
            catch (Exception) { return null; }
        }

        public string MANV()
        {
            int so = 1;
            string MANV = "";

            do
            {
                string Cty = "VGG";
                string NTD = DateTime.Now.ToString("yy");
                string ID = string.Format("{0:00000}", so);
                MANV = Cty + NTD + ID;
                so++;
            }
            while (Find(MANV) != null);

            return MANV;
        }

        public NHANVIEN Update(NHANVIEN nv)
        {
            try
            {
                NHANVIEN update = Find(nv.MANV);
                update.HOTEN = nv.HOTEN;
                update.NGAYSINH = nv.NGAYSINH.Value.AddDays(1);
                update.EMAIL = nv.EMAIL;
                update.CMND = nv.CMND;
                update.SDT = nv.SDT;
                update.PHAI = nv.PHAI;
                update.MACV = nv.MACV;
                update.MABP = nv.MABP;
                db.SaveChanges();

                update.NGAYSINH = update.NGAYSINH.Value.AddDays(-1); // for display
                update.CHUCVU = new ChucVuDAO().Find(nv.MACV);
                return update;
            }
            catch (Exception) { return null; }
        }
    }
}
