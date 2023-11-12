using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    class AVL
    {
        public Node root;
        public AVL()
        {
            this.root = null;
        }
        private int getHeight(Node node)
        {
            if (node == null)
                return 0;
            return node.Height;
        }
        private void rightRotate(ref Node root)
        {
            Node temp = root.left;
            root.left = temp.right;
            temp.right = root;


            root.Height = 1 + Math.Max(getHeight(root.right), getHeight(root.left));
            temp.Height = 1 + Math.Max(getHeight(root.right), getHeight(root.left));

            root = temp;
            return;
        }

        public void leftRotate(ref Node root)
        {
            Node temp = root.right;
            root.right = temp.left;
            temp.left = root;

            root.Height = 1 + Math.Max(getHeight(root.left), getHeight(root.right));
            temp.Height = 1 + Math.Max(getHeight(temp.right), getHeight(root.left));

            root = temp;
            return;
        }

        public void Insert(ref Node root, CSinhVien sv)
        {
            if (root == null)
            {
                root = new Node(sv);
                return;
            }
            else
            {
                if (CSinhVien.Compare(sv, root.Sv) > 0)
                    Insert(ref root.right, sv);
                else if (CSinhVien.Compare(sv, root.Sv) < 0)
                    Insert(ref root.left, sv);
                else return;

                root.Height = 1 + Math.Max(getHeight(root.right), getHeight(root.left));

                int Balance = getHeight(root.left) - getHeight(root.right);

                if (Balance > 1 && CSinhVien.Compare(root.left.Sv, sv) > 0)
                {
                    rightRotate(ref root);
                    return;
                }
                if (Balance > 1 && CSinhVien.Compare(root.left.Sv, sv) < 0)
                {
                    leftRotate(ref root.left);
                    rightRotate(ref root.right);
                    return;
                }
                if (Balance < -1 && CSinhVien.Compare(root.right.Sv, sv) < 0)
                {
                    leftRotate(ref root);
                    return;
                }
                if (Balance < -1 && CSinhVien.Compare(root.right.Sv, sv) > 0)
                {
                    rightRotate(ref root.left);
                    leftRotate(ref root);
                    return;
                }
                return;
            }
        }


        private Node findMax(Node node)
        {
            if (node.left == null && node.right == null)
            {
                return node;
            }
            return findMax(node.right);
        }

        private int getBalance(Node node)
        {
            return getHeight(node.left) - getHeight(node.right);
        }

        public void Delete(ref Node root, CSinhVien sv)
        {
            if (root == null)
            {
                return;
            }
            if (CSinhVien.Compare(root.Sv, sv) > 0)
            {
                Delete(ref root.left, sv);
            }
            else if (CSinhVien.Compare(root.Sv, sv) < 0)
            {
                Delete(ref root.right, sv);
            }
            else
            {
                if (root.left == null && root.right == null)
                {
                    root = null;
                }
                else if (root.left == null && root.right != null)
                {
                    root = root.right;
                    root.right = null;
                }
                else if (root.left != null && root.right == null)
                {
                    root = root.left;
                    root.left = null;
                }
                else
                {
                    Node temp = findMax(root.left);
                    root.Sv = temp.Sv;
                    Delete(ref root.left, temp.Sv);
                }
            }
            if (root == null)
                return;

            root.Height = 1 + Math.Max(getHeight(root.left), getHeight(root.right));

            int Balance = getHeight(root.left) - getHeight(root.right);

            if (Balance > 1 && getBalance(root.left) >= 0)
            {
                rightRotate(ref root);
            }
            else if (Balance > 1 && getBalance(root.left) < 0)
            {
                leftRotate(ref root.left);
                rightRotate(ref root);
            }
            else if (Balance < -1 && getBalance(root.right) <= 0)
            {
                leftRotate(ref root);
            }
            else if (Balance < -1 && getBalance(root.right) > 0)
            {
                rightRotate(ref root.right);
                leftRotate(ref root);
            }
            return;
        }
        public void Show(Node node)
        {
            if (node != null)
            {
                node.Sv.Show();
                Show(node.left);
                Show(node.right);
            }
        }

        public void show2D(Node root, int space)
        {
            if (root == null)
            {
                return;
            }
            space += 10;

            show2D(root.right, space);
            Console.WriteLine();
            for (int i = 10; i < space; i++)
                Console.Write(" ");
            Console.Write(root.Sv.MaSo + " ({0}) " + "\n", root.Height);
            show2D(root.left, space);
        }
    }
}
