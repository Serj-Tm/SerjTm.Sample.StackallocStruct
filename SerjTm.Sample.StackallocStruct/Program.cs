using System;
using System.Runtime.InteropServices;

namespace SerjTm.Sample.StackallocStruct
{
    using Node3 = Node<Node<Node<long>>>;
    using Node4 = Node<Node<Node<Node<long>>>>;

    struct Node<T>
    {
        T t1;
        T t2;
        T t3;
        T t4;
        T t5;
        T t6;
        T t7;
        T t8;
        T t9;
        T t10;
        T t11;
        T t12;
        T t13;
        T t14;
        T t15;
        T t16;


        public Node<T> Add(ref Node<T> n2)
        {
            return n2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //выделяется на стеке
                //кидает StackoverflowException
                //если закоментировать, то падать перестанет
                if (true)
                {
                    Node3 n1;
                    Node3 n2;
                    Node3 n3;
                    Node3 n4;
                    Node3 n5;
                    Node3 n6;
                    Node3 n7;
                    Node3 n8;
                    Node3 n9;
                    Node3 n11;
                    Node3 n12;
                    Node3 n13;
                    Node3 n14;
                    Node3 n15;
                    Node3 n16;
                    Node3 n17;
                    Node3 n18;
                    Node3 n19;
                    Node3 n21;
                    Node3 n22;
                    Node3 n23;
                    Node3 n24;
                    Node3 n25;
                    Node3 n26;
                    Node3 n27;
                    Node3 n28;
                    Node3 n29;
                    Node3 n31;
                    Node3 n32;
                    Node3 n33;
                    Node3 n34;
                    Node3 n35;
                    Node3 n36;
                    Node3 n37;
                    Node3 n38;
                    Node3 n39;
                }

                //выделяется на heap-е
                var nodes = new Node3[100];

                nodes[2] = nodes[0].Add(ref nodes[1]);
            }
            catch(Exception exc)
            {
                Console.Error.WriteLine(exc);
            }

        }
    }
}
