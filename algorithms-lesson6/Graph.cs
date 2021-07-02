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
    }

    public class Edge //Ребро
    {
        public int Weight { get; set; } //вес связи
        public Node Node { get; set; } // узел, на который связь ссылается
    }
    class Graph
    {
        public List<Node> Nodes = new List<Node>();
        public List<Edge> Edges = new List<Edge>();        

        public Node AddNode(int data)
        {
            if (ContainsNode(data))
                throw new InvalidOperationException("Вершина с таким значением уже существует");

            var node = new Node();
            Nodes.Add(node);
            return node;
        }

        public bool ContainsNode(int data) => Nodes.Any(x => x.Value.Equals(data));
    }
}
