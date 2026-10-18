using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai2
{
    public class MangSoNguyen
    {
        private List<int> list;

        public MangSoNguyen(string chuoiMang)
        {
            list = chuoiMang.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();
        }

        public string XuatMang() => string.Join(" ", list);

        public void SapXepTang() => list.Sort();
        public void SapXepGiam() => list.Sort((x, y) => y.CompareTo(x));

        public int TimViTriTheoGiaTri(int giaTri) => list.IndexOf(giaTri);
        public int LayGiaTriTheoViTri(int viTri) => (viTri >= 0 && viTri < list.Count) ? list[viTri] : -1;

        public bool XoaTheoGiaTri(int val) => list.Remove(val);
        public void XoaTheoViTri(int idx)
        {
            if (idx >= 0 && idx < list.Count) list.RemoveAt(idx);
        }

        public void ThemPhanTu(int val, int idx)
        {
            if (idx >= 0 && idx <= list.Count) list.Insert(idx, val);
            else list.Add(val);
        }

        public int TongMang() => list.Sum();
        public int TongChan() => list.Where(x => x % 2 == 0).Sum();
        public int TongLe() => list.Where(x => x % 2 != 0).Sum();

        public int Max() => list.Count > 0 ? list.Max() : 0;
        public int Min() => list.Count > 0 ? list.Min() : 0;

        public void ThayThe(int cu, int moi)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == cu) list[i] = moi;
            }
        }

        public void ThayTheTaiViTri(int idx, int moi)
        {
            if (idx >= 0 && idx < list.Count) list[idx] = moi;
        }
    }
}