using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace ASDLab3
{
    public class BinaryTree : IEnumerable<Student>
    {
        private IComparer<Student> comparer;
        private Node root;

        public class Node
        {
            public Student Data;
            public Node Right;
            public Node Left;
            public Node(Student data)
            {
                this.Data = data;
            }
        }

        public BinaryTree(IComparer<Student> comparer)
        {
            this.comparer = comparer;
            this.root = null;
        }

        public void Add(Student data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                AddTo(root, data);
            }
        }

        private void AddTo(Node node, Student data)
        {
            if (comparer.Compare(data, node.Data) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(data);
                }
                else
                {
                    AddTo(node.Left, data);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(data);
                }
                else
                {
                    AddTo(node.Right, data);
                }
            }
        }

        public void Delete(Student student)
        {
            Delete(ref root, student);
            
        }

        private void Delete(ref Node current, Student student)
        {
            if (current == null) return;

            int compare = comparer.Compare(student, current.Data);
            if (compare < 0)
            {
                Delete(ref current.Left, student);
            }
            else if (compare > 0)
            {
                Delete(ref current.Right, student);
            }
            else
            {
                if (current.Left == null && current.Right == null)
                {
                    current = null;
                }
                else if (current.Left == null)
                {
                    current = current.Right;
                }
                else if (current.Right == null)
                {
                    current = current.Left;
                }
                else
                {
                    Node minParent = current;
                    Node minNode = current.Right;

                    while (minNode.Left != null)
                    {
                        minParent = minNode;
                        minNode = minNode.Left;
                    }

                    current.Data = minNode.Data;

                    Delete(ref minParent.Left, minNode.Data);
                }
            }
        }

        public IEnumerable<Student> PostOrderTraversal()
        {
            return PostOrderTraversal(root);
        }

        private IEnumerable<Student> PostOrderTraversal(Node node)
        {
            if (node != null)
            {
                foreach (var left in PostOrderTraversal(node.Left))
                    yield return left;
                foreach (var right in PostOrderTraversal(node.Right))
                    yield return right;
                yield return node.Data;
            }
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return PostOrderTraversal().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
