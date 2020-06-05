using EmployeeManagement.Models;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Model.DAO
{
    public class ChamCongDAO
    {
        QLNS db = null;

        public ChamCongDAO()
        {
            db = new QLNS();
        }

        public List<BangCongView> Load(string mabp, DateTime dt)
        {
            List<BangCongView> listbc = new List<BangCongView>();
            try
            {
                List<BANGCONG> items = db.BANGCONGs.Include(n => n.NHANVIEN).
                                                    Include(n => n.LOAICONG).
                                                    Where(n => n.THANG == dt.Month &&
                                                               n.NAM == dt.Year &&
                                                               n.NHANVIEN.MABP == mabp).ToList();

                // object quá dài gây lỗi (cách fix khác ?)
                foreach (var item in items)
                {
                    BangCongView bc = new BangCongView();
                    bc.MANV = item.MANV;
                    bc.HOTEN = item.NHANVIEN.HOTEN;
                    bc.GIOVAO = item.GIOVAO;
                    bc.GIORA = item.GIORA;
                    bc.TENLC = item.LOAICONG.TENLC;
                    bc.NGAY = item.NGAY;
                    bc.THANG = item.THANG;
                    bc.NAM = item.NAM;

                    listbc.Add(bc);
                }
                return listbc;
            }
            catch (Exception) { return listbc; }
        }
    }
}
