using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithms_lesson6
{
    public class Node //Вершина
    {
        public int Value { get; set; }
        public List<Edge> Edges { get; set; } //исходящие связи

        public Node()
        {
            Edges = new List<Edge>();
        }
        public Node(int data)
        {
            Edges = new List<Edge>();
            Value = data;
        }
    }

    public class Edge //Ребро
    {
        public int Weight { get; set; } //вес связи
        public Node Node { get; set; } // узел, на который связь ссылается

        public Edge(Node node, int weight)
        {
            Node = node;
            Weight = weight;
        }

        public Edge(Node node)
        {
            Node = node;            
        }
    }
    class Graph
    {
        public List<Node> Nodes = new List<Node>();
        public List<Edge> Edges = new List<Edge>();        

        public Node AddNode(int data)
        {
            if (ContainNode(data))
                throw new InvalidOperationException("Вершина с таким значением уже существует");

            var node = new Node(data);
            Nodes.Add(node);
            return node;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphNode">graphNode - узел, НА который ссылается связь</param>
        /// <returns></returns>
        public Edge AddEdge(Node graphNode)
        {
            var edge = new Edge(graphNode);
            Edges.Add(edge);
            return edge;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphNode">graphNode - узел, НА который ссылается связь</param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public Edge AddEdge(Node graphNode, int weight)
        {
            if (!ContainNode(graphNode.Value))
                throw new InvalidOperationException("Вершина не принадлежит графу");

            var edge = new Edge(graphNode, weight);
            Edges.Add(edge);
            return edge;
        }

        public bool ContainNode(int data) => Nodes.Any(x => x.Value.Equals(data));

        public void BFS(Node root)
        {
            if (root == null)
                return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                if (node != null)
                {
                    Console.WriteLine(node.Value);
                    foreach (Edge e in node.Edges)
                    {
                        if (e != null)
                            queue.Enqueue(e.Node);
                    }
                }
            }
        }

        public void DFS(Node root)
        {
            /*if (root == null)
                return;

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                Node node = stack.Pop();
                Console.WriteLine(node.Data);

                if (node.Right != null)
                    stack.Push(node.Right);
                if (node.Left != null)
                    stack.Push(node.Left);
            }*/
        }
    }
}
