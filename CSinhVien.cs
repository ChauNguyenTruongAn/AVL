using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    class CSinhVien
    {
        string maso, lop, hoten, diachi;
        DateTime ngaysinh;
        bool phai;

        public CSinhVien(string maso, string lop, string hoten, string diachi, DateTime ngaysinh, bool phai)
        {
            this.maso = maso;
            this.lop = lop;
            this.hoten = hoten;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
            this.phai = phai;
        }

        public CSinhVien(CSinhVien sv)
        {
            this.maso = sv.maso;
            this.lop = sv.lop;
            this.hoten = sv.hoten;
            this.diachi = sv.diachi;
            this.ngaysinh = sv.ngaysinh;
            this.phai = sv.phai;
        }

        public CSinhVien()
        {
            this.maso = this.lop = this.hoten = this.diachi = "";
            this.ngaysinh = DateTime.Now;
            this.phai = true;
        }

        public string MaSo
        {
            set { this.maso = value; }
            get { return this.maso; }
        }

        public string Lop
        {
            set { this.lop = value; }
            get { return this.lop; }
        }
        public string Hoten
        {
            set { this.hoten = value; }
            get { return this.hoten; }
        }

        public string Diachi
        {
            set { this.diachi = value; }
            get { return this.diachi; }
        }
        public DateTime NgaySinh
        {
            set { this.ngaysinh = value; }
            get { return this.ngaysinh; }
        }
        public bool Phai
        {
            set { this.phai = value; }
            get { return this.phai; }
        }
        public void Show()
        {
            Console.Write(maso+"\t");
            Console.Write(hoten+"\t");
            Console.Write( lop+"\t");
            Console.Write( diachi+"\t");
            Console.Write(ngaysinh.ToString()+ "\t");
            if (phai)
            {
                Console.Write("Nam");
            }
            else
                Console.Write("Nu");
        }
        public static int Compare(CSinhVien a, CSinhVien b)
        {
            if (a.maso.Length != a.maso.Length) return a.maso.Length > b.maso.Length ? 1 : -1;
            for(int i = 0; i < a.MaSo.Length; i++)
            {
                if(a.MaSo[i] != b.MaSo[i])
                    return a.MaSo[i] > b.MaSo[i] ?1 : -1;
            }
            return 0;
        }
    } 
}
