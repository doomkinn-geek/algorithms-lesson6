﻿using System;
using System.Collections.Generic;
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
    }
}