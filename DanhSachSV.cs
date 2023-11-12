using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    class DanhSachSV
    {
        private List<CSinhVien> danhSach;

        public DanhSachSV()
        {
            danhSach = new List<CSinhVien>();
        }

        public List<CSinhVien> DanhSach
        {
            set { danhSach = value; }
            get { return danhSach; }
        }
        public void Show()
        {
            foreach(CSinhVien sv in danhSach)
            {
                sv.Show();Console.WriteLine();
            }
        }
    }
}
