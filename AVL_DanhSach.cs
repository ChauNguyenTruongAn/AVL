using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    class AVL_DanhSach
    {
        AVL root;
        DanhSachSV dssv;

        public AVL_DanhSach()
        {
            root = new AVL();
            dssv = new DanhSachSV();
        }

        public void Add(CSinhVien sv)
        {
            root.Insert(ref root.root, sv);
            dssv.DanhSach.Add(sv);
        }

        public void Delete(CSinhVien sv)
        {
            root.Delete(ref root.root, sv);
            dssv.DanhSach.Remove(sv);
        }

        public void Show()
        {
            root.show2D(root.root, 0);
            //dssv.Show();
        }
    }
}
