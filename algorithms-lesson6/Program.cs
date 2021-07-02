﻿using System;

namespace algorithms_lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            var n1 = graph.AddNode(0);
            var n2 = graph.AddNode(1);
            var n3 = graph.AddNode(2);
            var n4 = graph.AddNode(3);
            var n5 = graph.AddNode(4);
            var n6 = graph.AddNode(5);
            var n7 = graph.AddNode(6);
            var n8 = graph.AddNode(7);
            var n9 = graph.AddNode(8);

            var e1 = graph.AddEdge(n2);
            var e2 = graph.AddEdge(n3);
            var e3 = graph.AddEdge(n4);
            var e4 = graph.AddEdge(null);
            var e5 = graph.AddEdge(n7);
            var e6 = graph.AddEdge(null);
            var e7 = graph.AddEdge(null);
            var e8 = graph.AddEdge(null);

            n1.Edges.Add(e1);
            n1.Edges.Add(e2);
            n1.Edges.Add(e3);
            n2.Edges.Add(e4);
            n2.Edges.Add(e5);
            n6.Edges.Add(e6);
            n4.Edges.Add(e7);
            n4.Edges.Add(e8);

            graph.BFS(n1);
        }
    }
}
