using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    class Node
    {
        CSinhVien sv;
        int height;
        public Node left, right;

        public Node(CSinhVien sv)
        {
            this.sv = sv;
            this.height = 1;
            this.left = null;
            this.right = null;
        }
        public Node()
        {
            this.right = this.left = null;
            sv = null;
            this.height = 1;
        }
        public CSinhVien Sv
        {
            set { this.sv = value; }
            get { return this.sv; }
        }
        public int Height
        {
            set { this.height = value; }
            get { return this.height; }
        }
    }
}
